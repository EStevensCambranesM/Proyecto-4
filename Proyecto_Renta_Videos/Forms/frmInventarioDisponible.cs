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
    public partial class frmInventarioDisponible : Form
    {
        public frmInventarioDisponible()
        {
            InitializeComponent();
        }

        private void frmInventarioDisponible_Load(object sender, EventArgs e)
        {
            dgvInventario.ColumnCount = 9;
            dgvInventario.Columns[0].Name = "ID Producto";
            dgvInventario.Columns[1].Name = "Nombre";
            dgvInventario.Columns[2].Name = "Categoría";
            dgvInventario.Columns[3].Name = "Stock";
            dgvInventario.Columns[4].Name = "Precio";
            dgvInventario.Columns[5].Name = "Proveedor";
            dgvInventario.Columns[6].Name = "Fecha Ingreso";
            dgvInventario.Columns[7].Name = "Estado";
            dgvInventario.Columns[8].Name = "Descripción";
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor completa al menos el ID y el Nombre del producto.");
                return;
            }

            // Agregar fila al DataGridView
            dgvInventario.Rows.Add(
                txtID.Text,
                txtNombre.Text,
                txtCategoria.Text,
                txtStock.Text,
                txtPrecio.Text,
                txtProveedor.Text,
                txtFecha.Text,
                txtEstado.Text,
                txtDescripcion.Text
            );

            MessageBox.Show("¡Datos agregados exitosamente!");

            // Limpiar los campos (opcional)
            txtID.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtProveedor.Clear();
            txtFecha.Clear();
            txtEstado.Clear();
            txtDescripcion.Clear();
        }
    }
}
