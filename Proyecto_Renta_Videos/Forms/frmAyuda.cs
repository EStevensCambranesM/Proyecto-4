using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Renta_Videos.Forms
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void volverAMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modulo ayuda a Menu Principal
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            // boton para descargar manual de usuario
            string sURL = "https://drive.google.com/drive/folders/14RZ_BSfYicMXU8rhO-zyb2M2sKT9E682?usp=sharing"; // link de drive

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = sURL,
                    UseShellExecute = true
                });
                MessageBox.Show("Redirigiendo a la Ayuda del Usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace de ayuda. " + ex.Message);
            }
        }
    }
}
