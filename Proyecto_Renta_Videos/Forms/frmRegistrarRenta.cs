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
using System.Globalization;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmRegistrarRenta : Form
    {
        //cadena de conexion
<<<<<<< HEAD
        string connectionString = "server= 127.0.0.1; database=RentaDeVideos; uid=ESCM; pwd=escm1823";
=======
        string connectionString = "server= 192.168.1.50; database=RentaDeVideos; uid=remoto1; pwd=123456";
>>>>>>> 36558c87c8b7ac9044f3a20105fe8e0ed95c9031
        private DateTime fechaActual;
        private decimal totalAcumulado = 0m;


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
            totalAcumulado = 0;
            total.Text = totalAcumulado.ToString("0.00");
            //cargar clientes 
            CargarCliente();
            CargarMetodosPago();

            //Limitar NIT y Direccion
            txtNIT.MaxLength = 9;
            txtDireccion.MaxLength = 15;


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
            MessageBox.Show("Datos, renta y factura registrados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            decimal subtotal = totalAcumulado;

            bool aplicarDescuento = chkAplicar_desc.Checked;
            decimal totalFinal = aplicarDescuento ? Math.Round(subtotal * 0.90m, 2) : subtotal;

            total.Text = totalFinal.ToString("0.00");

            int idFactura = InsertarFactura(subtotal, totalFinal);
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
                string precio = dgvAgregarrenta.Rows[index].Cells["dcPrecio"].Value.ToString();

                dgvVideos.Rows.Add(idvideo, descp, formato, nombre, precio);

                if (decimal.TryParse(precio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal p))
                {
                    totalAcumulado += p;
                    total.Text = totalAcumulado.ToString("0.00");
                }

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
                var val = dgvVideos.CurrentRow.Cells[4].Value.ToString();
                if (decimal.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal p))
                {
                    totalAcumulado -= p;
                    if (totalAcumulado < 0) totalAcumulado = 0;
                    total.Text = totalAcumulado.ToString("0.00");
                }

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

        private int InsertarFactura(decimal subtotal, decimal totalFinal)
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
                        cmd.Parameters.AddWithValue("@Precio", subtotal);
                        cmd.Parameters.AddWithValue("@Total", totalFinal);

                        cmd.ExecuteNonQuery();
                    }
                    string sqlGetId = "SELECT LAST_INSERT_ID();";
                    using (MySqlCommand cmd2 = new MySqlCommand(sqlGetId, conn))
                    {
                        idFactura = Convert.ToInt32(cmd2.ExecuteScalar());
                    }
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
                        var metodoItem = cbometodo_pago.SelectedItem as ComboBoxItem;
                        if (metodoItem == null)
                        {
                            MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int metodoPago = metodoItem.Value;
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la renta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMetodosPago()
        {
            cbometodo_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbometodo_pago.Items.Clear();

            cbometodo_pago.Items.Add(new ComboBoxItem("Efectivo", 1));
            cbometodo_pago.Items.Add(new ComboBoxItem("Tarjeta", 2));

            cbometodo_pago.SelectedIndex = 0; // opcional
        }

    }
}
