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
    public partial class FormFinalizarPedidoMaterial : Form
    {
        public FormFinalizarPedidoMaterial()
        {
            InitializeComponent();
            oBLLPedidoMaterial = new BLLPedidoMaterial();
            oBEPedidoMaterial = new BEPedidoMaterial();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BLLPedidoMaterial oBLLPedidoMaterial;
        BEPedidoMaterial oBEPedidoMaterial;
        BLLOrdenProduccion oBLLOrdenProduccion;
        BLLBitacora oBLLBitacora;

        private void FormFinalizarPedidoMaterial_Load(object sender, EventArgs e)
        {
            cargarDataGridPedidosMaterial();
        }
        
        private void cargarDataGridPedidosMaterial()
        {
            this.dataGridViewPedidos.DataSource = oBLLPedidoMaterial.ListarTodo();
            this.dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Al seleccionar una orden, muestro los detalles
            oBEPedidoMaterial = (BEPedidoMaterial)this.dataGridViewPedidos.CurrentRow.DataBoundItem;
            this.listBoxDetalle.Items.Clear();
            this.listBoxDetalle.Items.Add($"Fecha limite: {oBEPedidoMaterial.Fecha.ToString("dd/MM/yyyy")}");
            this.listBoxDetalle.Items.Add("Productos:");
            foreach(BEProducto producto in oBEPedidoMaterial.Productos)
            {
                this.listBoxDetalle.Items.Add($"{producto.Nombre}           {producto.Cantidad}");
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            // Finalizamos la orden de pedido de material
            if(oBEPedidoMaterial.Id != 0)
            {
                oBLLPedidoMaterial.FinalizarPedidoMaterial(oBEPedidoMaterial);
                MessageBox.Show("Pedido de material finalizado");
                oBLLBitacora.Log(UsuarioActual, $"Pedido de material N°{oBEPedidoMaterial.Id} finalizado");
                this.listBoxDetalle.Items.Clear();
                cargarDataGridPedidosMaterial();
            }
        }
    }
}
