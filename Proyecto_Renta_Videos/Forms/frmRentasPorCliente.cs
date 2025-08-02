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
    public partial class frmRentasPorCliente : Form
    {
        public frmRentasPorCliente()
        {
            InitializeComponent();
        }

        private void frmRentasPorCliente_Load(object sender, EventArgs e)
        {
            dgvRenta.ColumnCount = 7;
            dgvRenta.Columns[0].Name = "ID Cliente";
            dgvRenta.Columns[1].Name = "Nombre";
            dgvRenta.Columns[2].Name = "Teléfono";
            dgvRenta.Columns[3].Name = "Descripción";
            dgvRenta.Columns[4].Name = "ID Producto";
            dgvRenta.Columns[5].Name = "Nombre Producto";
            dgvRenta.Columns[6].Name = "Cantidad Rentada";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRentaPorCliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text) || string.IsNullOrWhiteSpace(txtIDProducto.Text))
            {
                MessageBox.Show("Por favor completa al menos el ID del cliente y del producto.");
                return;
            }

            // Agregar datos al DataGridView
            dgvRenta.Rows.Add(
                txtIDCliente.Text,
                txtNombreCliente.Text,
                txtTelefono.Text,
                txtDescripcion.Text,
                txtIDProducto.Text,
                txtNombreProducto.Text,
                txtCantidad.Text
            );

            MessageBox.Show("Renta agregada correctamente.");

            // Limpiar campos
            txtIDCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();
            txtDescripcion.Clear();
            txtIDProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidad.Clear();
        
    }
    }
}
