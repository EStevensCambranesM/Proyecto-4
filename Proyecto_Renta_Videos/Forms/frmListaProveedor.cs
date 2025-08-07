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
    public partial class frmListaProveedor : Form
    {
        public frmListaProveedor()
        {
            InitializeComponent();
            this.Load += frmListaProveedor_Load;
        }


        private void frmListaProveedor_Load(object sender, EventArgs e)
        {
            CargaProveedores();
        }

        private void CargaProveedores()
        {
            try
            {
                using (MySqlConnection conexion = clsConexionBD.Conectar())
                {
                    string query = @"Select
                                    IdProveedoresPK AS ID,
                                    sNombre AS Nombre,
                                    sDireccion AS Dirección,
                                    sTelefono AS Teléfono,
                                    sCorreo AS Correo,
                                    sContactoPrincipal AS Contacto,
                                    bActivo AS Activo
                                    FROM tblProveedores";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvProveedores.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar este dato?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idProveedor =
                        Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["ID"].Value);
                    try
                    {
                        using (MySqlConnection conexion = clsConexionBD.Conectar())
                        {
                            string query = "DELETE FROM tblProveedores WHERE IdProveedoresPK = @id";
                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idProveedor);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Proveedor eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaProveedores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void msRegreso_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal Regresar = new frmMenuPrincipal();
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
    }
}
