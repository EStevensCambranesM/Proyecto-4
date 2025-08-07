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
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string sUsuarioCorreo = txtUsuario.Text.Trim();
            string sPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(sUsuarioCorreo))
            {
                MessageBox.Show("Te falta tu correo o usuario");
                return;
            }
            if (string.IsNullOrEmpty(sPassword))
            {
                MessageBox.Show("Falta la contraseña que te asignaron");
                return;
            }

            DotEnv.Load();

            using (var conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return;
                }

                string consulta = @"SELECT * FROM tblLogIn WHERE (sUsuario = @entrada OR sCorreo = @entrada)
                                  AND sContraseña = SHA2(@contrasena,256)";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@entrada", sUsuarioCorreo);
                    comando.Parameters.AddWithValue("@contrasena", sPassword);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            string nombreUsuario = lector["sUsuario"].ToString();
                            MessageBox.Show("Bienvenido " + nombreUsuario);

                            //abre el menu principal
                            this.Hide();
                            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                            menuPrincipal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario, correo o contraseña incorrectos.");
                        }
                    }
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●'; 

        }
    }
}
