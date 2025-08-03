namespace Proyecto_Renta_Videos.Forms
{
    partial class frmMenuPrincipal
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
            this.msNavegacion = new System.Windows.Forms.MenuStrip();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarRentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuariooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasYPerdidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienvenidaUsuario = new System.Windows.Forms.Label();
            this.msNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacion
            // 
            this.msNavegacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msNavegacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.msNavegacion.Location = new System.Drawing.Point(0, 0);
            this.msNavegacion.Name = "msNavegacion";
            this.msNavegacion.Size = new System.Drawing.Size(900, 29);
            this.msNavegacion.TabIndex = 0;
            this.msNavegacion.Text = "menuStrip1";
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarRentaToolStripMenuItem,
            this.devoluciónToolStripMenuItem,
            this.moraToolStripMenuItem});
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.rentasToolStripMenuItem.Text = "Rentas";
            // 
            // registrarRentaToolStripMenuItem
            // 
            this.registrarRentaToolStripMenuItem.Name = "registrarRentaToolStripMenuItem";
            this.registrarRentaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.registrarRentaToolStripMenuItem.Text = "Registrar Renta";
            this.registrarRentaToolStripMenuItem.Click += new System.EventHandler(this.registrarRentaToolStripMenuItem_Click_1);
            // 
            // devoluciónToolStripMenuItem
            // 
            this.devoluciónToolStripMenuItem.Name = "devoluciónToolStripMenuItem";
            this.devoluciónToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.devoluciónToolStripMenuItem.Text = "Devolución";
            this.devoluciónToolStripMenuItem.Click += new System.EventHandler(this.devoluciónToolStripMenuItem_Click_1);
            // 
            // moraToolStripMenuItem
            // 
            this.moraToolStripMenuItem.Name = "moraToolStripMenuItem";
            this.moraToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.moraToolStripMenuItem.Text = "Mora";
            this.moraToolStripMenuItem.Click += new System.EventHandler(this.moraToolStripMenuItem_Click_1);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroVideosToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem,
            this.membresíasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // registroVideosToolStripMenuItem
            // 
            this.registroVideosToolStripMenuItem.Name = "registroVideosToolStripMenuItem";
            this.registroVideosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.registroVideosToolStripMenuItem.Text = "Registro Videos";
            this.registroVideosToolStripMenuItem.Click += new System.EventHandler(this.registroVideosToolStripMenuItem_Click);
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // membresíasToolStripMenuItem
            // 
            this.membresíasToolStripMenuItem.Name = "membresíasToolStripMenuItem";
            this.membresíasToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.membresíasToolStripMenuItem.Text = "Membresías";
            this.membresíasToolStripMenuItem.Click += new System.EventHandler(this.membresíasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuariooToolStripMenuItem,
            this.verUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuariooToolStripMenuItem
            // 
            this.nuevoUsuariooToolStripMenuItem.Name = "nuevoUsuariooToolStripMenuItem";
            this.nuevoUsuariooToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nuevoUsuariooToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuariooToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuariooToolStripMenuItem_Click);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.listaProveedoresToolStripMenuItem,
            this.comprarProductoToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // listaProveedoresToolStripMenuItem
            // 
            this.listaProveedoresToolStripMenuItem.Name = "listaProveedoresToolStripMenuItem";
            this.listaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.listaProveedoresToolStripMenuItem.Text = "Lista Proveedores";
            // 
            // comprarProductoToolStripMenuItem
            // 
            this.comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            this.comprarProductoToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.comprarProductoToolStripMenuItem.Text = "Comprar Producto";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasPorClienteToolStripMenuItem,
            this.inventarioDisponibleToolStripMenuItem,
            this.gananciasYPerdidasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // rentasPorClienteToolStripMenuItem
            // 
            this.rentasPorClienteToolStripMenuItem.Name = "rentasPorClienteToolStripMenuItem";
            this.rentasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.rentasPorClienteToolStripMenuItem.Text = "Rentas por Cliente";
            this.rentasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.rentasPorClienteToolStripMenuItem_Click);
            // 
            // inventarioDisponibleToolStripMenuItem
            // 
            this.inventarioDisponibleToolStripMenuItem.Name = "inventarioDisponibleToolStripMenuItem";
            this.inventarioDisponibleToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.inventarioDisponibleToolStripMenuItem.Text = "Inventario Disponible";
            this.inventarioDisponibleToolStripMenuItem.Click += new System.EventHandler(this.inventarioDisponibleToolStripMenuItem_Click);
            // 
            // gananciasYPerdidasToolStripMenuItem
            // 
            this.gananciasYPerdidasToolStripMenuItem.Name = "gananciasYPerdidasToolStripMenuItem";
            this.gananciasYPerdidasToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.gananciasYPerdidasToolStripMenuItem.Text = "Ganancias y Perdidas";
            this.gananciasYPerdidasToolStripMenuItem.Click += new System.EventHandler(this.gananciasYPerdidasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido!";
            // 
            // lblBienvenidaUsuario
            // 
            this.lblBienvenidaUsuario.AutoSize = true;
            this.lblBienvenidaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaUsuario.Location = new System.Drawing.Point(369, 176);
            this.lblBienvenidaUsuario.Name = "lblBienvenidaUsuario";
            this.lblBienvenidaUsuario.Size = new System.Drawing.Size(0, 31);
            this.lblBienvenidaUsuario.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lblBienvenidaUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msNavegacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msNavegacion;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.msNavegacion.ResumeLayout(false);
            this.msNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacion;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarRentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuariooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasYPerdidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBienvenidaUsuario;
    }
}