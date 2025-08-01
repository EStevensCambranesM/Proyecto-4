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
            this.lstRentas_activas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVolver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 36);
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
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devoluciones";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(109, 139);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 33);
            this.cboCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rentas Activas";
            // 
            // lstRentas_activas
            // 
            this.lstRentas_activas.FormattingEnabled = true;
            this.lstRentas_activas.ItemHeight = 25;
            this.lstRentas_activas.Location = new System.Drawing.Point(477, 179);
            this.lstRentas_activas.Name = "lstRentas_activas";
            this.lstRentas_activas.Size = new System.Drawing.Size(228, 79);
            this.lstRentas_activas.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar Devolucion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Verificaciones";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(255, 318);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(24, 25);
            this.total.TabIndex = 25;
            this.total.Text = "F";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Fecha de Renta";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(255, 269);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(24, 25);
            this.fecha.TabIndex = 27;
            this.fecha.Text = "F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Fecha Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Dias de Atraso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Multas:";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(555, 352);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(111, 46);
            this.btnDevolver.TabIndex = 32;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstRentas_activas);
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
        private System.Windows.Forms.ListBox lstRentas_activas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDevolver;
    }
}