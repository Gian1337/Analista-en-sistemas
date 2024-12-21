namespace TP_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstColaFem = new System.Windows.Forms.ListBox();
            this.lstColaMasc = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgregarNad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDesencolarFem = new System.Windows.Forms.Button();
            this.btnDesencolarMasc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cola Femenina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cola Masculina";
            // 
            // lstColaFem
            // 
            this.lstColaFem.FormattingEnabled = true;
            this.lstColaFem.ItemHeight = 16;
            this.lstColaFem.Location = new System.Drawing.Point(40, 37);
            this.lstColaFem.Name = "lstColaFem";
            this.lstColaFem.Size = new System.Drawing.Size(120, 148);
            this.lstColaFem.TabIndex = 2;
            // 
            // lstColaMasc
            // 
            this.lstColaMasc.FormattingEnabled = true;
            this.lstColaMasc.ItemHeight = 16;
            this.lstColaMasc.Location = new System.Drawing.Point(40, 242);
            this.lstColaMasc.Name = "lstColaMasc";
            this.lstColaMasc.Size = new System.Drawing.Size(120, 148);
            this.lstColaMasc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nadadores";
            // 
            // txtAgregarNad
            // 
            this.txtAgregarNad.Location = new System.Drawing.Point(376, 204);
            this.txtAgregarNad.Name = "txtAgregarNad";
            this.txtAgregarNad.Size = new System.Drawing.Size(100, 22);
            this.txtAgregarNad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(376, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDesencolarFem
            // 
            this.btnDesencolarFem.BackColor = System.Drawing.Color.Red;
            this.btnDesencolarFem.ForeColor = System.Drawing.Color.White;
            this.btnDesencolarFem.Location = new System.Drawing.Point(189, 92);
            this.btnDesencolarFem.Name = "btnDesencolarFem";
            this.btnDesencolarFem.Size = new System.Drawing.Size(127, 23);
            this.btnDesencolarFem.TabIndex = 7;
            this.btnDesencolarFem.Text = "DESENCOLAR";
            this.btnDesencolarFem.UseVisualStyleBackColor = false;
            this.btnDesencolarFem.Click += new System.EventHandler(this.btnDesencolarFem_Click);
            // 
            // btnDesencolarMasc
            // 
            this.btnDesencolarMasc.BackColor = System.Drawing.Color.Red;
            this.btnDesencolarMasc.ForeColor = System.Drawing.Color.White;
            this.btnDesencolarMasc.Location = new System.Drawing.Point(189, 298);
            this.btnDesencolarMasc.Name = "btnDesencolarMasc";
            this.btnDesencolarMasc.Size = new System.Drawing.Size(127, 23);
            this.btnDesencolarMasc.TabIndex = 8;
            this.btnDesencolarMasc.Text = "DESENCOLAR";
            this.btnDesencolarMasc.UseVisualStyleBackColor = false;
            this.btnDesencolarMasc.Click += new System.EventHandler(this.btnDesencolarMasc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesencolarMasc);
            this.Controls.Add(this.btnDesencolarFem);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgregarNad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstColaMasc);
            this.Controls.Add(this.lstColaFem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstColaFem;
        private System.Windows.Forms.ListBox lstColaMasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgregarNad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDesencolarFem;
        private System.Windows.Forms.Button btnDesencolarMasc;
    }
}

