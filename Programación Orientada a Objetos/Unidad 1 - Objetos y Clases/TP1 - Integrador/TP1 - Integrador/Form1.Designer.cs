namespace TP1___Integrador
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
            this.grillaPersona = new System.Windows.Forms.DataGridView();
            this.Personas = new System.Windows.Forms.Label();
            this.btnAgregarPersonas = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.Label();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaAutos = new System.Windows.Forms.DataGridView();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnBorrarAuto = new System.Windows.Forms.Button();
            this.grillaAutosxPers = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnModificarPers = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutosxPers)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPersona
            // 
            this.grillaPersona.AllowUserToAddRows = false;
            this.grillaPersona.AllowUserToDeleteRows = false;
            this.grillaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPersona.Location = new System.Drawing.Point(34, 36);
            this.grillaPersona.Name = "grillaPersona";
            this.grillaPersona.ReadOnly = true;
            this.grillaPersona.RowHeadersWidth = 51;
            this.grillaPersona.RowTemplate.Height = 24;
            this.grillaPersona.Size = new System.Drawing.Size(240, 150);
            this.grillaPersona.TabIndex = 0;
            // 
            // Personas
            // 
            this.Personas.AutoSize = true;
            this.Personas.Location = new System.Drawing.Point(112, 17);
            this.Personas.Name = "Personas";
            this.Personas.Size = new System.Drawing.Size(65, 16);
            this.Personas.TabIndex = 1;
            this.Personas.Text = "Personas";
            // 
            // btnAgregarPersonas
            // 
            this.btnAgregarPersonas.Location = new System.Drawing.Point(78, 366);
            this.btnAgregarPersonas.Name = "btnAgregarPersonas";
            this.btnAgregarPersonas.Size = new System.Drawing.Size(152, 30);
            this.btnAgregarPersonas.TabIndex = 2;
            this.btnAgregarPersonas.Text = "Agregar Persona";
            this.btnAgregarPersonas.UseVisualStyleBackColor = true;
            this.btnAgregarPersonas.Click += new System.EventHandler(this.btnAgregarPersonas_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(141, 212);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(133, 22);
            this.txtNom.TabIndex = 3;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(141, 268);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(133, 22);
            this.txtdoc.TabIndex = 4;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(141, 240);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(133, 22);
            this.txtAp.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(42, 215);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(56, 16);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(42, 240);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(57, 16);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Location = new System.Drawing.Point(42, 268);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(30, 16);
            this.txtDni.TabIndex = 8;
            this.txtDni.Text = "DNI";
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(78, 408);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(152, 30);
            this.btnEliminarPersona.TabIndex = 9;
            this.btnEliminarPersona.Text = "Borrar Persona";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            this.btnEliminarPersona.Click += new System.EventHandler(this.btnEliminarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Autos";
            // 
            // grillaAutos
            // 
            this.grillaAutos.AllowUserToAddRows = false;
            this.grillaAutos.AllowUserToDeleteRows = false;
            this.grillaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAutos.Location = new System.Drawing.Point(310, 36);
            this.grillaAutos.Name = "grillaAutos";
            this.grillaAutos.ReadOnly = true;
            this.grillaAutos.RowHeadersWidth = 51;
            this.grillaAutos.RowTemplate.Height = 24;
            this.grillaAutos.Size = new System.Drawing.Size(240, 150);
            this.grillaAutos.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(417, 240);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(133, 22);
            this.txtMarca.TabIndex = 14;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(417, 268);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(133, 22);
            this.txtModelo.TabIndex = 13;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(417, 212);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(133, 22);
            this.txtPatente.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(417, 327);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(133, 22);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(417, 299);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(133, 22);
            this.txtAño.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Patente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(361, 366);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(152, 30);
            this.btnAgregarAuto.TabIndex = 23;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnBorrarAuto
            // 
            this.btnBorrarAuto.Location = new System.Drawing.Point(361, 408);
            this.btnBorrarAuto.Name = "btnBorrarAuto";
            this.btnBorrarAuto.Size = new System.Drawing.Size(152, 30);
            this.btnBorrarAuto.TabIndex = 24;
            this.btnBorrarAuto.Text = "Borrar Auto";
            this.btnBorrarAuto.UseVisualStyleBackColor = true;
            this.btnBorrarAuto.Click += new System.EventHandler(this.btnBorrarAuto_Click);
            // 
            // grillaAutosxPers
            // 
            this.grillaAutosxPers.AllowUserToAddRows = false;
            this.grillaAutosxPers.AllowUserToDeleteRows = false;
            this.grillaAutosxPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAutosxPers.Location = new System.Drawing.Point(605, 36);
            this.grillaAutosxPers.Name = "grillaAutosxPers";
            this.grillaAutosxPers.ReadOnly = true;
            this.grillaAutosxPers.RowHeadersWidth = 51;
            this.grillaAutosxPers.RowTemplate.Height = 24;
            this.grillaAutosxPers.Size = new System.Drawing.Size(514, 150);
            this.grillaAutosxPers.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(808, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Autos de la Personas";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(879, 204);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(240, 30);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "Consultar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnModificarPers
            // 
            this.btnModificarPers.Location = new System.Drawing.Point(78, 453);
            this.btnModificarPers.Name = "btnModificarPers";
            this.btnModificarPers.Size = new System.Drawing.Size(152, 30);
            this.btnModificarPers.TabIndex = 28;
            this.btnModificarPers.Text = "Modificar Persona";
            this.btnModificarPers.UseVisualStyleBackColor = true;
            this.btnModificarPers.Click += new System.EventHandler(this.btnModificarPers_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(361, 453);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(152, 30);
            this.btnModificarAuto.TabIndex = 29;
            this.btnModificarAuto.Text = "Modificar Auto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 515);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnModificarPers);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grillaAutosxPers);
            this.Controls.Add(this.btnBorrarAuto);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.grillaAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAgregarPersonas);
            this.Controls.Add(this.Personas);
            this.Controls.Add(this.grillaPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutosxPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPersona;
        private System.Windows.Forms.Label Personas;
        private System.Windows.Forms.Button btnAgregarPersonas;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtDni;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaAutos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnBorrarAuto;
        private System.Windows.Forms.DataGridView grillaAutosxPers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnModificarPers;
        private System.Windows.Forms.Button btnModificarAuto;
    }
}

