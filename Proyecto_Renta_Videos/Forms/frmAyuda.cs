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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modulo ayuda a Menu Principal
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
