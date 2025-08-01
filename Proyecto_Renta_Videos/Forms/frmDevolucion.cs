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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void msVolver_Click(object sender, EventArgs e)
        {
            // Volver al menu principla
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            //Fecha de Actual
            fecha.Text = DateTime.Now.ToString();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar ListBox
            if (lstRentas_activas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una renta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
