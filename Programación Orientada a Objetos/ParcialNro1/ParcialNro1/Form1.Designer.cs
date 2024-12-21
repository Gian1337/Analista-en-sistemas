namespace ParcialNro1
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
            this.dgvBen = new System.Windows.Forms.DataGridView();
            this.BENEFICIARIOS = new System.Windows.Forms.Label();
            this.btnAddBen = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dgvAdel = new System.Windows.Forms.DataGridView();
            this.ADELANTOS = new System.Windows.Forms.Label();
            this.btnAddAdel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dgvBenAdel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenAdel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBen
            // 
            this.dgvBen.AllowUserToAddRows = false;
            this.dgvBen.AllowUserToDeleteRows = false;
            this.dgvBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBen.Location = new System.Drawing.Point(32, 54);
            this.dgvBen.Name = "dgvBen";
            this.dgvBen.ReadOnly = true;
            this.dgvBen.RowHeadersWidth = 51;
            this.dgvBen.RowTemplate.Height = 24;
            this.dgvBen.Size = new System.Drawing.Size(409, 185);
            this.dgvBen.TabIndex = 0;
            // 
            // BENEFICIARIOS
            // 
            this.BENEFICIARIOS.AutoSize = true;
            this.BENEFICIARIOS.ForeColor = System.Drawing.Color.Red;
            this.BENEFICIARIOS.Location = new System.Drawing.Point(32, 32);
            this.BENEFICIARIOS.Name = "BENEFICIARIOS";
            this.BENEFICIARIOS.Size = new System.Drawing.Size(108, 16);
            this.BENEFICIARIOS.TabIndex = 1;
            this.BENEFICIARIOS.Text = "BENEFICIARIOS";
            // 
            // btnAddBen
            // 
            this.btnAddBen.Location = new System.Drawing.Point(32, 361);
            this.btnAddBen.Name = "btnAddBen";
            this.btnAddBen.Size = new System.Drawing.Size(126, 31);
            this.btnAddBen.TabIndex = 2;
            this.btnAddBen.Text = "Agregar";
            this.btnAddBen.UseVisualStyleBackColor = true;
            this.btnAddBen.Click += new System.EventHandler(this.btnAddBen_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Operario";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(187, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Administrativo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(358, 296);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ejecutivo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dgvAdel
            // 
            this.dgvAdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdel.Location = new System.Drawing.Point(594, 54);
            this.dgvAdel.Name = "dgvAdel";
            this.dgvAdel.RowHeadersWidth = 51;
            this.dgvAdel.RowTemplate.Height = 24;
            this.dgvAdel.Size = new System.Drawing.Size(409, 185);
            this.dgvAdel.TabIndex = 6;
            // 
            // ADELANTOS
            // 
            this.ADELANTOS.AutoSize = true;
            this.ADELANTOS.ForeColor = System.Drawing.Color.Red;
            this.ADELANTOS.Location = new System.Drawing.Point(591, 35);
            this.ADELANTOS.Name = "ADELANTOS";
            this.ADELANTOS.Size = new System.Drawing.Size(89, 16);
            this.ADELANTOS.TabIndex = 7;
            this.ADELANTOS.Text = "ADELANTOS";
            // 
            // btnAddAdel
            // 
            this.btnAddAdel.Location = new System.Drawing.Point(594, 266);
            this.btnAddAdel.Name = "btnAddAdel";
            this.btnAddAdel.Size = new System.Drawing.Size(126, 31);
            this.btnAddAdel.TabIndex = 8;
            this.btnAddAdel.Text = "Agregar";
            this.btnAddAdel.UseVisualStyleBackColor = true;
            this.btnAddAdel.Click += new System.EventHandler(this.btnAddAdel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(173, 361);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(126, 31);
            this.btnMod.TabIndex = 9;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnElim
            // 
            this.btnElim.Location = new System.Drawing.Point(315, 361);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(126, 31);
            this.btnElim.TabIndex = 10;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione un tipo de empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(726, 266);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(126, 31);
            this.btnAsignar.TabIndex = 12;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvBenAdel
            // 
            this.dgvBenAdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenAdel.Location = new System.Drawing.Point(35, 446);
            this.dgvBenAdel.Name = "dgvBenAdel";
            this.dgvBenAdel.RowHeadersWidth = 51;
            this.dgvBenAdel.RowTemplate.Height = 24;
            this.dgvBenAdel.Size = new System.Drawing.Size(409, 185);
            this.dgvBenAdel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 698);
            this.Controls.Add(this.dgvBenAdel);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAddAdel);
            this.Controls.Add(this.ADELANTOS);
            this.Controls.Add(this.dgvAdel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnAddBen);
            this.Controls.Add(this.BENEFICIARIOS);
            this.Controls.Add(this.dgvBen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenAdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBen;
        private System.Windows.Forms.Label BENEFICIARIOS;
        private System.Windows.Forms.Button btnAddBen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridView dgvAdel;
        private System.Windows.Forms.Label ADELANTOS;
        private System.Windows.Forms.Button btnAddAdel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvBenAdel;
    }
}

