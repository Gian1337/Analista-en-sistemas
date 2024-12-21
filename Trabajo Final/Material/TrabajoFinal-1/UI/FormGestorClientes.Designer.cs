namespace UI
{
    partial class FormGestorClientes
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosC = new System.Windows.Forms.GroupBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxRS = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDirE = new System.Windows.Forms.TextBox();
            this.textBoxTdni = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxNdni = new System.Windows.Forms.TextBox();
            this.textBoxApel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBoxDatosC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(9, 103);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(338, 366);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // groupBoxDatosC
            // 
            this.groupBoxDatosC.Controls.Add(this.textBoxNom);
            this.groupBoxDatosC.Controls.Add(this.textBoxRS);
            this.groupBoxDatosC.Controls.Add(this.textBoxTel);
            this.groupBoxDatosC.Controls.Add(this.buttonModificar);
            this.groupBoxDatosC.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosC.Controls.Add(this.textBoxDirE);
            this.groupBoxDatosC.Controls.Add(this.textBoxTdni);
            this.groupBoxDatosC.Controls.Add(this.textBoxDir);
            this.groupBoxDatosC.Controls.Add(this.textBoxNdni);
            this.groupBoxDatosC.Controls.Add(this.textBoxApel);
            this.groupBoxDatosC.Controls.Add(this.label10);
            this.groupBoxDatosC.Controls.Add(this.label9);
            this.groupBoxDatosC.Controls.Add(this.label8);
            this.groupBoxDatosC.Controls.Add(this.label7);
            this.groupBoxDatosC.Controls.Add(this.label6);
            this.groupBoxDatosC.Controls.Add(this.label5);
            this.groupBoxDatosC.Controls.Add(this.label4);
            this.groupBoxDatosC.Controls.Add(this.label3);
            this.groupBoxDatosC.Controls.Add(this.label2);
            this.groupBoxDatosC.Location = new System.Drawing.Point(354, 98);
            this.groupBoxDatosC.Name = "groupBoxDatosC";
            this.groupBoxDatosC.Size = new System.Drawing.Size(404, 347);
            this.groupBoxDatosC.TabIndex = 1;
            this.groupBoxDatosC.TabStop = false;
            this.groupBoxDatosC.Text = "Datos del cliente:";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(9, 475);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(106, 23);
            this.buttonNuevo.TabIndex = 21;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(292, 309);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(106, 28);
            this.buttonModificar.TabIndex = 20;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(9, 44);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(172, 20);
            this.textBoxNom.TabIndex = 19;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(515, 451);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 27);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxRS
            // 
            this.textBoxRS.Location = new System.Drawing.Point(9, 317);
            this.textBoxRS.Name = "textBoxRS";
            this.textBoxRS.Size = new System.Drawing.Size(172, 20);
            this.textBoxRS.TabIndex = 17;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(9, 278);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(172, 20);
            this.textBoxTel.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(9, 239);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(172, 20);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxDirE
            // 
            this.textBoxDirE.Location = new System.Drawing.Point(9, 200);
            this.textBoxDirE.Name = "textBoxDirE";
            this.textBoxDirE.Size = new System.Drawing.Size(172, 20);
            this.textBoxDirE.TabIndex = 14;
            // 
            // textBoxTdni
            // 
            this.textBoxTdni.Location = new System.Drawing.Point(229, 122);
            this.textBoxTdni.Name = "textBoxTdni";
            this.textBoxTdni.Size = new System.Drawing.Size(172, 20);
            this.textBoxTdni.TabIndex = 13;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(9, 161);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(172, 20);
            this.textBoxDir.TabIndex = 12;
            // 
            // textBoxNdni
            // 
            this.textBoxNdni.Location = new System.Drawing.Point(9, 122);
            this.textBoxNdni.Name = "textBoxNdni";
            this.textBoxNdni.Size = new System.Drawing.Size(172, 20);
            this.textBoxNdni.TabIndex = 11;
            // 
            // textBoxApel
            // 
            this.textBoxApel.Location = new System.Drawing.Point(9, 83);
            this.textBoxApel.Name = "textBoxApel";
            this.textBoxApel.Size = new System.Drawing.Size(172, 20);
            this.textBoxApel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Razon social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Direccion de entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes registrados";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Enabled = false;
            this.buttonBorrar.Location = new System.Drawing.Point(241, 475);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(106, 23);
            this.buttonBorrar.TabIndex = 22;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-2, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(772, 73);
            this.label11.TabIndex = 23;
            this.label11.Text = "GESTIONAR CLIENTES";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGestorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(765, 515);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDatosC);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormGestorClientes";
            this.Text = "Gestor de clientes";
            this.Load += new System.EventHandler(this.FormGestorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBoxDatosC.ResumeLayout(false);
            this.groupBoxDatosC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox groupBoxDatosC;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxRS;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDirE;
        private System.Windows.Forms.TextBox textBoxTdni;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxNdni;
        private System.Windows.Forms.TextBox textBoxApel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label label11;
    }
}