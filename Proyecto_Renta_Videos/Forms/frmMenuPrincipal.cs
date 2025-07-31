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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Inicio de Sesion
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
            this.Hide();
        }

        private void nuevoUsuariooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Creacion Usuario
            frmSignIn signIn = new frmSignIn();
            signIn.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Modulo de Ayuda
            frmAyuda ayudaEmpleado = new frmAyuda();
            ayudaEmpleado.Show();
            this.Hide();
        }

        private void rentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a registrar renta
            frmRegistrar_renta registro_renta = new frmRegistrar_renta();
            registro_renta.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Devolucion
            frmDevolucion devolucion = new frmDevolucion();
            devolucion.Show();
            this.Hide();
            
        }

        private void moraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menu a Mora
            frmMora mora = new frmMora();
            mora.Show();
            this.Hide();
        }
    }
}
