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
            string sUsuarioCorreo = txtUsuario.Text.Trim(); // puede ser usuario o correo
            string sPassword = txtPassword.Text.Trim(); // contraseña ingresada

            // Campos vacios
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

            // Conexion a la BD
            DotEnv.Load(); // para cargar variables de entorno

            using (MySqlConnection conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion != null)
                {
                    string consulta = @"SELECT * FROM tblLogIn WHERE (sUsuario = @entrada OR sCorreo = @entrada)
                                      AND sContraseña = SHA2(@sContraseña,256)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@entrada", sUsuarioCorreo);
                    comando.Parameters.AddWithValue("@sContraseña", sPassword);

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        string nombreUsuario = lector["usuario"].ToString();
                        MessageBox.Show("Bienvenido " + nombreUsuario);

                        // Abrir el menú principal
                        this.Hide();
                        frmMenuPrincipal menu = new frmMenuPrincipal();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario, correo o contraseña incorrectos.");
                    }

                    lector.Close();
                    clsConexionBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                }
            }

        }
    }
}
