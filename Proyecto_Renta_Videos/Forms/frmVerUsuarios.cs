using dotenv.net;
using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
            DotEnv.Load();
            ConfigurarDataGridView();
            cargarEmpleados();
        }

        private void ConfigurarDataGridView()
        {
            dgvVerUsuarios.Columns.Clear();
            dgvVerUsuarios.AutoGenerateColumns = false;

            dgvVerUsuarios.Columns.Add("IdInfoEmpleadoPK", "ID");
            dgvVerUsuarios.Columns.Add("sCUI", "CUI");
            dgvVerUsuarios.Columns.Add("sNombre", "Nombre");
            dgvVerUsuarios.Columns.Add("sApellido", "Apellido");
            dgvVerUsuarios.Columns.Add("cSexo", "Sexo");
            dgvVerUsuarios.Columns.Add("sCorreo", "Correo");
            dgvVerUsuarios.Columns.Add("sTelefono", "Teléfono");
            dgvVerUsuarios.Columns.Add("iRolFK", "Rol");

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
            {
                Name = "btnEditar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            dgvVerUsuarios.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dgvVerUsuarios.Columns.Add(btnEliminar);
        }

        private void cargarEmpleados(string filtro = "")
        {
            dgvVerUsuarios.Rows.Clear();

            using (var conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion == null) return;

                string consulta = @"SELECT IdInfoEmpleadoPK, sCUI, sNombre, sApellido, sCorreo, cSexo, sTelefono, iRolFK
                                    FROM tblInfoEmpleado
                                    WHERE sNombre LIKE @filtro";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            dgvVerUsuarios.Rows.Add(
                                lector["IdInfoEmpleadoPK"],
                                lector["sCUI"],
                                lector["sNombre"],
                                lector["sApellido"],
                                lector["sCorreo"],
                                lector["cSexo"],
                                lector["sTelefono"],
                                lector["iRolFK"]
                            );
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            cargarEmpleados(filtro);
        }

        private void dgvVerUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = dgvVerUsuarios.Rows[e.RowIndex].Cells["IdInfoEmpleadoPK"].Value.ToString();

            if (dgvVerUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                MessageBox.Show($"Editar usuario con ID: {id}");
                // Abre un formulario de edición aquí
            }

            if (dgvVerUsuarios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    EliminarEmpleado(id);
                }
            }
        }

        private void EliminarEmpleado(string id)
        {
            using (var conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion == null) return;

                try
                {
                    // 1. Eliminar registros en tblLogin que dependen del empleado
                    string eliminarLogin = "DELETE FROM tblLogin WHERE iEmpleadoFK = @id";
                    using (var cmd1 = new MySqlCommand(eliminarLogin, conexion))
                    {
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Eliminar el empleado
                    string eliminarEmpleado = "DELETE FROM tblInfoEmpleado WHERE IdInfoEmpleadoPK = @id";
                    using (var cmd2 = new MySqlCommand(eliminarEmpleado, conexion))
                    {
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                    }

                    // Recargar tabla
                    cargarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            cargarEmpleados(txtBuscar.Text);
        }
    }
}
