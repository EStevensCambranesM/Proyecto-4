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
            this.lblIDRenta = new System.Windows.Forms.Label();
            this.txtIDRenta = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRentaPorCliente
            // 
            this.lblRentaPorCliente.AutoSize = true;
            this.lblRentaPorCliente.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaPorCliente.Location = new System.Drawing.Point(431, 8);
            this.lblRentaPorCliente.Name = "lblRentaPorCliente";
            this.lblRentaPorCliente.Size = new System.Drawing.Size(247, 40);
            this.lblRentaPorCliente.TabIndex = 0;
            this.lblRentaPorCliente.Text = "Renta Por Cliente";
            // 
            // lblIDRenta
            // 
            this.lblIDRenta.AutoSize = true;
            this.lblIDRenta.Location = new System.Drawing.Point(297, 105);
            this.lblIDRenta.Name = "lblIDRenta";
            this.lblIDRenta.Size = new System.Drawing.Size(87, 25);
            this.lblIDRenta.TabIndex = 5;
            this.lblIDRenta.Text = "ID Renta";
            // 
            // txtIDRenta
            // 
            this.txtIDRenta.Location = new System.Drawing.Point(424, 102);
            this.txtIDRenta.Multiline = true;
            this.txtIDRenta.Name = "txtIDRenta";
            this.txtIDRenta.Size = new System.Drawing.Size(206, 37);
            this.txtIDRenta.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 39);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(362, 202);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(316, 67);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvRenta
            // 
            this.dgvRenta.AllowUserToAddRows = false;
            this.dgvRenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9});
            this.dgvRenta.Location = new System.Drawing.Point(17, 308);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.ReadOnly = true;
            this.dgvRenta.RowHeadersWidth = 51;
            this.dgvRenta.RowTemplate.Height = 24;
            this.dgvRenta.Size = new System.Drawing.Size(1053, 150);
            this.dgvRenta.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Cliente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cantidad Rentada";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Factura";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NIT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha De Emision";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Precio Producto";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total compra";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(383, 494);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(316, 67);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmRentasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 1055);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtIDRenta);
            this.Controls.Add(this.lblIDRenta);
            this.Controls.Add(this.lblRentaPorCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRentasPorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRentasPorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRentaPorCliente;
        private System.Windows.Forms.Label lblIDRenta;
        private System.Windows.Forms.TextBox txtIDRenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}