using BE;
using BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace UI
{
    public partial class FormTomarPedido : Form
    {
        public FormTomarPedido()
        {
            InitializeComponent();
            this.dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCarro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLProducto = new BLLProducto();
            oBEProducto = new BEProducto();
            oBEPedido = new BEPedido();
            oBLLPedido = new BLLPedido();
        }
        public BEEmpleado UsuarioActual;
        BEPedido oBEPedido;
        BEProducto oBEProducto;
        BLLProducto oBLLProducto;
        BLLPedido oBLLPedido;
        List<BEProducto> listaProductos = new List<BEProducto>();
        private void FormTomarPedido_Load(object sender, EventArgs e)
        {
            // Se listan todos los productos que no sean materiales
            listaProductos = oBLLProducto.ListarTodo().FindAll(x => x.Tipo != "Material");
            CargarProductosDisponibles();
        }
        private void CargarProductosDisponibles()
        {
            try
            {
                this.dataGridViewProductos.DataSource = null;
                this.dataGridViewProductos.DataSource = listaProductos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)this.dataGridViewProductos.CurrentRow.DataBoundItem;

                // cargo los detalles
                this.groupBoxDetalleProd.Visible = true;
                this.labelNomProd.Text = oBEProducto.Nombre;
                this.labelDescProd.Text = oBEProducto.Descripcion;
                this.labelMatProd.Text = "Material: " + oBEProducto.Material;
                this.labelTipoProd.Text = "Tipo: " + oBEProducto.Tipo;
                this.labelPrecioProd.Text = $"${oBEProducto.Precio}";
                if (oBEProducto.Cantidad != 0)
                {
                    this.labelCantProd.Text = "Stock disponible: " + oBEProducto.Cantidad;
                }
                else
                {
                    this.labelCantProd.Text = "Sin stock";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAgregarProd_Click(object sender, EventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)this.dataGridViewProductos.CurrentRow.DataBoundItem;
                if (oBEProducto.Cantidad != 0)
                {
                    int cantidad = 0;
                    string numero = Interaction.InputBox("Ingrese la cantidad: ", DefaultResponse: "0");
                    if (string.IsNullOrEmpty(numero))
                    {
                        return;
                    }
                    if (int.TryParse(numero, out cantidad))
                    {
                        if (cantidad <= oBEProducto.Cantidad && cantidad > 0)
                        {
                            // instancio el producto que va al carrito con sus datos
                            BEProducto oBEProdCarrito = new BEProducto();
                            oBEProdCarrito.Id = oBEProducto.Id;
                            oBEProdCarrito.Codigo = oBEProducto.Codigo;
                            oBEProdCarrito.Nombre = oBEProducto.Nombre;
                            oBEProdCarrito.Descripcion = oBEProducto.Descripcion;
                            oBEProdCarrito.Material = oBEProducto.Material;
                            oBEProdCarrito.Precio = oBEProducto.Precio;
                            oBEProdCarrito.Tipo = oBEProducto.Tipo;
                            oBEProdCarrito.Cantidad = cantidad;

                            // actualizo el stock provisorio del producto
                            oBEProducto.Cantidad -= cantidad;

                            if (oBEPedido.listaProductos.Count != 0 && oBEPedido.listaProductos.Exists(x => x.Id == oBEProdCarrito.Id))
                            {
                                // si ya hay algo en el carro verificamos que no se repitan y actualizamos su cantidad
                                oBEPedido.listaProductos.Find(x => x.Id == oBEProdCarrito.Id).Cantidad += cantidad;
                            }
                            else
                            {
                                oBEPedido.listaProductos.Add(oBEProdCarrito);
                            }
                            MessageBox.Show("Se ha agregado el producto al carrito");
                            ActualizarDetalles();
                        }
                        else
                        {
                            if (cantidad >= oBEProducto.Cantidad)
                            {
                                MessageBox.Show("La cantidad solicitada excede el stock del producto");
                            }
                            else
                            {
                                MessageBox.Show("La cantidad solicitada es incorrecta");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Especifique la cantidad en numeros");
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarDetalles()
        {
            try
            {
                this.dataGridViewProductos.Refresh();
                this.groupBoxDetalleProd.Visible = false;
                this.labelProdCarrito.Text = "Carrito: " + oBEPedido.listaProductos.Count();
                this.dataGridViewCarro.DataSource = null;
                this.dataGridViewCarro.DataSource = oBEPedido.listaProductos;
                this.labelImporte.Text = "IMPORTE TOTAL: $" + oBLLPedido.calcularImporte(oBEPedido);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonEliminarProd_Click(object sender, EventArgs e)
        {
            try
            {
                // Se elimina un producto seleccionado del carrito
                if(dataGridViewCarro.SelectedCells.Count > 0)
                {
                    if (this.dataGridViewCarro.CurrentRow != null && this.dataGridViewCarro.CurrentRow.DataBoundItem != null)
                    {
                        BEProducto oBEProductoEliminar = (BEProducto)this.dataGridViewCarro.CurrentRow.DataBoundItem;
                        DialogResult dialog = MessageBox.Show("¿Seguro desea sacar el producto del carrito?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            oBEPedido.listaProductos.Remove(oBEPedido.listaProductos.Find(x => x.Id == oBEProductoEliminar.Id));
                            listaProductos.Find(x => x.Id == oBEProductoEliminar.Id).Cantidad += oBEProductoEliminar.Cantidad;
                            ActualizarDetalles();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se muestran los detalles del pedido y se abre un formulario para la selección del cliente
                if (oBEPedido.listaProductos.Count != 0)
                {
                    string detallesPedido = "PRODUCTOS CARGADOS: \n";
                    double subtotal = 0;
                    foreach (BEProducto p in oBEPedido.listaProductos)
                    {
                        detallesPedido += $"{p.Cantidad}           {p.Nombre}           ${p.Precio}\n";
                        subtotal += p.Cantidad * p.Precio;
                    }
                    detallesPedido += "\nSUBTOTAL: " + "$" + subtotal + "\n¿Confirma los productos del carro?";
                    DialogResult dialog = MessageBox.Show(detallesPedido, "DETALLES DEL CARRITO", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        FormSeleccionCliente form = new FormSeleccionCliente();
                        form.oBEPedido = oBEPedido;
                        form.UsuarioActual = UsuarioActual;
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar al menos un producto para continuar");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormTomarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(oBEPedido.Estado.Id == 2)
            {
                FormTomarPedido formularioNuevo = new FormTomarPedido();
                formularioNuevo.Show();
                formularioNuevo.UsuarioActual = UsuarioActual;
                formularioNuevo.MdiParent = this.Parent.FindForm();
                
            }
        }

        private void dataGridViewCarro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception) {  }
        }
    }
}
