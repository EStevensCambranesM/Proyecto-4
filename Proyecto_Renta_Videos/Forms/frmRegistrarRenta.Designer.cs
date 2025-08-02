namespace Proyecto_Renta_Videos.Forms
{
    partial class frmRegistrarRenta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msVolver = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cbometodo_pago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAplicar_desc = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.dgvAgregarrenta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarrenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msVolver
            // 
            this.msVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msVolver.Name = "msVolver";
            this.msVolver.Size = new System.Drawing.Size(81, 32);
            this.msVolver.Text = "Volver";
            this.msVolver.Click += new System.EventHandler(this.msVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Renta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(92, 155);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 33);
            this.cboCliente.TabIndex = 3;
            // 
            // cbometodo_pago
            // 
            this.cbometodo_pago.FormattingEnabled = true;
            this.cbometodo_pago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbometodo_pago.Location = new System.Drawing.Point(582, 155);
            this.cbometodo_pago.Name = "cbometodo_pago";
            this.cbometodo_pago.Size = new System.Drawing.Size(193, 33);
            this.cbometodo_pago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metodo de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Aplicar Descuento?";
            // 
            // chkAplicar_desc
            // 
            this.chkAplicar_desc.AutoSize = true;
            this.chkAplicar_desc.Location = new System.Drawing.Point(1056, 166);
            this.chkAplicar_desc.Name = "chkAplicar_desc";
            this.chkAplicar_desc.Size = new System.Drawing.Size(18, 17);
            this.chkAplicar_desc.TabIndex = 7;
            this.chkAplicar_desc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Videos Disponibles";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(339, 393);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Videos Añadidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Datos Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Direccion Local";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(415, 516);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 30);
            this.txtDireccion.TabIndex = 17;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(726, 516);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(170, 30);
            this.txtNIT.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(657, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "NIT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha Emision";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(410, 574);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(24, 25);
            this.fecha.TabIndex = 21;
            this.fecha.Text = "F";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(721, 574);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(25, 25);
            this.total.TabIndex = 23;
            this.total.Text = "T";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(657, 574);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(503, 638);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(161, 41);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar Renta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.MinimumWidth = 6;
            this.Formato.Name = "Formato";
            this.Formato.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // CodVideo
            // 
            this.CodVideo.HeaderText = "CodVideo";
            this.CodVideo.MinimumWidth = 6;
            this.CodVideo.Name = "CodVideo";
            this.CodVideo.Width = 125;
            // 
            // dgvVideos
            // 
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVideo,
            this.Descripcion,
            this.Formato,
            this.Nombre});
            this.dgvVideos.Location = new System.Drawing.Point(638, 237);
            this.dgvVideos.Name = "dgvVideos";
            this.dgvVideos.RowHeadersWidth = 51;
            this.dgvVideos.RowTemplate.Height = 24;
            this.dgvVideos.Size = new System.Drawing.Size(554, 150);
            this.dgvVideos.TabIndex = 12;
            // 
            // dgvAgregarrenta
            // 
            this.dgvAgregarrenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarrenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAgregarrenta.Location = new System.Drawing.Point(18, 237);
            this.dgvAgregarrenta.Name = "dgvAgregarrenta";
            this.dgvAgregarrenta.RowHeadersWidth = 51;
            this.dgvAgregarrenta.RowTemplate.Height = 24;
            this.dgvAgregarrenta.Size = new System.Drawing.Size(558, 150);
            this.dgvAgregarrenta.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CodVideo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Formato";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // frmRegistrarRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1222, 703);
            this.Controls.Add(this.dgvAgregarrenta);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvVideos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkAplicar_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbometodo_pago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistrarRenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarRenta";
            this.Load += new System.EventHandler(this.frmRegistrarRenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarrenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cbometodo_pago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAplicar_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVideo;
        private System.Windows.Forms.DataGridView dgvVideos;
        private System.Windows.Forms.DataGridView dgvAgregarrenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}