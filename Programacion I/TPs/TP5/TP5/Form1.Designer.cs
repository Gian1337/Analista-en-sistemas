namespace TP5
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
            this.btnAgregarNum = new System.Windows.Forms.Button();
            this.lstMostrarNum = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarNum
            // 
            this.btnAgregarNum.Location = new System.Drawing.Point(93, 142);
            this.btnAgregarNum.Name = "btnAgregarNum";
            this.btnAgregarNum.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarNum.TabIndex = 0;
            this.btnAgregarNum.Text = "AGREGAR";
            this.btnAgregarNum.UseVisualStyleBackColor = true;
            this.btnAgregarNum.Click += new System.EventHandler(this.btnAgregarNum_Click);
            // 
            // lstMostrarNum
            // 
            this.lstMostrarNum.FormattingEnabled = true;
            this.lstMostrarNum.ItemHeight = 16;
            this.lstMostrarNum.Location = new System.Drawing.Point(266, 43);
            this.lstMostrarNum.Name = "lstMostrarNum";
            this.lstMostrarNum.Size = new System.Drawing.Size(120, 164);
            this.lstMostrarNum.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(93, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMEROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lstMostrarNum);
            this.Controls.Add(this.btnAgregarNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNum;
        private System.Windows.Forms.ListBox lstMostrarNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
    }
}

