namespace TP1___Refactor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.btnRemoveP = new System.Windows.Forms.Button();
            this.btnRemoveA = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(27, 28);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.RowTemplate.Height = 24;
            this.dgvP.Size = new System.Drawing.Size(503, 150);
            this.dgvP.TabIndex = 0;
            this.dgvP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_RowEnter);
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(679, 29);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 51;
            this.dgvA.RowTemplate.Height = 24;
            this.dgvA.Size = new System.Drawing.Size(503, 150);
            this.dgvA.TabIndex = 1;
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(27, 185);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(163, 44);
            this.btnAddP.TabIndex = 2;
            this.btnAddP.Text = "AGREGAR PERSONAS";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(679, 185);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(163, 44);
            this.btnAddA.TabIndex = 3;
            this.btnAddA.Text = "AGREGAR AUTOS";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // btnRemoveP
            // 
            this.btnRemoveP.Location = new System.Drawing.Point(27, 235);
            this.btnRemoveP.Name = "btnRemoveP";
            this.btnRemoveP.Size = new System.Drawing.Size(163, 44);
            this.btnRemoveP.TabIndex = 4;
            this.btnRemoveP.Text = "ELIMINAR PERSONAS";
            this.btnRemoveP.UseVisualStyleBackColor = true;
            this.btnRemoveP.Click += new System.EventHandler(this.btnRemoveP_Click);
            // 
            // btnRemoveA
            // 
            this.btnRemoveA.Location = new System.Drawing.Point(679, 235);
            this.btnRemoveA.Name = "btnRemoveA";
            this.btnRemoveA.Size = new System.Drawing.Size(163, 44);
            this.btnRemoveA.TabIndex = 5;
            this.btnRemoveA.Text = "ELIMINAR AUTOS";
            this.btnRemoveA.UseVisualStyleBackColor = true;
            this.btnRemoveA.Click += new System.EventHandler(this.btnRemoveA_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(410, 218);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTAL  - €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de Autos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnRemoveA);
            this.Controls.Add(this.btnRemoveP);
            this.Controls.Add(this.btnAddA);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.dgvP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.Button btnRemoveP;
        private System.Windows.Forms.Button btnRemoveA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

