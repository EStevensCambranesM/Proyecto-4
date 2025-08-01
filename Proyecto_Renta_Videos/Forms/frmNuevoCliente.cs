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
    public partial class frmNuevoCliente : Form
    {
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public frmNuevoCliente()
        {
            InitializeComponent();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label Nombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(30, 30);

            // TextBox Nombre
            this.txtNombre.Location = new System.Drawing.Point(120, 30);
            this.txtNombre.Width = 200;

            // Label Teléfono
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Location = new System.Drawing.Point(30, 70);

            // TextBox Teléfono
            this.txtTelefono.Location = new System.Drawing.Point(120, 70);
            this.txtTelefono.Width = 200;

            // Label Correo
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.Location = new System.Drawing.Point(30, 110);

            // TextBox Correo
            this.txtCorreo.Location = new System.Drawing.Point(120, 110);
            this.txtCorreo.Width = 200;

            // Botón Guardar
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(80, 160);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Botón Cancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(180, 160);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Formulario
            this.Text = "Nuevo Cliente";
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes agregar el código para guardar en base de datos, o por ahora, solo mostrar mensaje:
            MessageBox.Show("Cliente guardado exitosamente:\n\n" +
                            $"Nombre: {nombre}\nTeléfono: {telefono}\nCorreo: {correo}",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: limpiar campos
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
