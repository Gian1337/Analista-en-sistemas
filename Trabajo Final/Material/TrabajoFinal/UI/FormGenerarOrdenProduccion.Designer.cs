namespace UI
{
    partial class FormGenerarOrdenProduccion
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
            this.buttonGenerarOrden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTareas = new System.Windows.Forms.TextBox();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos sin stock";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(18, 101);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(357, 289);
            this.dataGridViewProductos.TabIndex = 1;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // buttonGenerarOrden
            // 
            this.buttonGenerarOrden.Enabled = false;
            this.buttonGenerarOrden.Location = new System.Drawing.Point(113, 395);
            this.buttonGenerarOrden.Name = "buttonGenerarOrden";
            this.buttonGenerarOrden.Size = new System.Drawing.Size(166, 23);
            this.buttonGenerarOrden.TabIndex = 2;
            this.buttonGenerarOrden.Text = "Generar orden de producción";
            this.buttonGenerarOrden.UseVisualStyleBackColor = true;
            this.buttonGenerarOrden.Click += new System.EventHandler(this.buttonGenerarOrden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese las tareas a realizar en la orden seleccionada";
            // 
            // textBoxTareas
            // 
            this.textBoxTareas.Location = new System.Drawing.Point(15, 33);
            this.textBoxTareas.Multiline = true;
            this.textBoxTareas.Name = "textBoxTareas";
            this.textBoxTareas.Size = new System.Drawing.Size(314, 124);
            this.textBoxTareas.TabIndex = 4;
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.Location = new System.Drawing.Point(15, 210);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(314, 95);
            this.listBoxTareas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tareas asignadas";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(254, 163);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTareas);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTareas);
            this.groupBox1.Location = new System.Drawing.Point(381, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 317);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-4, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(746, 73);
            this.label4.TabIndex = 11;
            this.label4.Text = "GENERAR ORDEN DE PRODUCCIÓN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGenerarOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(739, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGenerarOrden);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label1);
            this.Name = "FormGenerarOrdenProduccion";
            this.Text = "Generar orden de produccion";
            this.Load += new System.EventHandler(this.FormGenerarOrdenProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button buttonGenerarOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTareas;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}