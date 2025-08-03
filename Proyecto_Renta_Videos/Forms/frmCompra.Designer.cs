namespace Proyecto_Renta_Videos.Forms
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.txtCompra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtListaCompra = new System.Windows.Forms.Label();
            this.txtCompras = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsRegreso = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompra
            // 
            this.txtCompra.AutoSize = true;
            this.txtCompra.Location = new System.Drawing.Point(138, 92);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(61, 16);
            this.txtCompra.TabIndex = 0;
            this.txtCompra.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 30);
            this.textBox1.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(138, 177);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(46, 16);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Text = "Precio";
            // 
            // txtfecha
            // 
            this.txtfecha.AutoSize = true;
            this.txtfecha.Location = new System.Drawing.Point(138, 267);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(45, 16);
            this.txtfecha.TabIndex = 3;
            this.txtfecha.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(415, 344);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtListaCompra
            // 
            this.txtListaCompra.AutoSize = true;
            this.txtListaCompra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaCompra.Location = new System.Drawing.Point(705, 92);
            this.txtListaCompra.Name = "txtListaCompra";
            this.txtListaCompra.Size = new System.Drawing.Size(172, 27);
            this.txtListaCompra.TabIndex = 5;
            this.txtListaCompra.Text = "Lista de compra";
            // 
            // txtCompras
            // 
            this.txtCompras.AutoSize = true;
            this.txtCompras.BackColor = System.Drawing.Color.Azure;
            this.txtCompras.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompras.Location = new System.Drawing.Point(358, 30);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(289, 37);
            this.txtCompras.TabIndex = 6;
            this.txtCompras.Text = "Datos de la compra";
            this.txtCompras.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(132, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 30);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(132, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 30);
            this.textBox3.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsRegreso});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsRegreso
            // 
            this.tlsRegreso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsRegreso.Image = ((System.Drawing.Image)(resources.GetObject("tlsRegreso.Image")));
            this.tlsRegreso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsRegreso.Name = "tlsRegreso";
            this.tlsRegreso.Size = new System.Drawing.Size(124, 24);
            this.tlsRegreso.Text = "Regreso al menú";
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1012, 524);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.txtListaCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCompra);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtfecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtListaCompra;
        private System.Windows.Forms.Label txtCompras;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsRegreso;
    }
}