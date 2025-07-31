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

        private void registrarRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a registrar renta
            frmRegistrarRenta registro_renta = new frmRegistrarRenta();
            registro_renta.Show();
            this.Hide();
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
            // menu a rentas por cliente
            frmRentasPorCliente rentasPorCliente = new frmRentasPorCliente();
            rentasPorCliente.Show();
            this.Hide();
        }

        private void inventarioDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // menu a inventario
            frmInventarioDisponible inventarioDisponible = new frmInventarioDisponible();
            inventarioDisponible.Show();
            this.Hide();
        }

        private void gananciasYPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // menu a ganancias
            frmGananciasYPerdidas ganancias = new frmGananciasYPerdidas();
            ganancias.Show();
            this.Hide();
        }

        private void registrarRentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Menu a registrar renta
            frmRegistrarRenta registro_renta = new frmRegistrarRenta();
            registro_renta.Show();
            this.Hide();
        }

        private void devoluciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Menu a Devolucion
            frmDevolucion devolucion = new frmDevolucion();
            devolucion.Show();
            this.Hide();
        }

        private void moraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Menu a Mora
            frmMora mora = new frmMora();
            mora.Show();
        }
    }
}