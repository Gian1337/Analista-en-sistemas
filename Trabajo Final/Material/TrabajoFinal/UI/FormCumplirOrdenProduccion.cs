using BE;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public partial class FormCumplirOrdenProduccion : Form
    {
        public FormCumplirOrdenProduccion()
        {
            InitializeComponent();
            this.dataGridViewOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBEOrdenProduccion = new BEOrdenProduccion();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado Empleado;
        BLLOrdenProduccion oBLLOrdenProduccion;
        BEOrdenProduccion oBEOrdenProduccion;
        BLLBitacora oBLLBitacora;
        List<string> listaTareas = new List<string>();
        private void FormCumplirOrdenProduccion_Load(object sender, EventArgs e)
        {
            CargarDataGridOrdenesEmpleado();
        }
        private void CargarDataGridOrdenesEmpleado()
        {
            // Se cargan aquellas ordenes de produccion que hayan sido asignadas al empleado
            this.dataGridViewOrdenes.DataSource = null;
            this.dataGridViewOrdenes.DataSource = oBLLOrdenProduccion.ListarTodo().FindAll(x => x.Empleado != null && x.Empleado.Id == Empleado.Id);
        }

        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Se listan los detalles de la orden seleccionada, mostrando sus tareas
                oBEOrdenProduccion = (BEOrdenProduccion)this.dataGridViewOrdenes.CurrentRow.DataBoundItem;
                this.groupBoxDatos.Visible = true;
                this.labelFecha.Text = oBEOrdenProduccion.Fecha.ToString("dd/MM/yyyy");
                this.labelProducto.Text = oBEOrdenProduccion.Producto.Nombre;
                if(oBEOrdenProduccion.Tareas.Count != 0)
                {
                    this.buttonFinalizarT.Enabled = true;
                    this.labelTarea.Text = oBEOrdenProduccion.Tareas.First();
                }
                else
                {
                    this.buttonCumplirOrden.Enabled = true;
                    this.labelTarea.Text = "Has finalizado todas las tareas, ya puedes finalizar la orden";
                    this.buttonFinalizarT.Enabled = false;
                }
            }
            catch (Exception) { throw; }
        }

        private void buttonFinalizarT_Click(object sender, EventArgs e)
        {
            try
            {
                // Finaliza una tarea y actualiza la tabla
                oBEOrdenProduccion.Tareas.RemoveAt(0);
                oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                if(oBEOrdenProduccion.Tareas.Count == 0)
                {
                    MessageBox.Show("Finalizaste todas las tareas de la orden");
                    this.buttonCumplirOrden.Enabled = true;
                    this.labelTarea.Text = "Has finalizado todas las tareas, ya puedes finalizar la orden";
                    this.buttonFinalizarT.Enabled = false;
                }
                else
                {
                    this.labelTarea.Text = oBEOrdenProduccion.Tareas.First();
                }
            }
            catch (Exception) { throw; }
        }

        private void buttonCumplirOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Se finaliza la orden de producción una vez se hayan cumplido las tareas
                oBLLOrdenProduccion.FinalizarOrdenProduccion(oBEOrdenProduccion);
                MessageBox.Show("Ha finalizado la orden de produccion!");
                oBLLBitacora.Log(Empleado, $"Orden de produccion finalizada N°{oBEOrdenProduccion.Numero}");
                CargarDataGridOrdenesEmpleado();
                this.groupBoxDatos.Visible = false;
            }
            catch (Exception) { throw; }
        }
    }
}
