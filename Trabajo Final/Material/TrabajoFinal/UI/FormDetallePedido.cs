using BE;
using BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormDetallePedido : Form
    {
        public FormDetallePedido()
        {
            InitializeComponent();
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AcceptButton = buttonAceptar;
            this.AcceptButton.DialogResult = DialogResult.OK;
            this.CancelButton = buttonCancelar;
            oBLLPedido = new BLLPedido();
            oBLLEstado = new BLLEstado();
            oBLLAlmacen = new BLLAlmacen();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        public BEPedido oBEPedido;
        BLLPedido oBLLPedido;
        BLLEstado oBLLEstado;
        BLLAlmacen oBLLAlmacen;
        BLLBitacora oBLLBitacora;

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            cargarDatosPedido();
        }

        private void cargarDatosPedido()
        {
            try
            {
                // mostramos los detalles del pedido
                this.labelFecha.Text = oBEPedido.Fecha.ToShortDateString();
                double subtotal = oBEPedido.listaProductos.Sum(x => x.Cantidad * x.Precio);
                this.labelSubTotal.Text = "$" + subtotal.ToString();
                this.labelTotal.Text = "$" + oBEPedido.ImporteTotal.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargarDataGridView()
        {
            try
            {
                this.dataGridViewProductos.DataSource = oBEPedido.listaProductos;
                this.dataGridViewProductos.Columns.Remove("Id");
                this.dataGridViewProductos.Columns.Remove("Codigo");
                this.dataGridViewProductos.Columns.Remove("Descripcion");
                this.dataGridViewProductos.Columns.Remove("Material");
                this.dataGridViewProductos.Columns.Remove("Tipo");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // actualizamos el estado del pedido ya realizado y lo guardamos
                oBEPedido.Estado = oBLLEstado.actualizarEstado(oBEPedido);
                if (oBLLPedido.Guardar(oBEPedido) == true)
                {
                    foreach (BEProducto p in oBEPedido.listaProductos)
                    {
                        oBLLAlmacen.ActualizarStockAlmacen(p);
                    }
                    MessageBox.Show("Se ha registrado el pedido correctamente");
                    oBLLBitacora.Log(UsuarioActual, $"Nuevo pedido N°{oBEPedido.Numero} registrado");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido cancelado!");
        }
    }
}
