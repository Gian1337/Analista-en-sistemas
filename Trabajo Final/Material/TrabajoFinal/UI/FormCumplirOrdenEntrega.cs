using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCumplirOrdenEntrega : Form
    {
        public FormCumplirOrdenEntrega()
        {
            InitializeComponent();
            oBLLEntrega = new BLLEntrega();
            oBLLPedido = new BLLPedido();
            oBLLEstado = new BLLEstado();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BLLEntrega oBLLEntrega;
        BLLPedido oBLLPedido;
        BLLEstado oBLLEstado;
        BLLBitacora oBLLBitacora;
        private void buttonIngresarCod_Click(object sender, EventArgs e)
        {
            try
            {
                // Se ingresa el codigo y se busca la orden mostrandose sus datos y finalizandola
                if (textBoxCod.Text != "")
                {
                    BEEntrega oBEEntrega = oBLLEntrega.BuscarOrdenEntregaPorCodigo(textBoxCod.Text);
                    if (oBEEntrega != null)
                    {
                        MessageBox.Show("Se ha encontrado la orden");
                        string Detalle = "DETALLES DE ORDEN DE ENTREGA\n" +
                            $"PEDIDO N°: {oBEEntrega.Pedido.Numero}\n" +
                            $"CLIENTE: {oBEEntrega.Pedido.Cliente.Nombre} {oBEEntrega.Pedido.Cliente.Apellido} DNI: {oBEEntrega.Pedido.Cliente.NroDocumento}\n" +
                            $"DIRECCION DE ENTREGA: {oBEEntrega.Pedido.Cliente.DireccionEntrega}\n" +
                            $"FECHA DE GENERACIÓN DE ORDEN: {oBEEntrega.Fecha}\n\n" +
                            $"PRODUCTOS:\n";
                        foreach (BEProducto p in oBEEntrega.Pedido.listaProductos)
                        {
                            Detalle += $"{p.Cantidad}x          {p.Nombre}\n";
                        }
                        DialogResult dialog = MessageBox.Show(Detalle, "Info", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            oBLLEntrega.CumplirOrdenEntrega(oBEEntrega);
                            oBEEntrega.Pedido.Estado = oBLLEstado.actualizarEstado(oBEEntrega.Pedido);
                            if (oBLLPedido.Guardar(oBEEntrega.Pedido) == true)
                            {
                                MessageBox.Show("La entrega ha sido finalizada con exito");
                                oBLLBitacora.Log(UsuarioActual, $"Orden de entrega n°{oBEEntrega.Id} cumplida");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El codigo ingresado es incorrecto o ya se ha finalizado la orden de entrega");
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
