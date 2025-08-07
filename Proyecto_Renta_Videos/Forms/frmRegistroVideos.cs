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
    public partial class frmRegistroVideos : Form
    {
        public frmRegistroVideos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string genero = cbGenero.Text;
            int anio;
            decimal precio;
            bool disponible = chkDisponible.Checked;

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAnio.Text, out anio) || anio < 1900 || anio > DateTime.Now.Year)
            {
                MessageBox.Show("Año inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio < 0)
            {
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar 
            MessageBox.Show("Video registrado:\n\n" +
                $"Título: {titulo}\nGénero: {genero}\n Año: {anio}\nPrecio: Q{precio}\nDisponible: {(disponible ? "Sí" : "No")}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar
            txtTitulo.Clear();
            cbGenero.SelectedIndex = -1;
            txtAnio.Clear();
            txtPrecio.Clear();
            chkDisponible.Checked = true;
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGenero.Items.AddRange(new String[] { "Acción", "Drama", "Comedia", "Terror", "Animación", "Otros"});
        }
        private void frmRegistroVideos_Load(object sender, EventArgs e)
        {
            cbGenero.Items.AddRange(new string[] {
        "Acción", "Comedia", "Drama", "Terror", "Animación", "Otros"
    });


            cbGenero.SelectedIndex = 0;
        }

        private void tlsVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal RegresoMenu = new frmMenuPrincipal();
            RegresoMenu.Show();
            this.Hide();
        }
    }
    }

