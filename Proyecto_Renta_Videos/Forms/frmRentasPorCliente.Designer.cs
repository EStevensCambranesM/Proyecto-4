namespace Proyecto_Renta_Videos.Forms
{
    partial class frmRentasPorCliente
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
            this.lblRentaPorCliente = new System.Windows.Forms.Label();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRentaPorCliente
            // 
            this.lblRentaPorCliente.AutoSize = true;
            this.lblRentaPorCliente.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaPorCliente.Location = new System.Drawing.Point(438, 9);
            this.lblRentaPorCliente.Name = "lblRentaPorCliente";
            this.lblRentaPorCliente.Size = new System.Drawing.Size(247, 40);
            this.lblRentaPorCliente.TabIndex = 0;
            this.lblRentaPorCliente.Text = "Renta Por Cliente";
            this.lblRentaPorCliente.Click += new System.EventHandler(this.lblRentaPorCliente_Click);
            // 
            // dgvRenta
            // 
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvRenta.Location = new System.Drawing.Point(-5, 76);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.RowHeadersWidth = 51;
            this.dgvRenta.RowTemplate.Height = 24;
            this.dgvRenta.Size = new System.Drawing.Size(1106, 463);
            this.dgvRenta.TabIndex = 1;
            this.dgvRenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRenta_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_Cliente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha_Renta";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Monto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre_Pelicula";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Genero";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Metodo_Pago";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Multa";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // frmRentasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1113, 578);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.lblRentaPorCliente);
            this.Name = "frmRentasPorCliente";
            this.Text = "frmRentasPorCliente";
            this.Load += new System.EventHandler(this.frmRentasPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRentaPorCliente;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}