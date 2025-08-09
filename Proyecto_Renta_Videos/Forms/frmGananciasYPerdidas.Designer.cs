namespace Proyecto_Renta_Videos.Forms
{
    partial class frmGananciasYPerdidas
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
            this.lblGananciasPerdidas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblTotalPerdidas = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.dgvGanancias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGananciasPerdidas
            // 
            this.lblGananciasPerdidas.AutoSize = true;
            this.lblGananciasPerdidas.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasPerdidas.Location = new System.Drawing.Point(449, 9);
            this.lblGananciasPerdidas.Name = "lblGananciasPerdidas";
            this.lblGananciasPerdidas.Size = new System.Drawing.Size(311, 43);
            this.lblGananciasPerdidas.TabIndex = 0;
            this.lblGananciasPerdidas.Text = "Ganancias/Perdidas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(784, 131);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(151, 60);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(219, 131);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(151, 60);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblTotalPerdidas
            // 
            this.lblTotalPerdidas.AutoSize = true;
            this.lblTotalPerdidas.Location = new System.Drawing.Point(606, 455);
            this.lblTotalPerdidas.Name = "lblTotalPerdidas";
            this.lblTotalPerdidas.Size = new System.Drawing.Size(0, 25);
            this.lblTotalPerdidas.TabIndex = 15;
            this.lblTotalPerdidas.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(-7, -1);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(127, 33);
            this.btnVolverMenu.TabIndex = 18;
            this.btnVolverMenu.Text = "Volver";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // dgvGanancias
            // 
            this.dgvGanancias.AllowUserToAddRows = false;
            this.dgvGanancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanancias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvGanancias.Location = new System.Drawing.Point(12, 259);
            this.dgvGanancias.Name = "dgvGanancias";
            this.dgvGanancias.RowHeadersWidth = 51;
            this.dgvGanancias.RowTemplate.Height = 24;
            this.dgvGanancias.Size = new System.Drawing.Size(1154, 267);
            this.dgvGanancias.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Cierre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ganancias";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Perdidas";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad Videos Rentados";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad Videos Perdidos";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha Hora Cierre";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // frmGananciasYPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1172, 563);
            this.Controls.Add(this.dgvGanancias);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.lblTotalPerdidas);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblGananciasPerdidas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGananciasYPerdidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGananciasYPerdidas";
            this.Load += new System.EventHandler(this.frmGananciasYPerdidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGananciasPerdidas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblTotalPerdidas;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.DataGridView dgvGanancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}