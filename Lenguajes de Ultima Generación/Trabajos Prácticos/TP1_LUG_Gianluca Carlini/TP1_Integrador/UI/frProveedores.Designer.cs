namespace UI
{
    partial class frProveedores
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
            this.CLIENTES = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarPrv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTES.Location = new System.Drawing.Point(161, 40);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(196, 26);
            this.CLIENTES.TabIndex = 3;
            this.CLIENTES.Text = "PROVEEDORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(399, 449);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAgregarPrv
            // 
            this.btnAgregarPrv.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrv.Location = new System.Drawing.Point(58, 552);
            this.btnAgregarPrv.Name = "btnAgregarPrv";
            this.btnAgregarPrv.Size = new System.Drawing.Size(125, 33);
            this.btnAgregarPrv.TabIndex = 4;
            this.btnAgregarPrv.Text = "AGREGAR";
            this.btnAgregarPrv.UseVisualStyleBackColor = true;
            this.btnAgregarPrv.Click += new System.EventHandler(this.btnAgregarPrv_Click);
            // 
            // frProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 608);
            this.Controls.Add(this.btnAgregarPrv);
            this.Controls.Add(this.CLIENTES);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frProveedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLIENTES;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarPrv;
    }
}