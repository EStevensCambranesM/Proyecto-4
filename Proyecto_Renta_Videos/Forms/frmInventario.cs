using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmInventario : Form
    {
        
        List<Video> listaVideos = new List<Video>();
        int idActual = 1;

        public class Video
        {
            public int IdVideo { get; set; }
            public string Titulo { get; set; }
            public string Genero { get; set; }
            public int Anio { get; set; }
            public decimal Precio { get; set; }
            public string Estado { get; set; }
        }

        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // Cargar ítems en cbGenero si está vacío
            if (cbGenero.Items.Count == 0)
            {
                cbGenero.Items.AddRange(new string[] { "Todos", "Acción", "Comedia", "Drama", "Terror", "Familiar", "Otros" });
            }

            // Cargar ítems en cbEstado si está vacío
            if (cbEstado.Items.Count == 0)
            {
                cbEstado.Items.AddRange(new string[] { "Todos", "Disponible", "Rentado", "Inactivo" });
            }

            // Seleccionar opción por defecto (evita error si aún no hay ítems)
            cbGenero.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

            // Cargar datos simulados y mostrar
            CargarEjemplos();
            MostrarInventario(listaVideos);
        }


        private void CargarEjemplos()
        {
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "Matrix", Genero = "Acción", Anio = 1999, Precio = 15.00m, Estado = "Disponible" });
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "Shrek", Genero = "Familiar", Anio = 2001, Precio = 12.00m, Estado = "Rentado" });
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "El Aro", Genero = "Terror", Anio = 2002, Precio = 10.00m, Estado = "Disponible" });
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "Matrix", Genero = "Acción", Anio = 1999, Precio = 15.00m, Estado = "Disponible" });
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "Shrek", Genero = "Familiar", Anio = 2001, Precio = 12.00m, Estado = "Rentado" });
            listaVideos.Add(new Video { IdVideo = idActual++, Titulo = "El Aro", Genero = "Terror", Anio = 2002, Precio = 10.00m, Estado = "Disponible" });
        }

        private void MostrarInventario(List<Video> lista)
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = lista.Select(v => new
            {
                v.IdVideo,
                v.Titulo,
                v.Genero,
                v.Anio,
                Precio = "Q" + v.Precio.ToString("F2"),
                v.Estado
            }).ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txtBuscar.Text.Trim().ToLower();
            string genero = cbGenero.Text;
            string estado = cbEstado.Text;

            var filtrado = listaVideos.Where(v =>
                (string.IsNullOrEmpty(titulo) || v.Titulo.ToLower().Contains(titulo)) &&
                (genero == "Todos" || v.Genero == genero) &&
                (estado == "Todos" || v.Estado == estado)
            ).ToList();

            MostrarInventario(filtrado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un video para editar.");
                return;
            }

           // string titulo = dgvInventario.SelectedRows[0].Cells["Titulo"].Value.ToString();
           // MessageBox.Show($"Aquí podrías abrir un formulario para editar: {titulo}", "Editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un video para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["IdVideo"].Value);
            var videoAEliminar = listaVideos.FirstOrDefault(v => v.IdVideo == id);

            if (videoAEliminar != null)
            {
                var confirm = MessageBox.Show($"¿Eliminar {videoAEliminar.Titulo}?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    listaVideos.Remove(videoAEliminar);
                    MostrarInventario(listaVideos);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarInventario(listaVideos);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
