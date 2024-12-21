namespace UI
{
    partial class FormIngresoFecha
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(12, 9);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(273, 47);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Texto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonContinuar.Location = new System.Drawing.Point(111, 91);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(75, 23);
            this.buttonContinuar.TabIndex = 2;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // FormIngresoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(297, 118);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTexto);
            this.Name = "FormIngresoFecha";
            this.Text = "Seleccione una fecha";
            this.Load += new System.EventHandler(this.FormIngresoFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonContinuar;
    }
}