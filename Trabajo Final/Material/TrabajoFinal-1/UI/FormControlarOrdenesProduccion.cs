using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormControlarOrdenesProduccion : Form
    {
        public FormControlarOrdenesProduccion()
        {
            InitializeComponent();
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBEOrdenProduccion = new BEOrdenProduccion();
        }
        BLLOrdenProduccion oBLLOrdenProduccion;
        BEOrdenProduccion oBEOrdenProduccion;
        private void FormControlarOrdenesProduccion_Load(object sender, EventArgs e)
        {
            CargarDataGridOrdenesSinAsignar();
        }
        private void CargarDataGridOrdenesSinAsignar()
        {
            // Se cargan aquellas ordenes que no tienen empleado asignado
            this.dataGridViewOrdenes.DataSource = null;
            this.dataGridViewOrdenes.DataSource = oBLLOrdenProduccion.ListarTodo().FindAll(x => x.Empleado == null);
            this.dataGridViewOrdenes.CellFormatting += DataGridView_CellFormatting;
        }
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // metodo para que las columnas correspondientes al usuario muestren el nombre de usuario
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOrdenes.Columns["Producto"].Index)
            {
                BEOrdenProduccion oBEOrdenProduccion = (BEOrdenProduccion)dataGridViewOrdenes.Rows[e.RowIndex].DataBoundItem;
                if (oBEOrdenProduccion != null && oBEOrdenProduccion.Producto != null)
                {
                    e.Value = oBEOrdenProduccion.Producto.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEOrdenProduccion = (BEOrdenProduccion)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                this.buttonSeleccionarOrden.Enabled = true;
                this.groupBoxDetallesOrden.Visible = true;
                this.labelFecha.Text = oBEOrdenProduccion.Fecha.ToString("dd/MM/yyyy");
                this.labelProd.Text = oBEOrdenProduccion.Producto.Nombre;
                this.labelMat.Text = oBEOrdenProduccion.Producto.Material;
                this.labelCant.Text = oBEOrdenProduccion.Cantidad.ToString();
            }
            catch (Exception) { throw; }
        }

        private void buttonSeleccionarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                this.groupBoxDetallesOrden.Visible = false;

                // Se verifica que haya material disponible para realizar la orden
                if (oBLLOrdenProduccion.CalcularMateriaPrima(oBEOrdenProduccion) == true)
                {
                    MessageBox.Show("Materia prima disponible");
                    AsignarEmpleadoOrdenProduccion();
                }
                else
                {
                    if (oBEOrdenProduccion.PedidoMaterial == null)
                    {
                        DialogResult dialog = MessageBox.Show("Hay faltante de materia prima para llevar a cabo la orden\n¿Desea generar una orden de pedido de material?", "Falta de material", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            // Si no hay stock se abre el formulario para crear un pedido de material y llevar a cabo la orden
                            FormGenerarPedidoMaterial form = new FormGenerarPedidoMaterial();
                            form.oBEOrdenProduccion = oBEOrdenProduccion;
                            form.Show();
                            form.FormClosing += ActualizarDataGrid;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta orden tiene un pedido de material en curso, espera a que se complete para poder realizarla");
                    }
                }
            }
            catch (Exception) { throw; }
        }

        private void ActualizarDataGrid(object sender, FormClosingEventArgs e)
        {
            CargarDataGridOrdenesSinAsignar();
        }

        private void AsignarEmpleadoOrdenProduccion()
        {
            try
            {
                // Se despliega un formulario para seleccionar el empleado
                FormEmpleados form = new FormEmpleados();
                DialogResult dialogResult = form.ShowDialog();

                if (dialogResult == DialogResult.Yes)
                {
                    AsignarFechaRealizacion();
                    oBEOrdenProduccion.Empleado = form.UsuarioEmpleado;
                    oBLLOrdenProduccion.AsignarOrdenEmpleado(oBEOrdenProduccion);
                    MessageBox.Show($"Se ha asignado el empleado a la orden de produccion con fecha limite del {oBEOrdenProduccion.Fecha.ToString("dd/MM/yyyy")}");
                    CargarDataGridOrdenesSinAsignar();
                }
            }
            catch (Exception) { throw; }
        }
        private void AsignarFechaRealizacion()
        {
            try
            {
                // Se despliega un formulario para ingresar la fecha de realización y se verifica la misma
                FormIngresoFecha formFecha = new FormIngresoFecha();
                formFecha.labelTexto.Text = "Ingrese la fecha limite de realización de la orden de producción";
                DialogResult dialogResultF = formFecha.ShowDialog();
                if (dialogResultF == DialogResult.Yes)
                {
                    oBEOrdenProduccion.Fecha = formFecha.fechaSeleccionada;
                    if (oBEOrdenProduccion.Fecha > DateTime.Now)
                    {
                        oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                    }
                    else
                    {
                        AsignarFechaRealizacion();
                    }
                }
            }
            catch (Exception) { throw; }
        }
    }
}
