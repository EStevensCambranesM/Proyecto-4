using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmRegistrar_renta : Form
    {
        public frmRegistrar_renta()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_renta_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            //validar los textbox
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Direccion' esta vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNIT.Text))
            {
                MessageBox.Show("El campo 'NIT' esta vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar los combobox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbometodo_pago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un metodo de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validar listbox
            if (lstVideos.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un video.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validar dataGridView
            if (dgvVideos.Rows.Count == 0)
            {
                MessageBox.Show("No hay videos en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // todo correcto
            MessageBox.Show("Datos agregados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
