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

            dgvRentaactiva.CellClick += dgvRentaactiva_CellContentClick;
            btnDevolver.Click += btnDevolver_Click;
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
            string connectionString = "server=192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";

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
            string connectionString = "server=192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";

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
            var clienteSeleccionado = cboCliente.SelectedItem as ComboBoxItem;
            if (clienteSeleccionado == null) return;

            CargarRentasActivas(clienteSeleccionado.Value);

            if (dgvRentaactiva.Rows.Count > 0)
            {
                dgvRentaactiva.ClearSelection();
                dgvRentaactiva.Rows[0].Selected = true;
                dgvRentaactiva.CurrentCell = dgvRentaactiva.Rows[0].Cells[0];
                ActualizarVerificacionesDesdeFilaActual();
            }
            else
            {
                renta.Text = "—";
                atraso.Text = "0";
                multas.Text = "No";
            }
        }
        

        private void dgvRentaactiva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) ActualizarVerificacionesDesdeFilaActual();
        }

        private void ActualizarVerificacionesDesdeFilaActual(int diasPlazo = 7)
        {
            if (dgvRentaactiva.CurrentRow == null) return;

            object val = dgvRentaactiva.CurrentRow.Cells["iFacturaFK"].Value;
            if (val == null) return;

            int idFactura;
            if (!int.TryParse(val.ToString(), out idFactura)) return;

            string connectionString = "server=192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT dFechaEmision FROM tblFactura WHERE IdFacturaPK=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idFactura);
                        var result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            DateTime fechaEmision = Convert.ToDateTime(result);
                            renta.Text = fechaEmision.ToString("g");

                            int diasAtraso = (DateTime.Now.Date - fechaEmision.Date).Days - diasPlazo;
                            if (diasAtraso < 0) diasAtraso = 0;
                            atraso.Text = diasAtraso.ToString();
                            multas.Text = diasAtraso > 0 ? "Sí" : "No";
                        }
                        else
                        {
                            renta.Text = "—";
                            atraso.Text = "0";
                            multas.Text = "No";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha de la factura: " + ex.Message);
            }
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

        private void btnDevolver_Click_1(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cliente.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvRentaactiva.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una renta activa.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRenta = Convert.ToInt32(dgvRentaactiva.CurrentRow.Cells["IdRentaPK"].Value);
            string connectionString = "server=192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "UPDATE tblRenta SET iEstado = 2 WHERE IdRentaPK = @rentaId", conn))
                    {
                        cmd.Parameters.AddWithValue("@rentaId", idRenta);
                        cmd.ExecuteNonQuery();
                    }
                }

                // refrescar la grilla del cliente actual
                var cli = cboCliente.SelectedItem as ComboBoxItem;
                if (cli != null) CargarRentasActivas(cli.Value);

                // limpiar verificaciones
                renta.Text = "—";
                atraso.Text = "0";
                multas.Text = "No";

                MessageBox.Show("Devolución registrada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la devolución: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
   


