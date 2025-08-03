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
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal irMenuPrincipal = new frmMenuPrincipal();
            irMenuPrincipal.Show();
            this.Hide();
        }

        private void dgvVerUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
