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
    public partial class frmMora : Form
    {
        public frmMora()
        {
            InitializeComponent();
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modulo Registrar renta a Menu Principal
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            // Validar los combobox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validar dataGridView
            if (dgvmora.Rows.Count == 0)
            {
                MessageBox.Show("No hay renta seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            // Validar los combobox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validar dataGridView
            if (dgvmora.Rows.Count == 0)
            {
                MessageBox.Show("No hay renta seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
