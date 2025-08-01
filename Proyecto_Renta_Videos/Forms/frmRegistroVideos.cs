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
            string clasificacion = cbClasificacion.Text;
            int anio;
            decimal precio;
            bool disponible = chkDisponible.Checked;

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(clasificacion))
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
                $"Título: {titulo}\nGénero: {genero}\nClasificación: {clasificacion}\nAño: {anio}\nPrecio: Q{precio}\nDisponible: {(disponible ? "Sí" : "No")}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar
            txtTitulo.Clear();
            cbGenero.SelectedIndex = -1;
            cbClasificacion.SelectedIndex = -1;
            txtAnio.Clear();
            txtPrecio.Clear();
            chkDisponible.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGenero.Items.AddRange(new String[] { "Acción", "Drama", "Comedia", "Terror", "Animación", "Otros"});
        }

        private void cbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClasificacion.Items.AddRange(new String[] { "G", "PG", "PG-13", "R", "NC-17" });
        }

        private void frmRegistroVideos_Load(object sender, EventArgs e)
        {
            cbGenero.Items.AddRange(new string[] {
        "Acción", "Comedia", "Drama", "Terror", "Animación", "Otros"
    });

            cbClasificacion.Items.AddRange(new string[] {
        "G", "PG", "PG-13", "R", "NC-17"
    });

            cbGenero.SelectedIndex = 0;
            cbClasificacion.SelectedIndex = 0;
        }
    }
    }

