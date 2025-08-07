using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmRegistrarRenta : Form
    {
        //cadena de conexion
        string connectionString = "server= 192.168.1.250; database=RentaDeVideos; uid=remoto1; pwd=123456";
        private DateTime fechaActual;


        public frmRegistrarRenta()
        {
            InitializeComponent();
        }

        private void CargarVideosDisponibles()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT  * from tblTipoVideo";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAgregarrenta.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
        }
        private void msVolver_Click(object sender, EventArgs e)
        {
            // Volver al menu principla
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void frmRegistrarRenta_Load(object sender, EventArgs e)
        {
            //Fecha de emision
            fecha.Text = DateTime.Now.ToString("g");
            fechaActual = DateTime.Now;
            //cargar videos disponibles
            CargarVideosDisponibles();
            //contador de videos agregados
            dgvVideos.AllowUserToAddRows = false;
            label8.Text = "0";
            //cargar clientes 
            CargarCliente();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar TextBox
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNIT.Text))
            {
                MessageBox.Show("El campo 'NIT' está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbometodo_pago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar DataGridView lista de videos
            if (dgvAgregarrenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay videos en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar DataGridView videos añadidos
            if (dgvVideos.Rows.Count == 0)
            {
                MessageBox.Show("No hay videos en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // todo correcto
            MessageBox.Show("Datos agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int idFactura = InsertarFactura();
            if (idFactura > 0)
            {
                InsertarRenta(idFactura);
            }
            else
            {
                MessageBox.Show("No se pudo registrar la factura.");
            }
        }

        //Agregar Rentas a la lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvAgregarrenta.CurrentRow != null)
            {
                int index = dgvAgregarrenta.CurrentRow.Index;

                //para agregar los datos de la fila seleccionada
                string idvideo = dgvAgregarrenta.Rows[index].Cells["CodVideoPK"].Value.ToString();
                string descp = dgvAgregarrenta.Rows[index].Cells["iDescripcionFK"].Value.ToString();
                string formato = dgvAgregarrenta.Rows[index].Cells["cFormato"].Value.ToString();
                string nombre = dgvAgregarrenta.Rows[index].Cells["sNombre"].Value.ToString();

                dgvVideos.Rows.Add(idvideo, descp, formato, nombre);

                //mostrar la canridad de videos agregados
                label8.Text = dgvVideos.RowCount.ToString();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un video.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarVideo_Click(object sender, EventArgs e)
        {
            //Eliminar videos de la lista de agregar
            if (dgvVideos.CurrentRow != null)
            {
                dgvVideos.Rows.Remove(dgvVideos.CurrentRow);

                //actualizar contador cuando se elimina un video
                label8.Text = dgvVideos.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarCliente()
        {
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

                    //limpiar antes de llenar
                    cboCliente.Items.Clear();

                    //Agregar datos
                    while (reader.Read())
                    {
                        int idCliente = reader.GetInt32("IdClientesPk");
                        string nombrecompleto = reader.GetString("sNombre") + " " + reader.GetString("sApellido");
                        //Agregar con Display y Value
                        cboCliente.Items.Add(new ComboBoxItem(nombrecompleto, idCliente));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Clientes" + ex.Message);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            { Text = text; Value = value; }

            public override string ToString()
            {

                { return Text; }
            }
        }

        private int InsertarFactura()
        {
            int idFactura = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO tblFactura 
                (iNumeroFactura, sNIT, sDireccionLocal, dFechaEmision, dcPrecioProducto, dcTotalCompra)
                VALUES 
                (@Numero, @NIT, @Direccion, @Fecha, @Precio, @Total);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        //leer los datos del formulario
                        int numeroFactura = new Random().Next(1000, 9999);
                        string nit = txtNIT.Text.Trim();
                        string direccion = txtDireccion.Text.Trim();

                        //Asignar los parametros
                        cmd.Parameters.AddWithValue("@Numero", numeroFactura);
                        cmd.Parameters.AddWithValue("@NIT", nit);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Fecha", fechaActual);
                        cmd.Parameters.AddWithValue("@Precio", 0.00);
                        cmd.Parameters.AddWithValue("@Total", 0.00);

                        cmd.ExecuteNonQuery();
                    }
                    string sqlGetId = "SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd2 = new MySqlCommand(sqlGetId, conn))
                    {
                        idFactura = Convert.ToInt32(cmd2.ExecuteScalar());
                    }

                    MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idFactura;
        }

        private void InsertarRenta(int idFactura)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO tblRenta 
                (iClienteFK, iFacturaFK, iMetodoPago, iEstado, bMora, bDescuento)
                VALUES 
                (@Cliente, @Factura, @MetodoPago, @Estado, @Mora, @Descuento);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        //para obtener el cliente
                        ComboBoxItem clienteSeleccionado = cboCliente.SelectedItem as ComboBoxItem;
                        if (clienteSeleccionado == null)
                        {
                            MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int idCliente = clienteSeleccionado.Value;
                        //obtener el metodo de pago
                        int metodoPago = cbometodo_pago.SelectedItem?.ToString() == "Efectivo" ? 1 : 2;
                        //obtener el descuento
                        bool descuento = chkAplicar_desc.Checked;

                        //insertando los valores
                        cmd.Parameters.AddWithValue("@Cliente", idCliente);
                        cmd.Parameters.AddWithValue("@Factura", idFactura);
                        cmd.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        cmd.Parameters.AddWithValue("@Estado", 1); // Activa
                        cmd.Parameters.AddWithValue("@Mora", false); // Sin mora
                        cmd.Parameters.AddWithValue("@Descuento", descuento);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Renta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la renta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
