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
            frmNuevoCliente nuevoCliente = new frmNuevoCliente();
            nuevoCliente.Show();
            this.Hide();
        }

        private void membresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formulario membresía
            frmMembresia membresia = new frmMembresia();
            membresia.Show();
        }

        private void rentasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentasPorCliente rentasPorCliente = new frmRentasPorCliente();
            rentasPorCliente.Show();
            this.Hide();
        }

        private void inventarioDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioDisponible inventarioDisponible = new frmInventarioDisponible();
            inventarioDisponible.Show();
            this.Hide();
        }

        private void gananciasYPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGananciasYPerdidas ganancias = new frmGananciasYPerdidas();
            ganancias.Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
            this.Hide();
        }
    }
}