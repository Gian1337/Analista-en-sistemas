using BE;
using BLL;
using System;
using System.Windows.Forms;


namespace UI
{
    public partial class FormSeleccionCliente : Form
    {
        public FormSeleccionCliente()
        {
            InitializeComponent();
            this.dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLCliente = new BLLCliente();
            oBECliente = new BECliente();
            oBLLEstado = new BLLEstado();
            oBLLPedido = new BLLPedido();
        }
        public BEEmpleado UsuarioActual;
        public BEPedido oBEPedido;
        BLLPedido oBLLPedido;
        BLLCliente oBLLCliente;
        BECliente oBECliente;
        BLLEstado oBLLEstado;
        private void FormGestorClientes_Load(object sender, EventArgs e)
        {
            CargarDataGridClientes();
        }
        private void CargarDataGridClientes()
        {
            // Se listan todos los clientes registrados
            this.dataGridViewClientes.DataSource = null;
            this.dataGridViewClientes.DataSource = oBLLCliente.ListarTodo();
        }
        private void buttonSelCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Se selecciona un cliente y se lo asigna al pedido
                oBECliente = (BECliente)this.dataGridViewClientes.CurrentRow.DataBoundItem;
                DialogResult dialog = MessageBox.Show($"Asignar pedido a {oBECliente.Nombre} {oBECliente.Apellido}", "Confirmación", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEPedido.Cliente = oBECliente;
                    oBEPedido.Fecha = DateTime.Today;
                    oBEPedido.Estado = oBLLEstado.actualizarEstado(oBEPedido);
                    oBEPedido.ImporteTotal = oBLLPedido.calcularImporteTotal(oBEPedido);

                    // Se abre un formulario para mostrar los detalles del pedido
                    FormDetallePedido form = new FormDetallePedido();
                    form.oBEPedido = oBEPedido;
                    form.UsuarioActual = UsuarioActual;
                    form.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Se abre un formulario para el registro de un nuevo cliente
            FormGestorClientes form = new FormGestorClientes();
            form.UsuarioActual = UsuarioActual;
            form.Show();
            form.FormClosing += actualizarDataGrid;
        }

        private void actualizarDataGrid(object sender, FormClosingEventArgs e)
        {
            CargarDataGridClientes();
        }
    }
}
