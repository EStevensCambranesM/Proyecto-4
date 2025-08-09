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
using Proyecto_Renta_Videos.ConexionBD;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmCompra : Form
    {
        private List<Compra> listaCompras = new List<Compra>();
        public frmCompra()
        {
            InitializeComponent();
            this.Load += frmCompra_Load;

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void regresarAMenùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal Menu = new frmMenuPrincipal();
            this.Close();

            // Cerrar frmMenuPrincipal si ya está abierto
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (frm.Name == "frmMenuPrincipal")
                {
                    frm.Close();
                }
            }

            // Abrir una nueva instancia del menú principal
            frmMenuPrincipal nuevoMenu = new frmMenuPrincipal();
            nuevoMenu.Show();
        }

        private void txtCompras_Click(object sender, EventArgs e)
        {

        }

        private void CargarProveedores()
        {
            try
            {
                using (MySqlConnection conexion = clsConexionBD.Conectar())
                {
                    string query = "SELECT IdProveedoresPK, sNombre FROM tblProveedores";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cboProveedores.DataSource = dt;
                            cboProveedores.DisplayMember = "sNombre";
                            cboProveedores.ValueMember = "IdProveedoresPK";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string producto = txtProducto.Text;
                string proveedor = cboProveedores.Text;
                int cantidad = int.Parse(nudCantidad.Text);
                decimal precio = decimal.Parse(txtSubtotal.Text);
                decimal subtotal = cantidad * precio;

                Compra nuevaCompra = new Compra
                {
                    Producto = producto,
                    Proveedor = proveedor,
                    Cantidad = cantidad,
                    Subtotal = subtotal
                };
                listaCompras.Add(nuevaCompra);

                dgvCompras.DataSource = null;
                dgvCompras.DataSource = listaCompras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
            {
                int index = dgvCompras.CurrentRow.Index;
                listaCompras.RemoveAt(index);
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = listaCompras;
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaCompras.Count == 0)
            {
                MessageBox.Show("No hay compras para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = clsConexionBD.Conectar())
                {
                    conexion.Open();

                    //  Insertar cabecera en tblCompras
                    string insertCompra = "INSERT INTO tblCompras (dFechaCompra, cEstadoCompra, dcTotal) VALUES (NOW(), 'COM', @total)";
                    using (MySqlCommand cmd = new MySqlCommand(insertCompra, conexion))
                    {
                        decimal total = listaCompras.Sum(c => c.Subtotal);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();
                    }

                    // Obtener el ID recién insertado de tblCompras
                    long idCompraGenerada = cmdUltimoID(conexion);

                    //  Insertar detalle por cada producto en tblDetalleCompras
                    foreach (Compra compra in listaCompras)
                    {
                        string insertDetalle = @"INSERT INTO tblDetalleCompras (ComprasFK, ProductoFK, iCantidad, dcSubtotal)
                                         VALUES (@idCompra, @idProducto, @cantidad, @subtotal)";

                        using (MySqlCommand cmd = new MySqlCommand(insertDetalle, conexion))
                        {
                            int idProducto = ObtenerIdProductoPorNombre(compra.Producto, conexion);
                            cmd.Parameters.AddWithValue("@idCompra", idCompraGenerada);
                            cmd.Parameters.AddWithValue("@idProducto", idProducto);
                            cmd.Parameters.AddWithValue("@cantidad", compra.Cantidad);
                            cmd.Parameters.AddWithValue("@subtotal", compra.Subtotal);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Compras guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaCompras.Clear();
                dgvCompras.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha guardado exitosamente ", "FELICIDADES", MessageBoxButtons.OK);
            }
        }

        private long cmdUltimoID(MySqlConnection conexion)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conexion))
            {
                return (long)cmd.ExecuteScalar();
            }
        }

        // Método para obtener el ID de un producto por su nombre
        private int ObtenerIdProductoPorNombre(string nombreProducto, MySqlConnection conexion)
        {
            string query = "SELECT IdProductoPK FROM tblProducto WHERE sNombreProducto = @nombre";
            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("No se encontró el producto: " + nombreProducto);
                }
            }
        }
        public class Compra
        {
            public string Producto { get; set; }
            public string Proveedor { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
        }

        private void frmCompra_Load_1(object sender, EventArgs e)
        {

        }
    }
}

