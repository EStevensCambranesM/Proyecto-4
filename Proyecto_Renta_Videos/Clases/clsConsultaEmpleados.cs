using Proyecto_Renta_Videos.ConexionBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Proyecto_Renta_Videos.Clases
{
    internal class clsConsultaEmpleados
    {
        public List<clsEmpleados> ObtenerTodosLosEmpleados()
        {
            List<clsEmpleados> lista = new List<clsEmpleados>();

            using (MySqlConnection conexion = clsConexionBD.ObtenerConexion())
            {
                if (conexion == null)
                {
                    return lista;
                }

                string consulta = "SELECT * FROM tblInfoEmpleado";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            clsEmpleados empleado = new clsEmpleados
                            {
                                IdInfoEmpleadoPK = Convert.ToInt32(lector["IdInfoEmpleadoPK"]),
                                sCUI = lector["sCUI"].ToString(),
                                sNombre = lector["sNombreEmpleado"].ToString(),
                                sApellido = lector["sApellidoEmpleado"].ToString(),
                                sCorreo = lector["sCorreoEmpleado"].ToString(),
                                cSexo = Convert.ToChar(lector["cSexoEmpleado"]),
                                sTelefono = lector["sTelefonoEmpleado"].ToString(),
                                iRolFK = Convert.ToInt32(lector["iRolFK"])
                            };

                            lista.Add(empleado);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
