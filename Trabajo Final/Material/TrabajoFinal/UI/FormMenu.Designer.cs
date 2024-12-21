namespace UI
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVendedor = new System.Windows.Forms.ToolStripDropDownButton();
            this.verPedidosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tomarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProduccion = new System.Windows.Forms.ToolStripDropDownButton();
            this.controlarOrdenesDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumplirOrdenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDespachos = new System.Windows.Forms.ToolStripDropDownButton();
            this.cumplirOrdenDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestorDePermisosDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripArchivo,
            this.toolStripVendedor,
            this.toolStripProduccion,
            this.toolStripDespachos,
            this.toolStripSplitButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(678, 44);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripArchivo
            // 
            this.toolStripArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripArchivo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripArchivo.Image")));
            this.toolStripArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripArchivo.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripArchivo.Name = "toolStripArchivo";
            this.toolStripArchivo.Size = new System.Drawing.Size(61, 24);
            this.toolStripArchivo.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripVendedor
            // 
            this.toolStripVendedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomarPedidoToolStripMenuItem,
            this.generarFacturaToolStripMenuItem,
            this.verPedidosRealizadosToolStripMenuItem,
            this.generarOrdenDeEntregaToolStripMenuItem,
            this.informaciónDeNegocioToolStripMenuItem,
            this.gestionarClientesToolStripMenuItem});
            this.toolStripVendedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripVendedor.Image")));
            this.toolStripVendedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVendedor.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripVendedor.Name = "toolStripVendedor";
            this.toolStripVendedor.Size = new System.Drawing.Size(74, 24);
            this.toolStripVendedor.Text = "Ventas";
            // 
            // verPedidosRealizadosToolStripMenuItem
            // 
            this.verPedidosRealizadosToolStripMenuItem.Name = "verPedidosRealizadosToolStripMenuItem";
            this.verPedidosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.verPedidosRealizadosToolStripMenuItem.Text = "Ver pedidos realizados";
            this.verPedidosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosRealizadosToolStripMenuItem_Click);
            // 
            // tomarPedidoToolStripMenuItem
            // 
            this.tomarPedidoToolStripMenuItem.Name = "tomarPedidoToolStripMenuItem";
            this.tomarPedidoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tomarPedidoToolStripMenuItem.Text = "Tomar pedido";
            this.tomarPedidoToolStripMenuItem.Click += new System.EventHandler(this.tomarPedidoToolStripMenuItem_Click);
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generarFacturaToolStripMenuItem.Text = "Generar factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // generarOrdenDeEntregaToolStripMenuItem
            // 
            this.generarOrdenDeEntregaToolStripMenuItem.Name = "generarOrdenDeEntregaToolStripMenuItem";
            this.generarOrdenDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generarOrdenDeEntregaToolStripMenuItem.Text = "Generar orden de entrega";
            this.generarOrdenDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeEntregaToolStripMenuItem_Click);
            // 
            // informaciónDeNegocioToolStripMenuItem
            // 
            this.informaciónDeNegocioToolStripMenuItem.Name = "informaciónDeNegocioToolStripMenuItem";
            this.informaciónDeNegocioToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.informaciónDeNegocioToolStripMenuItem.Text = "Ver información de negocio";
            this.informaciónDeNegocioToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeNegocioToolStripMenuItem_Click);
            // 
            // toolStripProduccion
            // 
            this.toolStripProduccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlarOrdenesDeProduccionToolStripMenuItem,
            this.cumplirOrdenDeProduccionToolStripMenuItem,
            this.generarOrdenDeProduccionToolStripMenuItem,
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem,
            this.visualizarStockToolStripMenuItem});
            this.toolStripProduccion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripProduccion.Image")));
            this.toolStripProduccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripProduccion.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripProduccion.Name = "toolStripProduccion";
            this.toolStripProduccion.Size = new System.Drawing.Size(101, 24);
            this.toolStripProduccion.Text = "Produccion";
            // 
            // controlarOrdenesDeProduccionToolStripMenuItem
            // 
            this.controlarOrdenesDeProduccionToolStripMenuItem.Name = "controlarOrdenesDeProduccionToolStripMenuItem";
            this.controlarOrdenesDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.controlarOrdenesDeProduccionToolStripMenuItem.Text = "Controlar ordenes de produccion";
            this.controlarOrdenesDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.controlarOrdenesDeProduccionToolStripMenuItem_Click);
            // 
            // cumplirOrdenDeProduccionToolStripMenuItem
            // 
            this.cumplirOrdenDeProduccionToolStripMenuItem.Name = "cumplirOrdenDeProduccionToolStripMenuItem";
            this.cumplirOrdenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cumplirOrdenDeProduccionToolStripMenuItem.Text = "Cumplir orden de produccion";
            this.cumplirOrdenDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.cumplirOrdenDeProduccionToolStripMenuItem_Click);
            // 
            // generarOrdenDeProduccionToolStripMenuItem
            // 
            this.generarOrdenDeProduccionToolStripMenuItem.Name = "generarOrdenDeProduccionToolStripMenuItem";
            this.generarOrdenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.generarOrdenDeProduccionToolStripMenuItem.Text = "Generar orden de produccion";
            this.generarOrdenDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeProduccionToolStripMenuItem_Click);
            // 
            // finalizarOrdenDePedidoDeMaterialToolStripMenuItem
            // 
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem.Name = "finalizarOrdenDePedidoDeMaterialToolStripMenuItem";
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem.Text = "Finalizar pedido de material";
            this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem.Click += new System.EventHandler(this.finalizarOrdenDePedidoDeMaterialToolStripMenuItem_Click);
            // 
            // visualizarStockToolStripMenuItem
            // 
            this.visualizarStockToolStripMenuItem.Name = "visualizarStockToolStripMenuItem";
            this.visualizarStockToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.visualizarStockToolStripMenuItem.Text = "Visualizar stock";
            this.visualizarStockToolStripMenuItem.Click += new System.EventHandler(this.visualizarStockToolStripMenuItem_Click);
            // 
            // toolStripDespachos
            // 
            this.toolStripDespachos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cumplirOrdenDeEntregaToolStripMenuItem});
            this.toolStripDespachos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDespachos.Image")));
            this.toolStripDespachos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDespachos.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripDespachos.Name = "toolStripDespachos";
            this.toolStripDespachos.Size = new System.Drawing.Size(97, 24);
            this.toolStripDespachos.Text = "Despachos";
            // 
            // cumplirOrdenDeEntregaToolStripMenuItem
            // 
            this.cumplirOrdenDeEntregaToolStripMenuItem.Name = "cumplirOrdenDeEntregaToolStripMenuItem";
            this.cumplirOrdenDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cumplirOrdenDeEntregaToolStripMenuItem.Text = "Cumplir orden de entrega";
            this.cumplirOrdenDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.cumplirOrdenDeEntregaToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorDePermisosDeUsuarioToolStripMenuItem,
            this.gestorDeUsuariosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(111, 24);
            this.toolStripSplitButton1.Text = "Admistracion";
            // 
            // gestorDePermisosDeUsuarioToolStripMenuItem
            // 
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Name = "gestorDePermisosDeUsuarioToolStripMenuItem";
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Text = "Gestor de permisos de usuario";
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestorDePermisosDeUsuarioToolStripMenuItem_Click);
            // 
            // gestorDeUsuariosToolStripMenuItem
            // 
            this.gestorDeUsuariosToolStripMenuItem.Name = "gestorDeUsuariosToolStripMenuItem";
            this.gestorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gestorDeUsuariosToolStripMenuItem.Text = "Gestor de usuarios";
            this.gestorDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestorDeUsuariosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 408);
            this.Controls.Add(this.toolStripMenu);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormPruebas_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripVendedor;
        private System.Windows.Forms.ToolStripMenuItem tomarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripProduccion;
        private System.Windows.Forms.ToolStripDropDownButton toolStripArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDespachos;
        private System.Windows.Forms.ToolStripMenuItem controlarOrdenesDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumplirOrdenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumplirOrdenDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem gestorDePermisosDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarOrdenDePedidoDeMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
    }
}