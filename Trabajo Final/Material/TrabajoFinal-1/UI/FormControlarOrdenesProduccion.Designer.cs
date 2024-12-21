namespace UI
{
    partial class FormControlarOrdenesProduccion
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
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionarOrden = new System.Windows.Forms.Button();
            this.groupBoxDetallesOrden = new System.Windows.Forms.GroupBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelMat = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.groupBoxDetallesOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes de producción sin asignar";
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(11, 100);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(423, 296);
            this.dataGridViewOrdenes.TabIndex = 1;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // buttonSeleccionarOrden
            // 
            this.buttonSeleccionarOrden.Enabled = false;
            this.buttonSeleccionarOrden.Location = new System.Drawing.Point(557, 334);
            this.buttonSeleccionarOrden.Name = "buttonSeleccionarOrden";
            this.buttonSeleccionarOrden.Size = new System.Drawing.Size(126, 40);
            this.buttonSeleccionarOrden.TabIndex = 2;
            this.buttonSeleccionarOrden.Text = "Seleccionar orden";
            this.buttonSeleccionarOrden.UseVisualStyleBackColor = true;
            this.buttonSeleccionarOrden.Click += new System.EventHandler(this.buttonSeleccionarOrden_Click);
            // 
            // groupBoxDetallesOrden
            // 
            this.groupBoxDetallesOrden.Controls.Add(this.labelCant);
            this.groupBoxDetallesOrden.Controls.Add(this.labelMat);
            this.groupBoxDetallesOrden.Controls.Add(this.labelProd);
            this.groupBoxDetallesOrden.Controls.Add(this.labelFecha);
            this.groupBoxDetallesOrden.Controls.Add(this.label5);
            this.groupBoxDetallesOrden.Controls.Add(this.label4);
            this.groupBoxDetallesOrden.Controls.Add(this.label3);
            this.groupBoxDetallesOrden.Controls.Add(this.label2);
            this.groupBoxDetallesOrden.Location = new System.Drawing.Point(441, 100);
            this.groupBoxDetallesOrden.Name = "groupBoxDetallesOrden";
            this.groupBoxDetallesOrden.Size = new System.Drawing.Size(342, 214);
            this.groupBoxDetallesOrden.TabIndex = 3;
            this.groupBoxDetallesOrden.TabStop = false;
            this.groupBoxDetallesOrden.Text = "Detalles";
            this.groupBoxDetallesOrden.Visible = false;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(16, 172);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(48, 16);
            this.labelCant.TabIndex = 7;
            this.labelCant.Text = "Fecha:";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMat.Location = new System.Drawing.Point(16, 130);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(48, 16);
            this.labelMat.TabIndex = 6;
            this.labelMat.Text = "Fecha:";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(12, 85);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(48, 16);
            this.labelProd.TabIndex = 5;
            this.labelProd.Text = "Fecha:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 42);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(48, 16);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unidades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Producto a fabricar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-3, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(806, 73);
            this.label6.TabIndex = 11;
            this.label6.Text = "CONTROLAR ORDENES DE PRODUCCIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormControlarOrdenesProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDetallesOrden);
            this.Controls.Add(this.buttonSeleccionarOrden);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Controls.Add(this.label1);
            this.Name = "FormControlarOrdenesProduccion";
            this.Text = "Controlar ordenes de producción";
            this.Load += new System.EventHandler(this.FormControlarOrdenesProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.groupBoxDetallesOrden.ResumeLayout(false);
            this.groupBoxDetallesOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Button buttonSeleccionarOrden;
        private System.Windows.Forms.GroupBox groupBoxDetallesOrden;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}