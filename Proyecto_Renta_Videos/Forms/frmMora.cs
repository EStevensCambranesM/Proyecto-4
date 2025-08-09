using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmMora : Form
    {
        string connectionString = "server= 127.0.0.1; database=RentaDeVideos; uid=ESCM; pwd=escm1823";

        public frmMora()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Volver al menu principla
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void CambiarMora(int idRenta, bool estado)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE tblRenta SET bMora = @mora WHERE IdRentaPK = @idRenta";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mora", estado);
                    cmd.Parameters.AddWithValue("@idRenta", idRenta);

                    cmd.ExecuteNonQuery();

                    // Recargar datos del cliente seleccionado
                    if (cboCliente.SelectedItem is ComboBoxItem cliente)
                    {
                        CargarRentasConMora(cliente.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar mora: " + ex.Message);
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvMora.CurrentRow != null)
            {
                int diasAtraso = Convert.ToInt32(dgvMora.CurrentRow.Cells["Dias_atraso"].Value);
                int idRenta = Convert.ToInt32(dgvMora.CurrentRow.Cells["IdRenta"].Value);

                if (diasAtraso > 0)
                {
                    CambiarMora(idRenta, true);
                    MessageBox.Show("Multa aplicada.");
                }
                else
                {
                    MessageBox.Show("No hay días de atraso. No se aplica multa.");
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvMora.CurrentRow != null)
            {
                int idRenta = Convert.ToInt32(dgvMora.CurrentRow.Cells["IdRenta"].Value);
                CambiarMora(idRenta, false);
                MessageBox.Show("Mora eliminada.");
            }
        }

        private void frmMora_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.IdClientesPK, m.sNombre, m.sApellido 
                            FROM tblClientes c
                            INNER JOIN tblMembresíaCliente m ON c.iMembresiaClienteFK = m.IdMembresiaPK 
                            WHERE m.cEstado = 'A';";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cboCliente.Items.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("IdClientesPK");
                        string nombreCompleto = reader.GetString("sNombre") + " " + reader.GetString("sApellido");
                        cboCliente.Items.Add(new ComboBoxItem(nombreCompleto, id));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void CargarRentasConMora(int idCliente)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT r.IdRentaPK, r.bMora, f.dFechaEmision, m.sNombre, m.sApellido
                FROM tblRenta r
                INNER JOIN tblFactura f ON r.iFacturaFK = f.IdFacturaPK
                INNER JOIN tblClientes c ON r.iClienteFK = c.IdClientesPK
                INNER JOIN tblMembresíaCliente m ON c.iMembresiaClienteFK = m.IdMembresiaPK
                WHERE r.iEstado = 1 AND r.iClienteFK = @idCliente";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dgvMora.Rows.Clear();
                    dgvMora.Columns.Clear();

                    // Definir columnas si están vacías
                    if (dgvMora.Columns.Count == 0)
                    {
                        dgvMora.Columns.Add("IdRenta", "IdRenta");
                        dgvMora.Columns.Add("Cliente", "Cliente");
                        dgvMora.Columns.Add("Fecha", "Fecha");
                        dgvMora.Columns.Add("Mora", "Mora");
                        dgvMora.Columns.Add("Dias_atraso", "Días_atraso");
                    }

                    while (reader.Read())
                    {
                        int idRenta = reader.GetInt32("IdRentaPK");
                        string clienteNombre = reader.GetString("sNombre") + " " + reader.GetString("sApellido");
                        DateTime fechaEmision = reader.GetDateTime("dFechaEmision");
                        bool mora = reader.GetBoolean("bMora");

                        int diasAtraso = (DateTime.Now - fechaEmision).Days;

                        dgvMora.Rows.Add(idRenta, clienteNombre, fechaEmision.ToShortDateString(), mora ? "Sí" : "No", diasAtraso);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar rentas: " + ex.Message);
            }
        }

        private void cboCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem is ComboBoxItem cliente)
            {
                CargarRentasConMora(cliente.Value);
            }
        }
    }
}
