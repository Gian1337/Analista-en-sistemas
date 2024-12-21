namespace UI
{
    partial class FormCumplirOrdenProduccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCumplirOrden = new System.Windows.Forms.Button();
            this.buttonFinalizarT = new System.Windows.Forms.Button();
            this.labelTarea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tus ordenes de produccion";
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.AllowUserToAddRows = false;
            this.dataGridViewOrdenes.AllowUserToDeleteRows = false;
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(10, 132);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.ReadOnly = true;
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(273, 246);
            this.dataGridViewOrdenes.TabIndex = 1;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciona una orden para ver sus detalles y completarla";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelProducto);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.buttonCumplirOrden);
            this.groupBoxDatos.Controls.Add(this.buttonFinalizarT);
            this.groupBoxDatos.Controls.Add(this.labelTarea);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.labelFecha);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(289, 132);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(467, 246);
            this.groupBoxDatos.TabIndex = 3;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Detalles de la orden";
            this.groupBoxDatos.Visible = false;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(256, 28);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(56, 15);
            this.labelProducto.TabIndex = 11;
            this.labelProducto.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Producto:";
            // 
            // buttonCumplirOrden
            // 
            this.buttonCumplirOrden.Enabled = false;
            this.buttonCumplirOrden.Location = new System.Drawing.Point(183, 195);
            this.buttonCumplirOrden.Name = "buttonCumplirOrden";
            this.buttonCumplirOrden.Size = new System.Drawing.Size(104, 34);
            this.buttonCumplirOrden.TabIndex = 9;
            this.buttonCumplirOrden.Text = "Cumplir orden";
            this.buttonCumplirOrden.UseVisualStyleBackColor = true;
            this.buttonCumplirOrden.Click += new System.EventHandler(this.buttonCumplirOrden_Click);
            // 
            // buttonFinalizarT
            // 
            this.buttonFinalizarT.Location = new System.Drawing.Point(9, 138);
            this.buttonFinalizarT.Name = "buttonFinalizarT";
            this.buttonFinalizarT.Size = new System.Drawing.Size(98, 23);
            this.buttonFinalizarT.TabIndex = 8;
            this.buttonFinalizarT.Text = "Finalizar tarea";
            this.buttonFinalizarT.UseVisualStyleBackColor = true;
            this.buttonFinalizarT.Click += new System.EventHandler(this.buttonFinalizarT_Click);
            // 
            // labelTarea
            // 
            this.labelTarea.Location = new System.Drawing.Point(6, 89);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(423, 46);
            this.labelTarea.TabIndex = 7;
            this.labelTarea.Text = "Tarea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarea:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(83, 28);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(55, 15);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "00/00/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha limite:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(776, 73);
            this.label6.TabIndex = 11;
            this.label6.Text = "CUMPLIR ORDEN DE PRODUCCIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCumplirOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(768, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Controls.Add(this.label1);
            this.Name = "FormCumplirOrdenProduccion";
            this.Text = "Cumplir orden de producción";
            this.Load += new System.EventHandler(this.FormCumplirOrdenProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCumplirOrden;
        private System.Windows.Forms.Button buttonFinalizarT;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}