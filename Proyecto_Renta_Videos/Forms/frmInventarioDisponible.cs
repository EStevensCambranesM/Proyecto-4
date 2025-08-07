using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;  // tu clsConexionBD
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmInventarioDisponible : Form
    {
        public frmInventarioDisponible()
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
            // 1. Validar ID Inventario
            if (!int.TryParse(txtInventarioDisponible.Text.Trim(), out int idInventario))
            {
                MessageBox.Show("Ingrese un ID de inventario válido.", "ID Inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configurar columnas del DataGridView
            dgvInventario.Columns.Clear();
            dgvInventario.ColumnCount = 9;
            dgvInventario.Columns[0].Name = "Renta";
            dgvInventario.Columns[1].Name = "Cod Video";
            dgvInventario.Columns[2].Name = "Detalle Compras";
            dgvInventario.Columns[3].Name = "Cantidad Disponible";
            dgvInventario.Columns[4].Name = "Estado";
            dgvInventario.Columns[5].Name = "F Renta";
            dgvInventario.Columns[6].Name = "F Devolucion";
            dgvInventario.Columns[7].Name = "Precio Renta";
            dgvInventario.Columns[8].Name = "Precio Perdida";
            dgvInventario.Rows.Clear();

            // 3. Consulta SQL
            string sql = @"
                SELECT 
                  iRentaFK,
                  iCodVideoFK,
                  iDetalleComprasFK,
                  iCantidadDisponible,
                  cEstado,
                  dFechaRenta,
                  dFechaDevolucion,
                  dcPrecioRenta,
                  dcPrecioPerdida
                FROM tblInventario
                WHERE IdInventarioPK = @id;
            ";

            MySqlConnection conn = null;
            try
            {
                conn = clsConexionBD.ObtenerConexion();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idInventario);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvInventario.Rows.Add(
                                reader["iRentaFK"].ToString(),
                                reader["iCodVideoFK"].ToString(),
                                reader["iDetalleComprasFK"].ToString(),
                                reader["iCantidadDisponible"].ToString(),
                                reader["cEstado"].ToString(),
                                Convert.ToDateTime(reader["dFechaRenta"]).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(reader["dFechaDevolucion"]).ToString("yyyy-MM-dd"),
                                reader["dcPrecioRenta"].ToString(),
                                reader["dcPrecioPerdida"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar inventario:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsConexionBD.CerrarConexion();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Verificar que haya datos en el grid
            if (dgvInventario.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Capturar el DataGridView como bitmap
            var ancho = dgvInventario.Width;
            var alto = dgvInventario.Height;
            var bmp = new Bitmap(ancho, alto);
            dgvInventario.DrawToBitmap(bmp, new Rectangle(0, 0, ancho, alto));

            // 3. Configurar el PrintDocument
            var pd = new PrintDocument
            {
                DefaultPageSettings = { Landscape = true }  // horizontal si lo deseas
            };
            pd.PrintPage += (s, ev) =>
            {
                // Ajusta escala si cabe demasiado grande:
                ev.Graphics.DrawImage(bmp, 0, 0, ancho * 0.9f, alto * 0.9f);
            };

            // 4. Imprimir a PDF
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintToFile = true;
            // ruta donde se guardará el PDF
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombre = $"Inventario_{txtInventarioDisponible.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            pd.PrinterSettings.PrintFileName = Path.Combine(escritorio, nombre);

            try
            {
                pd.Print();
                MessageBox.Show($"PDF generado en:\n{pd.PrinterSettings.PrintFileName}",
                                "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
