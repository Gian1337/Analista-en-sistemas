namespace UI
{
    partial class FormBackup
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
            this.dataGridViewBackup = new System.Windows.Forms.DataGridView();
            this.buttonCrearBackup = new System.Windows.Forms.Button();
            this.buttonCargarBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBackup
            // 
            this.dataGridViewBackup.AllowUserToAddRows = false;
            this.dataGridViewBackup.AllowUserToDeleteRows = false;
            this.dataGridViewBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackup.Location = new System.Drawing.Point(3, 76);
            this.dataGridViewBackup.Name = "dataGridViewBackup";
            this.dataGridViewBackup.ReadOnly = true;
            this.dataGridViewBackup.Size = new System.Drawing.Size(429, 255);
            this.dataGridViewBackup.TabIndex = 0;
            this.dataGridViewBackup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBackup_CellContentClick);
            // 
            // buttonCrearBackup
            // 
            this.buttonCrearBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearBackup.Location = new System.Drawing.Point(488, 99);
            this.buttonCrearBackup.Name = "buttonCrearBackup";
            this.buttonCrearBackup.Size = new System.Drawing.Size(153, 39);
            this.buttonCrearBackup.TabIndex = 1;
            this.buttonCrearBackup.Text = "Crear backup";
            this.buttonCrearBackup.UseVisualStyleBackColor = true;
            this.buttonCrearBackup.Click += new System.EventHandler(this.buttonCrearBackup_Click);
            // 
            // buttonCargarBackup
            // 
            this.buttonCargarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarBackup.Location = new System.Drawing.Point(488, 157);
            this.buttonCargarBackup.Name = "buttonCargarBackup";
            this.buttonCargarBackup.Size = new System.Drawing.Size(153, 39);
            this.buttonCargarBackup.TabIndex = 2;
            this.buttonCargarBackup.Text = "Restaurar backup";
            this.buttonCargarBackup.UseVisualStyleBackColor = true;
            this.buttonCargarBackup.Click += new System.EventHandler(this.buttonCargarBackup_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 73);
            this.label2.TabIndex = 11;
            this.label2.Text = "BACKUPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(672, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCargarBackup);
            this.Controls.Add(this.buttonCrearBackup);
            this.Controls.Add(this.dataGridViewBackup);
            this.Name = "FormBackup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBackup;
        private System.Windows.Forms.Button buttonCrearBackup;
        private System.Windows.Forms.Button buttonCargarBackup;
        private System.Windows.Forms.Label label2;
    }
}