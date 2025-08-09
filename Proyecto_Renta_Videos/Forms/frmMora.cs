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
        string connectionString = "server=192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";

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
                    MessageBox.Show("No hay días de atraso. No se aplica mora.");
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

        private void CargarRentasConMora(int idCliente, int plazoDias = 7)
        {
           try
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string sql = @"
             SELECT 
             r.IdRentaPK,
             CONCAT(m.sNombre, ' ', m.sApellido) AS Cliente,
             f.dFechaEmision,
             r.bMora
             FROM tblRenta r
             JOIN tblFactura f           ON r.iFacturaFK = f.IdFacturaPK
             JOIN tblClientes c          ON r.iClienteFK = c.IdClientesPK
             JOIN tblMembresíaCliente m  ON c.iMembresiaClienteFK = m.IdMembresiaPK
             WHERE r.iEstado = 1 AND r.iClienteFK = @cli;";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@cli", idCliente);
                using (var rd = cmd.ExecuteReader())
                {
                    // Config columnas una vez
                    if (dgvMora.Columns.Count == 0)
                    {
                        dgvMora.AllowUserToAddRows = false;
                        dgvMora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvMora.MultiSelect = false;

                        dgvMora.Columns.Add("IdRenta", "IdRenta");
                        dgvMora.Columns.Add("Cliente", "Cliente");
                        dgvMora.Columns.Add("Fecha", "Fecha");

                        var colMora = new DataGridViewCheckBoxColumn { Name = "Mora", HeaderText = "Mora", ReadOnly = true };
                        dgvMora.Columns.Add(colMora);

                        var colDias = new DataGridViewTextBoxColumn { Name = "Dias_atraso", HeaderText = "Días_atraso" };
                        dgvMora.Columns.Add(colDias);
                    }

                    dgvMora.Rows.Clear();
                    while (rd.Read())
                    {
                        int idRenta = rd.GetInt32("IdRentaPK");
                        string cliente = rd.GetString("Cliente");
                        DateTime fechaEmision = rd.GetDateTime("dFechaEmision");
                        bool mora = rd.GetBoolean("bMora");

                        // Vencimiento = Emisión + plazo
                        DateTime vence = fechaEmision.Date.AddDays(plazoDias);
                        int diasAtraso = (DateTime.Now.Date - vence).Days;
                        if (diasAtraso < 0) diasAtraso = 0;

                        dgvMora.Rows.Add(idRenta, cliente, fechaEmision.ToShortDateString(), mora, diasAtraso);
                    }
                }
            }
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

        private void dgvMora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
