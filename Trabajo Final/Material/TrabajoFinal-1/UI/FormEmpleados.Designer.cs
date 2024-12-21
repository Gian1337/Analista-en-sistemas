namespace UI
{
    partial class FormEmpleados
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.listBoxOrdenesEmp = new System.Windows.Forms.ListBox();
            this.labelCantTrabajos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados del sector de producción disponibles";
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(25, 97);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(306, 316);
            this.dataGridViewEmpleados.TabIndex = 1;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonAsignar.Enabled = false;
            this.buttonAsignar.Location = new System.Drawing.Point(523, 387);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(155, 26);
            this.buttonAsignar.TabIndex = 2;
            this.buttonAsignar.Text = "Asignar orden";
            this.buttonAsignar.UseVisualStyleBackColor = true;
            this.buttonAsignar.Click += new System.EventHandler(this.buttonAsignar_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.listBoxOrdenesEmp);
            this.groupBoxInfo.Controls.Add(this.labelCantTrabajos);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Location = new System.Drawing.Point(346, 97);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(477, 284);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Información del empleado";
            this.groupBoxInfo.Visible = false;
            // 
            // listBoxOrdenesEmp
            // 
            this.listBoxOrdenesEmp.FormattingEnabled = true;
            this.listBoxOrdenesEmp.Location = new System.Drawing.Point(9, 57);
            this.listBoxOrdenesEmp.Name = "listBoxOrdenesEmp";
            this.listBoxOrdenesEmp.Size = new System.Drawing.Size(462, 199);
            this.listBoxOrdenesEmp.TabIndex = 2;
            // 
            // labelCantTrabajos
            // 
            this.labelCantTrabajos.AutoSize = true;
            this.labelCantTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantTrabajos.Location = new System.Drawing.Point(149, 28);
            this.labelCantTrabajos.Name = "labelCantTrabajos";
            this.labelCantTrabajos.Size = new System.Drawing.Size(14, 15);
            this.labelCantTrabajos.TabIndex = 1;
            this.labelCantTrabajos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trabajos asignados:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(849, 73);
            this.label3.TabIndex = 11;
            this.label3.Text = "EMPLEADOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(844, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonAsignar);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Button buttonAsignar;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelCantTrabajos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxOrdenesEmp;
        private System.Windows.Forms.Label label3;
    }
}