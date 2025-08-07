using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;   // <-namespace de clsConexionBD
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;  // para PrintDocument
using System.IO;                // para Path



namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmRentasPorCliente : Form


    {
        public frmRentasPorCliente()
        {
            InitializeComponent();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // 1. Validar IdCliente
            if (!int.TryParse(txtIDRenta.Text.Trim(), out int idCliente))
            {
                MessageBox.Show("Ingrese un ID de cliente válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configurar columnas del DataGridView
            dgvRenta.Columns.Clear();
            dgvRenta.ColumnCount = 8;
            dgvRenta.Columns[0].Name = "Nombre";
            dgvRenta.Columns[1].Name = "Apellido";
            dgvRenta.Columns[2].Name = "Cantidad Rentas";
            dgvRenta.Columns[3].Name = "Factura #";
            dgvRenta.Columns[4].Name = "NIT";
            dgvRenta.Columns[5].Name = "Fecha Emisión";
            dgvRenta.Columns[6].Name = "Precio Producto";
            dgvRenta.Columns[7].Name = "Total Compra";
            dgvRenta.Rows.Clear();

            // 3. Ejecutar consulta
            string sql = @"
                SELECT 
                    mc.sNombre, 
                    mc.sApellido, 
                    mc.iCantidadRentas,
                    r.iFacturaFK,
                    f.sNIT, 
                    f.dFechaEmision, 
                    f.dcPrecioProducto, 
                    f.dcTotalCompra
                FROM tblClientes c
                JOIN tblMembresíaCliente mc 
                  ON c.iMembresiaClienteFK = mc.IdMembresiaPK
                JOIN tblRenta r 
                  ON r.iClienteFK = c.IdClientesPK
                JOIN tblFactura f 
                  ON f.IdFacturaPK = r.iFacturaFK
                WHERE c.IdClientesPK = @id;
            ";

            MySqlConnection conn = null;
            try
            {
                conn = clsConexionBD.ObtenerConexion();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRenta.Rows.Add(
                                reader["sNombre"].ToString(),
                                reader["sApellido"].ToString(),
                                reader["iCantidadRentas"].ToString(),
                                reader["iFacturaFK"].ToString(),
                                reader["sNIT"].ToString(),
                                Convert.ToDateTime(reader["dFechaEmision"]).ToString("yyyy-MM-dd"),
                                reader["dcPrecioProducto"].ToString(),
                                reader["dcTotalCompra"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar datos:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsConexionBD.CerrarConexion();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Verificar que haya datos
            if (dgvRenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Crear el bitmap del DataGridView completo
            //    (asegúrate de que el grid tenga el tamaño suficiente o ajusta el Height)
            var bmp = new Bitmap(dgvRenta.Width, dgvRenta.Height);
            dgvRenta.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // 3. Configurar PrintDocument
            var pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true; // si quieres horizontal
            pd.PrintPage += (s, ev) =>
            {
                // Dibujar el bitmap en la página
                ev.Graphics.DrawImage(bmp, 0, 0);
            };

            // 4. Seleccionar la impresora PDF y la ruta de salida
            //    -- Debes tener "Microsoft Print to PDF" instalado (viene por defecto en Win10+)
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintToFile = true;

            // Ruta donde quieres guardar el PDF
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombre = $"Renta_Cliente_{txtIDRenta.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            pd.PrinterSettings.PrintFileName = Path.Combine(escritorio, nombre);

            try
            {
                // 5. Disparar la impresión
                pd.Print();
                MessageBox.Show($"PDF generado en:\n{pd.PrinterSettings.PrintFileName}", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

