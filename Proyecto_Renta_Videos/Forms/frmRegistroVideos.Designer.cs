namespace Proyecto_Renta_Videos.Forms
{
    partial class frmRegistroVideos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.lblRegistroVideos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(142, 121);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(142, 184);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 20);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Género:";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(142, 245);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(42, 20);
            this.lblanio.TabIndex = 3;
            this.lblanio.Text = "Año:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(142, 298);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(142, 356);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(101, 20);
            this.lblDisponible.TabIndex = 5;
            this.lblDisponible.Text = "¿Disponible?";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(285, 115);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(284, 26);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(285, 295);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(118, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(285, 239);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(118, 26);
            this.txtAnio.TabIndex = 8;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(285, 176);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(284, 28);
            this.cbGenero.TabIndex = 9;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Location = new System.Drawing.Point(297, 360);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(15, 14);
            this.chkDisponible.TabIndex = 11;
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // lblRegistroVideos
            // 
            this.lblRegistroVideos.AutoSize = true;
            this.lblRegistroVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroVideos.Location = new System.Drawing.Point(292, 51);
            this.lblRegistroVideos.Name = "lblRegistroVideos";
            this.lblRegistroVideos.Size = new System.Drawing.Size(264, 25);
            this.lblRegistroVideos.TabIndex = 12;
            this.lblRegistroVideos.Text = "REGISTRO DE VIDEOS ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(285, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsVolver
            // 
            this.tlsVolver.Name = "tlsVolver";
            this.tlsVolver.Size = new System.Drawing.Size(97, 20);
            this.tlsVolver.Text = "Volver al menú";
            this.tlsVolver.Click += new System.EventHandler(this.tlsVolver_Click);
            // 
            // frmRegistroVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRegistroVideos);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegistroVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroVideos";
            this.Load += new System.EventHandler(this.frmRegistroVideos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Label lblRegistroVideos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsVolver;
    }
}