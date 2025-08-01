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
    public partial class frmMembresia : Form
    {
        public frmMembresia()
        {
            InitializeComponent();
            //Límite
            numLimite.Minimum = 1;
            numLimite.Maximum = 999;
            numLimite.Value = 5;
            numLimite.Increment = 1;
            //Numeracion maxima para la duración de la membresía
            numDuracion.Minimum = 1;
            numDuracion.Maximum = 365;
            numDuracion.Value = 30;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int duracion = (int)numDuracion.Value;
            decimal precio;
            int limite = (int)numLimite.Value;
            string descripcion = txtDescripcion.Text.Trim();
            bool activa = chkActiva.Checked;

            if (string.IsNullOrEmpty(nombre) || !decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Completa todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar 
            MessageBox.Show($"Membresía guardada:\n\n" +
                $"Nombre: {nombre}\nDuración: {duracion} días\nPrecio: Q{precio}\nLímite: {limite} rentas\nActiva: {(activa ? "Sí" : "No")}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar 
            txtNombre.Clear();
            numDuracion.Value = 30;
            txtPrecio.Clear();
            numLimite.Value = 5;
            txtDescripcion.Clear();
            chkActiva.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
