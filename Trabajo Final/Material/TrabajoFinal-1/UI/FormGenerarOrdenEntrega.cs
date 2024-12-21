using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGenerarOrdenEntrega : Form
    {
        public FormGenerarOrdenEntrega()
        {
            InitializeComponent();
            this.dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBLLPedido = new BLLPedido();
            oBEPedido = new BEPedido();
            oBLLEntrega = new BLLEntrega();
            oBLLEstado = new BLLEstado();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BEEntrega oBEEntrega;
        BLLEntrega oBLLEntrega;
        BEPedido oBEPedido;
        BLLPedido oBLLPedido;
        BLLEstado oBLLEstado;
        BLLBitacora oBLLBitacora;
        private void FormGenerarOrdenEntrega_Load(object sender, EventArgs e)
        {
            CargarDataGridPedidosListos();
        }
        private void CargarDataGridPedidosListos()
        {
            try
            {
                // Listo todos los pedidos listos para entregar
                this.dataGridViewPedidos.DataSource = null;
                this.dataGridViewPedidos.DataSource = oBLLPedido.ListarTodo().FindAll(x => x.Estado.Tipo == "Listo para entregar");
            }
            catch (Exception) { throw; }
        }

        private void buttonSelecP_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomo el pedido y muestro los detalles
                oBEEntrega = new BEEntrega();
                oBEPedido = (BEPedido)this.dataGridViewPedidos.CurrentRow.DataBoundItem;
                FormDetallePedido form = new FormDetallePedido();
                form.buttonConfirmar.Visible = true;
                form.buttonAceptar.Visible = false;
                form.buttonCancelar.Visible = false;
                form.oBEPedido = oBEPedido;
                DialogResult formDialog = form.ShowDialog();
                if (formDialog == DialogResult.Yes)
                {
                    oBEEntrega.Pedido = oBEPedido;
                    oBEEntrega.Fecha = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                    MostrarDetallesOrden();
                }
            }
            catch (Exception) { throw; }
        }

        private void MostrarDetallesOrden()
        {
            try
            {
                string Detalle = "DETALLES DE ORDEN DE ENTREGA\n" +
                    $"PEDIDO N°: {oBEEntrega.Pedido.Numero}\n" +
                    $"CLIENTE: {oBEEntrega.Pedido.Cliente.Nombre} {oBEEntrega.Pedido.Cliente.Apellido} DNI: {oBEEntrega.Pedido.Cliente.NroDocumento}\n" +
                    $"DIRECCION DE ENTREGA: {oBEEntrega.Pedido.Cliente.DireccionEntrega}\n" +
                    $"FECHA DE GENERACIÓN DE ORDEN: {oBEEntrega.Fecha}\n";
                DialogResult dialog = MessageBox.Show(Detalle, "Info", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEEntrega.Codigo = GenerarCodigoEntrega();
                    if (oBLLEntrega.Guardar(oBEEntrega) == true)
                    {
                        MessageBox.Show($"Se ha generado la orden de entrega con el codigo de entrega {oBEEntrega.Codigo}");
                        oBLLBitacora.Log(UsuarioActual, $"Se genero la orden de entrega N°{oBEEntrega.Id}");
                        ActualizarEstadoPedido(oBEEntrega.Pedido);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void ActualizarEstadoPedido(BEPedido pedido)
        {
            try
            {
                pedido.Estado = oBLLEstado.actualizarEstado(pedido);
                oBLLPedido.Guardar(pedido);
                CargarDataGridPedidosListos();
            }
            catch (Exception) { throw; }
        }

        public string GenerarCodigoEntrega()
        {
            try
            {
                Guid unicoGuid = Guid.NewGuid();
                byte[] bytes = unicoGuid.ToByteArray();
                string codigoUnico = BitConverter.ToString(bytes).Replace("-", "").Substring(0, 10);
                return codigoUnico;
            }
            catch (Exception) { throw; }
        }
    }
}
