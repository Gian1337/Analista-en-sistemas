using BE;
using BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGenerarOrdenProduccion : Form
    {
        public FormGenerarOrdenProduccion()
        {
            InitializeComponent();
            this.dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLProducto = new BLLProducto();
            oBEProducto = new BEProducto();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        List<string> listTareas = new List<string>();
        BLLProducto oBLLProducto;
        BEProducto oBEProducto;
        BEOrdenProduccion oBEOrdenProduccion;
        BLLOrdenProduccion oBLLOrdenProduccion;
        BLLBitacora oBLLBitacora;

        private void FormGenerarOrdenProduccion_Load(object sender, EventArgs e)
        {
            CargarDataGridProductos();
        }

        private void CargarDataGridProductos()
        {
            try
            {
                // Listo los productos con falta de stock
                List<BEProducto> listaProductosSinStock = oBLLProducto.ListarTodo().FindAll(x => x.Cantidad == 0 && x.Tipo != "Material" && !oBLLOrdenProduccion.ListarTodo().Exists(y => y.Producto.Id == x.Id));
                this.dataGridViewProductos.DataSource = null;
                this.dataGridViewProductos.DataSource = listaProductosSinStock;
            }
            catch (Exception ex) { throw ex; }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)this.dataGridViewProductos.CurrentRow.DataBoundItem;
                this.buttonGenerarOrden.Enabled = true;
                this.groupBox1.Visible = true;
                this.textBoxTareas.Text = String.Empty;
            }
            catch (Exception) { throw; }
        }

        private void buttonGenerarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Genero la orden de preducción del producto seleccionado
                DialogResult dialog = MessageBox.Show($"¿Desea generar una orden de produccion para el producto {oBEProducto.Nombre}?", "Alerta", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBEOrdenProduccion = new BEOrdenProduccion();
                    oBEOrdenProduccion.Fecha = DateTime.Now;
                    oBEOrdenProduccion.Cantidad = int.Parse(Interaction.InputBox("Ingrese la cantidad que desea producir: ", "Cantidad", DefaultResponse: "10"));
                    oBEOrdenProduccion.Lote = DateTime.Now.ToString("yyMMdd");
                    oBEOrdenProduccion.Tareas = listTareas;
                    oBEOrdenProduccion.Producto = oBEProducto;
                    oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                    MessageBox.Show("Se ha generado la orden exitosamente!");
                    oBLLBitacora.Log(UsuarioActual, $"Orden de produccion N°{oBEOrdenProduccion.Id} generada");
                    listTareas.Clear();
                    actualizarListBoxTareas();
                    CargarDataGridProductos();
                    this.buttonGenerarOrden.Enabled = false;
                }
            }
            catch (Exception) { throw; }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agrego una tarea a la orden de produccion
                if (!string.IsNullOrEmpty(textBoxTareas.Text))
                {
                    listTareas.Add(textBoxTareas.Text + "-");
                    actualizarListBoxTareas();
                    this.textBoxTareas.Clear();
                }
            }
            catch (Exception) { throw; }
        }

        private void actualizarListBoxTareas()
        {
            try
            {
                string textoTareas = "";
                foreach(string t in listTareas)
                {
                    textoTareas += t;
                }
                this.listBoxTareas.Items.Clear();
                this.listBoxTareas.Items.AddRange(textoTareas.Split('-'));
            }
            catch (Exception) { throw; }
        }
    }
}
