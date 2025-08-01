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
    public partial class frmNewProveedor : Form
    {
        public frmNewProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void tslRegresar_Click(object sender, EventArgs e)
        {


        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //botón de newproveedor a menú
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();

            //Ocultar forms nuevo proveedor
            frmNewProveedor newProveedor = new frmNewProveedor();
            newProveedor.Close();
        }
    }
}
