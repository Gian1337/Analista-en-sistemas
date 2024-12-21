using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGenerarFactura : Form
    {
        public FormGenerarFactura()
        {
            InitializeComponent();
            this.dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBEPedido = new BEPedido();
            oBLLPedido = new BLLPedido();
        }
        BEPedido oBEPedido;
        BLLPedido oBLLPedido;

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            CargarDataGridViewPedidosSinFactura();
        }
        private void CargarDataGridViewPedidosSinFactura()
        {
            try
            {
                // Listo los pedidos sin factura generada
                this.dataGridViewPedidos.DataSource = null;
                this.dataGridViewPedidos.DataSource = oBLLPedido.ListarTodo().FindAll(x => x.FacturaCompra.Id == 0);
            }
            catch (Exception) { throw; }
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEPedido = (BEPedido)this.dataGridViewPedidos.CurrentRow.DataBoundItem;
                this.buttonGenerarFac.Enabled = true;
                if (oBEPedido.FacturaCompra.Id == 0)
                {
                    this.buttonGenerarFac.Text = "Generar factura";
                }
                else
                {
                    this.buttonGenerarFac.Text = "Ver factura";
                }
            }
            catch (Exception) { throw; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestro los detalles de la factura en otro formulario
                FormFactura form = new FormFactura();
                form.oBEPedido = oBEPedido;
                form.Show();
                form.FormClosed += Form_FormClosed;
            }
            catch (Exception) { throw; }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.buttonGenerarFac.Enabled=false;
            CargarDataGridViewPedidosSinFactura();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Checkbox para alternar entre pedidos con factura y pedidos sin factura generada
            if(checkBox1.Checked == true)
            {
                this.dataGridViewPedidos.DataSource = null;
                this.dataGridViewPedidos.DataSource = oBLLPedido.ListarTodo().FindAll(x => x.FacturaCompra.Id != 0);
            }
            else
            {
                CargarDataGridViewPedidosSinFactura();
            }
        }
    }
}
