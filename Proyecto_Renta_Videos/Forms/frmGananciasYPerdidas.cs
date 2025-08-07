using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;  // namespace de clsConexionBD
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
    public partial class frmGananciasYPerdidas : Form
    {
        public frmGananciasYPerdidas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // 1. Configurar columnas
            dgvGanancias.Columns.Clear();
            dgvGanancias.ColumnCount = 6;
            dgvGanancias.Columns[0].Name = "Id Cierre";
            dgvGanancias.Columns[1].Name = "Ganancias";
            dgvGanancias.Columns[2].Name = "Pérdidas";
            dgvGanancias.Columns[3].Name = "Videos Rentados";
            dgvGanancias.Columns[4].Name = "Videos Perdidos";
            dgvGanancias.Columns[5].Name = "Fecha/Hora Cierre";
            dgvGanancias.Rows.Clear();

            // 2. Consulta
            string sql = @"
            SELECT
              IdCierrePK    AS IdCierre,
              dcGanancias,
              dcPerdidas,
              iCantidadVideosRentados,
              iCantidadVideosPerdidos,
              dFechaHoraCierre
            FROM tblCierre;
            ";

            MySqlConnection conn = null;
            try
            {
                conn = clsConexionBD.ObtenerConexion();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvGanancias.Rows.Add(
                            reader["IdCierre"].ToString(),
                            reader["dcGanancias"].ToString(),
                            reader["dcPerdidas"].ToString(),
                            reader["iCantidadVideosRentados"].ToString(),
                            reader["iCantidadVideosPerdidos"].ToString(),
                            Convert.ToDateTime(reader["dFechaHoraCierre"])
                                    .ToString("yyyy-MM-dd HH:mm:ss")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cierres:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsConexionBD.CerrarConexion();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Comprueba que haya datos
            if (dgvGanancias.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Captura el DataGridView como Bitmap
            int ancho = dgvGanancias.Width;
            int alto = dgvGanancias.Height;
            var bmp = new Bitmap(ancho, alto);
            dgvGanancias.DrawToBitmap(bmp, new Rectangle(0, 0, ancho, alto));

            // 3. Configura el PrintDocument
            var pd = new PrintDocument
            {
                DefaultPageSettings = { Landscape = true }  // horizontal
            };
            pd.PrintPage += (s, ev) =>
            {
                // Ajusta si quieres escalado:
                float escala = Math.Min(
                    ev.PageBounds.Width / (float)bmp.Width,
                    ev.PageBounds.Height / (float)bmp.Height);
                int w = (int)(bmp.Width * escala);
                int h = (int)(bmp.Height * escala);
                ev.Graphics.DrawImage(bmp, 0, 0, w, h);
            };

            // 4. Selecciona impresora PDF y ruta
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintToFile = true;
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombre = $"Cierres_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            pd.PrinterSettings.PrintFileName = Path.Combine(escritorio, nombre);

            // 5. Imprime
            try
            {
                pd.Print();
                MessageBox.Show($"PDF generado en:\n{pd.PrinterSettings.PrintFileName}",
                                "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

