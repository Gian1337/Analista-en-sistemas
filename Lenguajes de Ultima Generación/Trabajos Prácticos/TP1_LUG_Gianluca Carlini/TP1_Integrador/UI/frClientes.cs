using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frClientes : Form
    {
        
        public frClientes()
        {
            InitializeComponent();
            objBLLCliente = new BLLCliente();
        }

        BLLCliente objBLLCliente;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            LoadGrillaCliente();
        }

        void LoadGrillaCliente()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objBLLCliente.ListarTodo();
            this.dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLTest oBLLTest = new BLLTest();

            MessageBox.Show(oBLLTest.Test(), "TESTEANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
