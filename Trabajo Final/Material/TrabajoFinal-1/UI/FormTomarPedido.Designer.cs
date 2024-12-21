namespace UI
{
    partial class FormTomarPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxDetalleProd = new System.Windows.Forms.GroupBox();
            this.labelPrecioProd = new System.Windows.Forms.Label();
            this.labelCantProd = new System.Windows.Forms.Label();
            this.buttonAgregarProd = new System.Windows.Forms.Button();
            this.labelTipoProd = new System.Windows.Forms.Label();
            this.labelMatProd = new System.Windows.Forms.Label();
            this.labelDescProd = new System.Windows.Forms.Label();
            this.labelNomProd = new System.Windows.Forms.Label();
            this.labelProdCarrito = new System.Windows.Forms.Label();
            this.dataGridViewCarro = new System.Windows.Forms.DataGridView();
            this.buttonEliminarProd = new System.Windows.Forms.Button();
            this.labelImporte = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBoxDetalleProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de productos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(10, 105);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(401, 245);
            this.dataGridViewProductos.TabIndex = 1;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // groupBoxDetalleProd
            // 
            this.groupBoxDetalleProd.Controls.Add(this.labelPrecioProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelCantProd);
            this.groupBoxDetalleProd.Controls.Add(this.buttonAgregarProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelTipoProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelMatProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelDescProd);
            this.groupBoxDetalleProd.Controls.Add(this.labelNomProd);
            this.groupBoxDetalleProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalleProd.Location = new System.Drawing.Point(437, 95);
            this.groupBoxDetalleProd.Name = "groupBoxDetalleProd";
            this.groupBoxDetalleProd.Size = new System.Drawing.Size(398, 255);
            this.groupBoxDetalleProd.TabIndex = 2;
            this.groupBoxDetalleProd.TabStop = false;
            this.groupBoxDetalleProd.Text = "Detalles";
            this.groupBoxDetalleProd.Visible = false;
            // 
            // labelPrecioProd
            // 
            this.labelPrecioProd.AutoSize = true;
            this.labelPrecioProd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioProd.Location = new System.Drawing.Point(168, 159);
            this.labelPrecioProd.Name = "labelPrecioProd";
            this.labelPrecioProd.Size = new System.Drawing.Size(70, 18);
            this.labelPrecioProd.TabIndex = 6;
            this.labelPrecioProd.Text = "PRECIO";
            // 
            // labelCantProd
            // 
            this.labelCantProd.AutoSize = true;
            this.labelCantProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantProd.Location = new System.Drawing.Point(129, 217);
            this.labelCantProd.Name = "labelCantProd";
            this.labelCantProd.Size = new System.Drawing.Size(45, 16);
            this.labelCantProd.TabIndex = 5;
            this.labelCantProd.Text = "Stock";
            // 
            // buttonAgregarProd
            // 
            this.buttonAgregarProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProd.Location = new System.Drawing.Point(125, 180);
            this.buttonAgregarProd.Name = "buttonAgregarProd";
            this.buttonAgregarProd.Size = new System.Drawing.Size(162, 34);
            this.buttonAgregarProd.TabIndex = 4;
            this.buttonAgregarProd.Text = "Añadir articulo";
            this.buttonAgregarProd.UseVisualStyleBackColor = true;
            this.buttonAgregarProd.Click += new System.EventHandler(this.buttonAgregarProd_Click);
            // 
            // labelTipoProd
            // 
            this.labelTipoProd.AutoSize = true;
            this.labelTipoProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoProd.Location = new System.Drawing.Point(25, 123);
            this.labelTipoProd.Name = "labelTipoProd";
            this.labelTipoProd.Size = new System.Drawing.Size(35, 16);
            this.labelTipoProd.TabIndex = 3;
            this.labelTipoProd.Text = "Tipo";
            // 
            // labelMatProd
            // 
            this.labelMatProd.AutoSize = true;
            this.labelMatProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatProd.Location = new System.Drawing.Point(25, 91);
            this.labelMatProd.Name = "labelMatProd";
            this.labelMatProd.Size = new System.Drawing.Size(59, 16);
            this.labelMatProd.TabIndex = 2;
            this.labelMatProd.Text = "Material";
            // 
            // labelDescProd
            // 
            this.labelDescProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescProd.Location = new System.Drawing.Point(25, 53);
            this.labelDescProd.Name = "labelDescProd";
            this.labelDescProd.Size = new System.Drawing.Size(340, 38);
            this.labelDescProd.TabIndex = 1;
            this.labelDescProd.Text = "Descripcion producto";
            // 
            // labelNomProd
            // 
            this.labelNomProd.AutoSize = true;
            this.labelNomProd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomProd.Location = new System.Drawing.Point(6, 16);
            this.labelNomProd.Name = "labelNomProd";
            this.labelNomProd.Size = new System.Drawing.Size(176, 18);
            this.labelNomProd.TabIndex = 0;
            this.labelNomProd.Text = "NOMBRE PRODUCTO";
            // 
            // labelProdCarrito
            // 
            this.labelProdCarrito.AutoSize = true;
            this.labelProdCarrito.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdCarrito.Location = new System.Drawing.Point(859, 367);
            this.labelProdCarrito.Name = "labelProdCarrito";
            this.labelProdCarrito.Size = new System.Drawing.Size(101, 18);
            this.labelProdCarrito.TabIndex = 7;
            this.labelProdCarrito.Text = "Articulos: 0";
            // 
            // dataGridViewCarro
            // 
            this.dataGridViewCarro.AllowUserToAddRows = false;
            this.dataGridViewCarro.AllowUserToDeleteRows = false;
            this.dataGridViewCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarro.Location = new System.Drawing.Point(855, 105);
            this.dataGridViewCarro.Name = "dataGridViewCarro";
            this.dataGridViewCarro.ReadOnly = true;
            this.dataGridViewCarro.Size = new System.Drawing.Size(374, 245);
            this.dataGridViewCarro.TabIndex = 8;
            this.dataGridViewCarro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarro_CellContentClick);
            // 
            // buttonEliminarProd
            // 
            this.buttonEliminarProd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProd.Location = new System.Drawing.Point(1106, 353);
            this.buttonEliminarProd.Name = "buttonEliminarProd";
            this.buttonEliminarProd.Size = new System.Drawing.Size(123, 32);
            this.buttonEliminarProd.TabIndex = 7;
            this.buttonEliminarProd.Text = "Eliminar articulo";
            this.buttonEliminarProd.UseVisualStyleBackColor = true;
            this.buttonEliminarProd.Click += new System.EventHandler(this.buttonEliminarProd_Click);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.Location = new System.Drawing.Point(859, 405);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(88, 18);
            this.labelImporte.TabIndex = 7;
            this.labelImporte.Text = "Sub total:";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(1106, 459);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(123, 32);
            this.buttonContinuar.TabIndex = 9;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1244, 73);
            this.label2.TabIndex = 10;
            this.label2.Text = "REALIZAR PEDIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(858, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Carrito";
            // 
            // FormTomarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1241, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.buttonEliminarProd);
            this.Controls.Add(this.dataGridViewCarro);
            this.Controls.Add(this.labelProdCarrito);
            this.Controls.Add(this.groupBoxDetalleProd);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label1);
            this.Name = "FormTomarPedido";
            this.Text = "Realizar pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTomarPedido_FormClosing);
            this.Load += new System.EventHandler(this.FormTomarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBoxDetalleProd.ResumeLayout(false);
            this.groupBoxDetalleProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.GroupBox groupBoxDetalleProd;
        private System.Windows.Forms.Label labelPrecioProd;
        private System.Windows.Forms.Label labelCantProd;
        private System.Windows.Forms.Button buttonAgregarProd;
        private System.Windows.Forms.Label labelTipoProd;
        private System.Windows.Forms.Label labelMatProd;
        private System.Windows.Forms.Label labelDescProd;
        private System.Windows.Forms.Label labelNomProd;
        private System.Windows.Forms.Label labelProdCarrito;
        private System.Windows.Forms.DataGridView dataGridViewCarro;
        private System.Windows.Forms.Button buttonEliminarProd;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}