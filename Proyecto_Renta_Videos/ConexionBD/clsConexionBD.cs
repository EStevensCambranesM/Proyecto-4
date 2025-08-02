using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using dotenv.net;

namespace Proyecto_Renta_Videos.ConexionBD
{
    internal class clsConexionBD
    {
        public static MySqlConnection Conexion;

        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                // Cargar variables del archivo .env
                DotEnv.Load();

                string Servidor = Environment.GetEnvironmentVariable("DB_SERVER");
                string Puerto = Environment.GetEnvironmentVariable("DB_PORT");
                string Usuario = Environment.GetEnvironmentVariable("DB_USER");
                string Contraseña = Environment.GetEnvironmentVariable("DB_PASSWORD");
                string NombreBD = Environment.GetEnvironmentVariable("DB_NAME");

                string CadenaConexion = $"server={Servidor};port={Puerto};user={Usuario};password={Contraseña};database={NombreBD};";

                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();

                return Conexion;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexión: " + ex.Message);
                return null;
            }
        }

        public static void CerrarConexion()
        {
            if (Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }
    }
}
