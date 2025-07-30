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

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nuevo proveedor
            frmNewProveedor proveedor = new frmNewProveedor();
            proveedor.Show();
            this.Hide();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nuevo cliente
            frmNuevoCliente proveedor = new frmNuevoCliente();
            proveedor.Show();
            this.Hide();
        }
    }
}
