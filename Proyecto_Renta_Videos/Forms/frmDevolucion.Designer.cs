namespace Proyecto_Renta_Videos.Forms
{
    partial class frmDevolucion
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
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRentaactiva = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.renta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.atraso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.multas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentaactiva)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 36);
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
            this.label1.Location = new System.Drawing.Point(339, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devoluciones";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(135, 124);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 33);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rentas Activas";
            // 
            // dgvRentaactiva
            // 
            this.dgvRentaactiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentaactiva.Location = new System.Drawing.Point(12, 254);
            this.dgvRentaactiva.Name = "dgvRentaactiva";
            this.dgvRentaactiva.RowHeadersWidth = 51;
            this.dgvRentaactiva.RowTemplate.Height = 24;
            this.dgvRentaactiva.Size = new System.Drawing.Size(554, 150);
            this.dgvRentaactiva.TabIndex = 33;
            this.dgvRentaactiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentaactiva_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(583, 519);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(10, 10);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Devolucion";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(798, 254);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(24, 25);
            this.fecha.TabIndex = 27;
            this.fecha.Text = "F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Fecha Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Verificaciones";
            // 
            // renta
            // 
            this.renta.AutoSize = true;
            this.renta.Location = new System.Drawing.Point(798, 302);
            this.renta.Name = "renta";
            this.renta.Size = new System.Drawing.Size(56, 25);
            this.renta.TabIndex = 36;
            this.renta.Text = "renta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha Renta";
            // 
            // atraso
            // 
            this.atraso.AutoSize = true;
            this.atraso.Location = new System.Drawing.Point(798, 355);
            this.atraso.Name = "atraso";
            this.atraso.Size = new System.Drawing.Size(66, 25);
            this.atraso.TabIndex = 38;
            this.atraso.Text = "atraso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Dias de Atraso";
            // 
            // multas
            // 
            this.multas.AutoSize = true;
            this.multas.Location = new System.Drawing.Point(798, 405);
            this.multas.Name = "multas";
            this.multas.Size = new System.Drawing.Size(69, 25);
            this.multas.TabIndex = 40;
            this.multas.Text = "multas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Multas";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(469, 487);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(108, 42);
            this.btnDevolver.TabIndex = 41;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click_1);
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(980, 562);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.multas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.atraso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.renta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRentaactiva);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDevolucion";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentaactiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRentaactiva;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label renta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label atraso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDevolver;
    }
}