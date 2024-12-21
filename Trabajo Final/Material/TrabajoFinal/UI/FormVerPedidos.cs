using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace UI
{
    public partial class FormVerPedidos : Form
    {
        public FormVerPedidos()
        {
            InitializeComponent();
            oBLLPedido = new BLLPedido();
            oBEPedido = new BEPedido();
        }
        BLLPedido oBLLPedido;
        BEPedido oBEPedido;
        private void FormVerPedidos_Load(object sender, EventArgs e)
        {
            CargarDataGridPedidos();
        }
        private void CargarDataGridPedidos()
        {
            this.dataGridViewPedidos.DataSource = null;
            this.dataGridViewPedidos.DataSource = oBLLPedido.ListarTodo().OrderByDescending(x => x.Fecha).ToList();
            this.dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEPedido = (BEPedido)this.dataGridViewPedidos.CurrentRow.DataBoundItem;
            this.groupBoxDetalles.Visible = true;
            this.labelNumPedido.Text = oBEPedido.Numero;
            this.labelFechaPedido.Text = oBEPedido.Fecha.ToString("dd/MM/yyyy");
            this.labelClientePedido.Text = oBEPedido.Cliente.Nombre + " " + oBEPedido.Cliente.Apellido;
            this.dataGridViewProductos.DataSource = null;
            this.dataGridViewProductos.DataSource = oBEPedido.listaProductos;
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewProductos.ReadOnly = true;
        }
    }
}
