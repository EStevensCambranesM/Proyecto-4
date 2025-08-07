using dotenv.net;
using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;
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
    public partial class frmNewProveedor : Form
    {
        public frmNewProveedor()
        {
            InitializeComponent();
            DotEnv.Load();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingresa al menos el nombre y teléfono del proveedor.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = clsConexionBD.Conectar())
                {

                    string query = @"INSERT INTO tblProveedores 
                            (sNombre, sDireccion, sTelefono, sCorreo, sContactoPrincipal, bActivo) 
                            VALUES 
                            (@nombre, @direccion, @telefono, @correo, @contacto, @activo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@contacto", txtContactoRespaldo.Text.Trim());
                        cmd.Parameters.AddWithValue("@activo", chkActivo.Checked);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Proveedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreProveedor.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContactoRespaldo.Clear();
            chkActivo.Checked = false;
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //botón de newproveedor a menú
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }

}

