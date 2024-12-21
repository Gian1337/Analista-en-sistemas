namespace UI
{
    partial class FormGenerarPedidoMaterial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarMat = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxMateriales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.dataGridViewMatSelec = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSelec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAgregarMat);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.comboBoxMateriales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los campos";
            // 
            // buttonAgregarMat
            // 
            this.buttonAgregarMat.Location = new System.Drawing.Point(364, 55);
            this.buttonAgregarMat.Name = "buttonAgregarMat";
            this.buttonAgregarMat.Size = new System.Drawing.Size(83, 23);
            this.buttonAgregarMat.TabIndex = 8;
            this.buttonAgregarMat.Text = "Agregar";
            this.buttonAgregarMat.UseVisualStyleBackColor = true;
            this.buttonAgregarMat.Click += new System.EventHandler(this.buttonAgregarMat_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(364, 17);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(83, 20);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // comboBoxMateriales
            // 
            this.comboBoxMateriales.DisplayMember = "Hola";
            this.comboBoxMateriales.FormattingEnabled = true;
            this.comboBoxMateriales.Location = new System.Drawing.Point(107, 17);
            this.comboBoxMateriales.Name = "comboBoxMateriales";
            this.comboBoxMateriales.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMateriales.TabIndex = 4;
            this.comboBoxMateriales.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateriales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidades:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material a solicitar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la fecha limite entrega:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(12, 232);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(161, 23);
            this.buttonGenerar.TabIndex = 6;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // dataGridViewMatSelec
            // 
            this.dataGridViewMatSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatSelec.Location = new System.Drawing.Point(471, 65);
            this.dataGridViewMatSelec.Name = "dataGridViewMatSelec";
            this.dataGridViewMatSelec.Size = new System.Drawing.Size(338, 161);
            this.dataGridViewMatSelec.TabIndex = 7;
            this.dataGridViewMatSelec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatSelec_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(709, 232);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-6, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(834, 60);
            this.label4.TabIndex = 11;
            this.label4.Text = "GENERAR PEDIDO DE MATERIAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGenerarPedidoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(822, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewMatSelec);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormGenerarPedidoMaterial";
            this.Text = "Generar pedido de material";
            this.Load += new System.EventHandler(this.FormGenerarPedidoMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatSelec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxMateriales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Button buttonAgregarMat;
        private System.Windows.Forms.DataGridView dataGridViewMatSelec;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label4;
    }
}