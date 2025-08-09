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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void msVolver_Click(object sender, EventArgs e)
        {
            // Volver al menu principla
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            //Fecha de Actual
            fecha.Text = DateTime.Now.ToString();
            CargarCliente();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar DataGridView lista de videos
            if (dgvRentaactiva.Rows.Count == 0)
            {
                MessageBox.Show("No hay videos en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void CargarCliente()
        {
            string connectionString = "server= 127.0.0.1; database=RentaDeVideos; uid=ESCM; pwd=escm1823";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    c.IdClientesPK, 
                    m.sNombre, 
                    m.sApellido 
                FROM tblClientes c
                INNER JOIN tblMembresíaCliente m 
                    ON c.iMembresiaClienteFK = m.IdMembresiaPK
                WHERE m.cEstado = 'A';";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cboCliente.Items.Clear();

                    while (reader.Read())
                    {
                        int idCliente = reader.GetInt32("IdClientesPK");
                        string nombreCompleto = reader.GetString("sNombre") + " " + reader.GetString("sApellido");
                        cboCliente.Items.Add(new ComboBoxItem(nombreCompleto, idCliente));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void CargarRentasActivas(int idCliente)
        {
            string connectionString = "server= 127.0.0.1; database=RentaDeVideos; uid=ESCM; pwd=escm1823";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    IdRentaPK, 
                    iFacturaFK, 
                    iMetodoPago, 
                    bMora, 
                    bDescuento
                FROM tblRenta
                WHERE iClienteFK = @ClienteID AND iEstado = 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClienteID", idCliente);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRentaactiva.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar rentas activas: " + ex.Message);
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem clienteSeleccionado = cboCliente.SelectedItem as ComboBoxItem;
            if (clienteSeleccionado != null)
            {
                int idCliente = clienteSeleccionado.Value;
                CargarRentasActivas(idCliente);
            }
        }

        private void dgvRentaactiva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvRentaactiva.CurrentRow != null && dgvRentaactiva.CurrentRow.Index >= 0)
            {
                var idRenta = dgvRentaactiva.CurrentRow.Cells["IdRentaPK"].Value.ToString();

                // Muestra el mensaje de éxito
                MessageBox.Show("Devolución exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una renta activa para devolver.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }
    }
   }


