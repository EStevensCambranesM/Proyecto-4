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
    public partial class frmGananciasYPerdidas : Form
    {
        public frmGananciasYPerdidas()
        {
            InitializeComponent();
        }

        private void lblGanancias_Click(object sender, EventArgs e)
        {

        }

        private void frmGananciasYPerdidas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTotaldeRentas.Text, out double rentas) &&
        double.TryParse(txtOtrosIngresos.Text, out double otros))
            {
                double totalIngresos = rentas + otros;
                txtTotaldeIngresos.Text = totalIngresos.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para rentas y otros ingresos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcularPerdida_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGastosOperativos.Text, out double gastos) &&
        double.TryParse(txtMantenimiento.Text, out double mantenimiento))
            {
                double totalPerdidas = gastos + mantenimiento;
                txtTotaldePerdidas.Text = totalPerdidas.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para gastos y mantenimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblPerdidasTotales_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
