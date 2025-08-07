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
    public partial class frmListaProveedores : Form
    {
        public frmListaProveedores()
        {
            InitializeComponent();
        }

        private void regresoAMenùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal IraMenu = new frmMenuPrincipal(); 
            IraMenu.Show();
            this.Hide();
        }
    }
}
