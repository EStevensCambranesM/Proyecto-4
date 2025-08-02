namespace Proyecto_Renta_Videos.Forms
{
    partial class frmAyuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msNavegacionAyuda = new System.Windows.Forms.MenuStrip();
            this.volverAMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManualUsuario = new System.Windows.Forms.Button();
            this.msNavegacionAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacionAyuda
            // 
            this.msNavegacionAyuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msNavegacionAyuda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAMenuToolStripMenuItem});
            this.msNavegacionAyuda.Location = new System.Drawing.Point(0, 0);
            this.msNavegacionAyuda.Name = "msNavegacionAyuda";
            this.msNavegacionAyuda.Size = new System.Drawing.Size(431, 29);
            this.msNavegacionAyuda.TabIndex = 0;
            // 
            // volverAMenuToolStripMenuItem
            // 
            this.volverAMenuToolStripMenuItem.Name = "volverAMenuToolStripMenuItem";
            this.volverAMenuToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.volverAMenuToolStripMenuItem.Text = "Volver a Menu";
            this.volverAMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAMenuToolStripMenuItem_Click);
            // 
            // btnManualUsuario
            // 
            this.btnManualUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualUsuario.Location = new System.Drawing.Point(96, 78);
            this.btnManualUsuario.Name = "btnManualUsuario";
            this.btnManualUsuario.Size = new System.Drawing.Size(236, 39);
            this.btnManualUsuario.TabIndex = 2;
            this.btnManualUsuario.Text = "Necesito Ayuda";
            this.btnManualUsuario.UseVisualStyleBackColor = true;
            this.btnManualUsuario.Click += new System.EventHandler(this.btnManualUsuario_Click);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(431, 177);
            this.Controls.Add(this.btnManualUsuario);
            this.Controls.Add(this.msNavegacionAyuda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msNavegacionAyuda;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAyuda";
            this.msNavegacionAyuda.ResumeLayout(false);
            this.msNavegacionAyuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacionAyuda;
        private System.Windows.Forms.ToolStripMenuItem volverAMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnManualUsuario;
    }
}