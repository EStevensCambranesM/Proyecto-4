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
    public partial class frmRegistrarRenta : Form
    {
        public frmRegistrarRenta()
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

        private void frmRegistrarRenta_Load(object sender, EventArgs e)
        {
            //Fecha de emision
            fecha.Text = DateTime.Now.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar TextBox
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNIT.Text))
            {
                MessageBox.Show("El campo 'NIT' está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar ComboBox
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbometodo_pago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar ListBox
            if (lstVideos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un video.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar DataGridView
            if (dgvVideos.Rows.Count == 0)
            {
                MessageBox.Show("No hay videos en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // todo correcto
            MessageBox.Show("Datos agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
