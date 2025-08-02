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
            this.lblGanancias = new System.Windows.Forms.Label();
            this.lblPerdidas = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.txtTotaldeIngresos = new System.Windows.Forms.TextBox();
            this.lblTotaldeRentas = new System.Windows.Forms.Label();
            this.txtTotaldeRentas = new System.Windows.Forms.TextBox();
            this.lblOtrosIngresos = new System.Windows.Forms.Label();
            this.txtOtrosIngresos = new System.Windows.Forms.TextBox();
            this.lblGastosOperativos = new System.Windows.Forms.Label();
            this.txtGastosOperativos = new System.Windows.Forms.TextBox();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCalcularPerdida = new System.Windows.Forms.Button();
            this.lblTotalPerdidas = new System.Windows.Forms.Label();
            this.txtTotaldePerdidas = new System.Windows.Forms.TextBox();
            this.lblPerdidasTotales = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGananciasPerdidas
            // 
            this.lblGananciasPerdidas.AutoSize = true;
            this.lblGananciasPerdidas.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasPerdidas.Location = new System.Drawing.Point(313, 28);
            this.lblGananciasPerdidas.Name = "lblGananciasPerdidas";
            this.lblGananciasPerdidas.Size = new System.Drawing.Size(311, 43);
            this.lblGananciasPerdidas.TabIndex = 0;
            this.lblGananciasPerdidas.Text = "Ganancias/Perdidas";
            this.lblGananciasPerdidas.Click += new System.EventHandler(this.lblGanancias_Click);
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(87, 83);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(106, 25);
            this.lblGanancias.TabIndex = 1;
            this.lblGanancias.Text = "Ganancias";
            // 
            // lblPerdidas
            // 
            this.lblPerdidas.AutoSize = true;
            this.lblPerdidas.Location = new System.Drawing.Point(678, 83);
            this.lblPerdidas.Name = "lblPerdidas";
            this.lblPerdidas.Size = new System.Drawing.Size(89, 25);
            this.lblPerdidas.TabIndex = 2;
            this.lblPerdidas.Text = "Perdidas";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(51, 455);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(162, 25);
            this.lblIngresos.TabIndex = 3;
            this.lblIngresos.Text = "Total de ingresos";
            // 
            // txtTotaldeIngresos
            // 
            this.txtTotaldeIngresos.Location = new System.Drawing.Point(56, 494);
            this.txtTotaldeIngresos.Multiline = true;
            this.txtTotaldeIngresos.Name = "txtTotaldeIngresos";
            this.txtTotaldeIngresos.Size = new System.Drawing.Size(157, 57);
            this.txtTotaldeIngresos.TabIndex = 4;
            // 
            // lblTotaldeRentas
            // 
            this.lblTotaldeRentas.AutoSize = true;
            this.lblTotaldeRentas.Location = new System.Drawing.Point(51, 138);
            this.lblTotaldeRentas.Name = "lblTotaldeRentas";
            this.lblTotaldeRentas.Size = new System.Drawing.Size(142, 25);
            this.lblTotaldeRentas.TabIndex = 5;
            this.lblTotaldeRentas.Text = "Total de rentas";
            // 
            // txtTotaldeRentas
            // 
            this.txtTotaldeRentas.Location = new System.Drawing.Point(56, 175);
            this.txtTotaldeRentas.Multiline = true;
            this.txtTotaldeRentas.Name = "txtTotaldeRentas";
            this.txtTotaldeRentas.Size = new System.Drawing.Size(157, 48);
            this.txtTotaldeRentas.TabIndex = 6;
            // 
            // lblOtrosIngresos
            // 
            this.lblOtrosIngresos.AutoSize = true;
            this.lblOtrosIngresos.Location = new System.Drawing.Point(56, 243);
            this.lblOtrosIngresos.Name = "lblOtrosIngresos";
            this.lblOtrosIngresos.Size = new System.Drawing.Size(140, 25);
            this.lblOtrosIngresos.TabIndex = 7;
            this.lblOtrosIngresos.Text = "Otros Ingresos";
            // 
            // txtOtrosIngresos
            // 
            this.txtOtrosIngresos.Location = new System.Drawing.Point(58, 283);
            this.txtOtrosIngresos.Multiline = true;
            this.txtOtrosIngresos.Name = "txtOtrosIngresos";
            this.txtOtrosIngresos.Size = new System.Drawing.Size(153, 52);
            this.txtOtrosIngresos.TabIndex = 8;
            // 
            // lblGastosOperativos
            // 
            this.lblGastosOperativos.AutoSize = true;
            this.lblGastosOperativos.Location = new System.Drawing.Point(606, 138);
            this.lblGastosOperativos.Name = "lblGastosOperativos";
            this.lblGastosOperativos.Size = new System.Drawing.Size(174, 25);
            this.lblGastosOperativos.TabIndex = 9;
            this.lblGastosOperativos.Text = "Gastos Operativos";
            // 
            // txtGastosOperativos
            // 
            this.txtGastosOperativos.Location = new System.Drawing.Point(611, 175);
            this.txtGastosOperativos.Multiline = true;
            this.txtGastosOperativos.Name = "txtGastosOperativos";
            this.txtGastosOperativos.Size = new System.Drawing.Size(243, 48);
            this.txtGastosOperativos.TabIndex = 10;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Location = new System.Drawing.Point(606, 243);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(248, 25);
            this.lblMantenimiento.TabIndex = 11;
            this.lblMantenimiento.Text = "Mantenimiento de películas";
            this.lblMantenimiento.Click += new System.EventHandler(this.lblMantenimiento_Click);
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(611, 283);
            this.txtMantenimiento.Multiline = true;
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(243, 52);
            this.txtMantenimiento.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(60, 357);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 60);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular Ganancia";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCalcularPerdida
            // 
            this.btnCalcularPerdida.Location = new System.Drawing.Point(661, 357);
            this.btnCalcularPerdida.Name = "btnCalcularPerdida";
            this.btnCalcularPerdida.Size = new System.Drawing.Size(151, 60);
            this.btnCalcularPerdida.TabIndex = 14;
            this.btnCalcularPerdida.Text = "Calcular Perdida";
            this.btnCalcularPerdida.UseVisualStyleBackColor = true;
            this.btnCalcularPerdida.Click += new System.EventHandler(this.btnCalcularPerdida_Click);
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
            // txtTotaldePerdidas
            // 
            this.txtTotaldePerdidas.Location = new System.Drawing.Point(611, 494);
            this.txtTotaldePerdidas.Multiline = true;
            this.txtTotaldePerdidas.Name = "txtTotaldePerdidas";
            this.txtTotaldePerdidas.Size = new System.Drawing.Size(243, 57);
            this.txtTotaldePerdidas.TabIndex = 16;
            // 
            // lblPerdidasTotales
            // 
            this.lblPerdidasTotales.AutoSize = true;
            this.lblPerdidasTotales.Location = new System.Drawing.Point(606, 455);
            this.lblPerdidasTotales.Name = "lblPerdidasTotales";
            this.lblPerdidasTotales.Size = new System.Drawing.Size(163, 25);
            this.lblPerdidasTotales.TabIndex = 17;
            this.lblPerdidasTotales.Text = "Total de perdidas";
            this.lblPerdidasTotales.Click += new System.EventHandler(this.lblPerdidasTotales_Click);
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
            // frmGananciasYPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.lblPerdidasTotales);
            this.Controls.Add(this.txtTotaldePerdidas);
            this.Controls.Add(this.lblTotalPerdidas);
            this.Controls.Add(this.btnCalcularPerdida);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.lblMantenimiento);
            this.Controls.Add(this.txtGastosOperativos);
            this.Controls.Add(this.lblGastosOperativos);
            this.Controls.Add(this.txtOtrosIngresos);
            this.Controls.Add(this.lblOtrosIngresos);
            this.Controls.Add(this.txtTotaldeRentas);
            this.Controls.Add(this.lblTotaldeRentas);
            this.Controls.Add(this.txtTotaldeIngresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblPerdidas);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.lblGananciasPerdidas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGananciasYPerdidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGananciasYPerdidas";
            this.Load += new System.EventHandler(this.frmGananciasYPerdidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGananciasPerdidas;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.Label lblPerdidas;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.TextBox txtTotaldeIngresos;
        private System.Windows.Forms.Label lblTotaldeRentas;
        private System.Windows.Forms.TextBox txtTotaldeRentas;
        private System.Windows.Forms.Label lblOtrosIngresos;
        private System.Windows.Forms.TextBox txtOtrosIngresos;
        private System.Windows.Forms.Label lblGastosOperativos;
        private System.Windows.Forms.TextBox txtGastosOperativos;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCalcularPerdida;
        private System.Windows.Forms.Label lblTotalPerdidas;
        private System.Windows.Forms.TextBox txtTotaldePerdidas;
        private System.Windows.Forms.Label lblPerdidasTotales;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}