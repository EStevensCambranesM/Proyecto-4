using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Renta_Videos.Clases
{
    internal class clsEmpleados
    {
        public int IdInfoEmpleadoPK { get; set; }
        public string sCUI { get; set; }
        public string sNombre { get; set; }
        public string sApellido { get; set; }
        public string sCorreo { get; set; }
        public char cSexo { get; set; }
        public string sTelefono { get; set; }
        public int iRolFK {  get; set; }
    }
}
