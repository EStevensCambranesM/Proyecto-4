using dotenv.net;
using MySql.Data.MySqlClient;
using Proyecto_Renta_Videos.ConexionBD;
using System;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
            DotEnv.Load();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // 0. Validar que no haya campos vacíos
            if (!ValidacionCamposVacios()) return;

            DotEnv.Load();
            using (var conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No hay conexión a la BD.");
                    return;
                }

                // 1. Insertar en tblInfoEmpleado
                string insertEmpleado = @"
                    INSERT INTO tblInfoEmpleado 
                      (sCUI, sNombre, sApellido, sCorreo, cSexo, sTelefono, iRolFK)
                    VALUES
                      (@CUI, @Nombre, @Apellido, @Correo, @Sexo, @Telefono, @Rol)";
                long ultimoIdEmpleado;
                using (var cmdEmp = new MySqlCommand(insertEmpleado, conexion))
                {
                    cmdEmp.Parameters.AddWithValue("@CUI", txtCUIEmpleado.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@Nombre", txtNombresEmpleado.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@Apellido", txtApellidosEmpleado.Text.Trim());
                    cmdEmp.Parameters.AddWithValue("@Correo", txtCorreoEmpleado.Text.Trim());
                    // 'M' o 'F'
                    cmdEmp.Parameters.AddWithValue("@Sexo", cboSexoEmpleado.SelectedItem.ToString()[0]);
                    cmdEmp.Parameters.AddWithValue("@Telefono", txtTelefonoEmpleado.Text.Trim());
                    // Asumimos que los roles están ordenados: 0=Admin,1=Empleado,2=Practicante
                    cmdEmp.Parameters.AddWithValue("@Rol", cboRolEmpresa.SelectedIndex + 1);

                    cmdEmp.ExecuteNonQuery();
                    ultimoIdEmpleado = cmdEmp.LastInsertedId;
                }

                // 2. Generar nombre de usuario automático
                string usuarioGenerado = GenerarNombreUsuario(
                    txtNombresEmpleado.Text.Trim(),
                    txtApellidosEmpleado.Text.Trim()
                );

                // 3. Insertar en tblLogIn con SHA2 de la contraseña
                string insertLogin = @"
                    INSERT INTO tblLogIn 
                      (iEmpleadoFK, sUsuario, sCorreo, sContraseña)
                    VALUES
                      (@IdEmp, @Usuario, @Correo, SHA2(@Pass,256))";
                using (var cmdLog = new MySqlCommand(insertLogin, conexion))
                {
                    cmdLog.Parameters.AddWithValue("@IdEmp", ultimoIdEmpleado);
                    cmdLog.Parameters.AddWithValue("@Usuario", usuarioGenerado);
                    cmdLog.Parameters.AddWithValue("@Correo", txtCorreoEmpleado.Text.Trim());
                    cmdLog.Parameters.AddWithValue("@Pass", txtPassword.Text.Trim());

                    cmdLog.ExecuteNonQuery();
                }

                MessageBox.Show(
                    $"Empleado registrado exitosamente.\n" +
                    $"Usuario generado: {usuarioGenerado}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
        }

        private bool ValidacionCamposVacios()
        {
            if (string.IsNullOrWhiteSpace(txtNombresEmpleado.Text))
            {
                MessageBox.Show("Llena el campo Nombres Empleado");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidosEmpleado.Text))
            {
                MessageBox.Show("Llena el campo Apellidos Empleado");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreoEmpleado.Text))
            {
                MessageBox.Show("Llena el campo Correo Electrónico Empleado");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCUIEmpleado.Text))
            {
                MessageBox.Show("Llena el campo CUI Empleado");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoEmpleado.Text))
            {
                MessageBox.Show("Llena el campo Teléfono Móvil Empleado");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Llena el campo Contraseña Empleado");
                return false;
            }
            if (cboRolEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Rol en Empresa");
                return false;
            }
            if (cboSexoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Sexo Empleado");
                return false;
            }
            return true;
        }

        private string GenerarNombreUsuario(string nombre, string apellido)
        {
            var primerNombre = nombre.Split(' ')[0].ToLower();
            var primerApellido = apellido.Split(' ')[0].ToLower();
            // e.g. "juan" + "sandoval" => "jsandoval"
            return primerNombre[0] + primerApellido;
        }
    }
}
