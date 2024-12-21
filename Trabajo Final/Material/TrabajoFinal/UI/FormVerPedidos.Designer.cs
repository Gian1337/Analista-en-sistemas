namespace UI
{
    partial class FormVerPedidos
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.labelClientePedido = new System.Windows.Forms.Label();
            this.labelFechaPedido = new System.Windows.Forms.Label();
            this.labelNumPedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos:";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(14, 92);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(307, 293);
            this.dataGridViewPedidos.TabIndex = 1;
            this.dataGridViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellContentClick);
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.labelClientePedido);
            this.groupBoxDetalles.Controls.Add(this.labelFechaPedido);
            this.groupBoxDetalles.Controls.Add(this.labelNumPedido);
            this.groupBoxDetalles.Controls.Add(this.label5);
            this.groupBoxDetalles.Controls.Add(this.dataGridViewProductos);
            this.groupBoxDetalles.Controls.Add(this.label4);
            this.groupBoxDetalles.Controls.Add(this.label3);
            this.groupBoxDetalles.Controls.Add(this.label2);
            this.groupBoxDetalles.Location = new System.Drawing.Point(328, 92);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Size = new System.Drawing.Size(361, 293);
            this.groupBoxDetalles.TabIndex = 2;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles del pedido";
            this.groupBoxDetalles.Visible = false;
            // 
            // labelClientePedido
            // 
            this.labelClientePedido.AutoSize = true;
            this.labelClientePedido.Location = new System.Drawing.Point(71, 65);
            this.labelClientePedido.Name = "labelClientePedido";
            this.labelClientePedido.Size = new System.Drawing.Size(35, 13);
            this.labelClientePedido.TabIndex = 7;
            this.labelClientePedido.Text = "label8";
            // 
            // labelFechaPedido
            // 
            this.labelFechaPedido.AutoSize = true;
            this.labelFechaPedido.Location = new System.Drawing.Point(246, 30);
            this.labelFechaPedido.Name = "labelFechaPedido";
            this.labelFechaPedido.Size = new System.Drawing.Size(35, 13);
            this.labelFechaPedido.TabIndex = 6;
            this.labelFechaPedido.Text = "label7";
            // 
            // labelNumPedido
            // 
            this.labelNumPedido.AutoSize = true;
            this.labelNumPedido.Location = new System.Drawing.Point(92, 29);
            this.labelNumPedido.Name = "labelNumPedido";
            this.labelNumPedido.Size = new System.Drawing.Size(35, 13);
            this.labelNumPedido.TabIndex = 5;
            this.labelNumPedido.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Productos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(9, 115);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(346, 172);
            this.dataGridViewProductos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedido N°:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-2, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(706, 61);
            this.label6.TabIndex = 11;
            this.label6.Text = "PEDIDOS REALIZADOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(699, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.label1);
            this.Name = "FormVerPedidos";
            this.Text = "Ver pedidos";
            this.Load += new System.EventHandler(this.FormVerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.groupBoxDetalles.ResumeLayout(false);
            this.groupBoxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.Label labelClientePedido;
        private System.Windows.Forms.Label labelFechaPedido;
        private System.Windows.Forms.Label labelNumPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}