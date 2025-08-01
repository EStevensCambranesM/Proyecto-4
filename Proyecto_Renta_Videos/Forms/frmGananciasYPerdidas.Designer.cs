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
            this.lblGanancias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(249, 37);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(131, 16);
            this.lblGanancias.TabIndex = 0;
            this.lblGanancias.Text = "Ganancias/Perdidas";
            // 
            // frmGananciasYPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGanancias);
            this.Name = "frmGananciasYPerdidas";
            this.Text = "frmGananciasYPerdidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGanancias;
    }
}