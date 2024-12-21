using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGenerarPedidoMaterial : Form
    {
        public FormGenerarPedidoMaterial()
        {
            InitializeComponent();
            this.dataGridViewMatSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMatSelec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLPedidoMaterial = new BLLPedidoMaterial();
            oBLLProducto = new BLLProducto();
            oBEMaterial = new BEProducto();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
        }
        public BEOrdenProduccion oBEOrdenProduccion;
        List<BEProducto> listaMateriales = new List<BEProducto>();
        BLLOrdenProduccion oBLLOrdenProduccion;
        BLLPedidoMaterial oBLLPedidoMaterial;
        BLLProducto oBLLProducto;
        BEProducto oBEMaterial;
        BEProducto oBEMaterialSeleccionado;
        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomo los datos ingresados y genero un pedido de material
                DateTime FechaLimite = DateTime.Parse(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                if (listaMateriales.Count > 0 && FechaLimite >= DateTime.Now)
                {
                    BEPedidoMaterial oBEPedidoMaterial = new BEPedidoMaterial();
                    oBEPedidoMaterial.Fecha = FechaLimite;
                    oBEPedidoMaterial.Productos = listaMateriales;
                    oBLLPedidoMaterial.Guardar(oBEPedidoMaterial);
                    oBEPedidoMaterial = oBLLPedidoMaterial.ListarTodo().Last();
                    oBEOrdenProduccion.PedidoMaterial = oBEPedidoMaterial;
                    oBLLOrdenProduccion.Guardar(oBEOrdenProduccion);
                    MessageBox.Show("Se ha generado el pedido de material para la orden de produccion seleccionada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hay datos faltantes o la fecha es incorrecta");
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void FormGenerarPedidoMaterial_Load(object sender, EventArgs e)
        {
            CargarComboBoxMateriales();
        }
        private void CargarComboBoxMateriales()
        {
            try
            {
                // Cargo la lista de materiales para la producción
                List<BEProducto> materiales = oBLLProducto.ListarTodo().FindAll(x => x.Tipo == "Material");
                foreach (BEProducto m in materiales)
                {
                    m.Cantidad = 0;
                }
                this.comboBoxMateriales.DataSource = materiales;
                this.comboBoxMateriales.DisplayMember = "Nombre";
                this.comboBoxMateriales.ValueMember = "Id";
            }
            catch (Exception) { throw; }
        }

        private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                oBEMaterial = (BEProducto)this.comboBoxMateriales.SelectedItem;
            }
            catch (Exception) { throw; }
        }

        private void buttonAgregarMat_Click(object sender, EventArgs e)
        {
            try
            {
                // Agrego un material con sus cantidades a la orden
                if (textBoxCantidad.Text != "" && int.TryParse(textBoxCantidad.Text, out int cantidad))
                {
                    oBEMaterial.Cantidad += cantidad;
                    if (listaMateriales.Exists(x => x.Id == oBEMaterial.Id))
                    {
                        listaMateriales.Find(x => x.Id == oBEMaterial.Id).Cantidad = oBEMaterial.Cantidad;
                    }
                    else
                    {
                        listaMateriales.Add(oBEMaterial);
                    }
                    this.comboBoxMateriales.SelectedIndex = 0;
                    this.textBoxCantidad.Text = String.Empty;
                    ActualizarDataGridMateriales();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad");
                }
            }
            catch (Exception) { throw; }
        }
        private void ActualizarDataGridMateriales()
        {
            this.dataGridViewMatSelec.DataSource = null;
            this.dataGridViewMatSelec.DataSource = listaMateriales;
        }

        private void dataGridViewMatSelec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEMaterialSeleccionado = (BEProducto)this.dataGridViewMatSelec.CurrentRow.DataBoundItem;
            this.buttonEliminar.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listaMateriales.Remove(oBEMaterialSeleccionado);
            ActualizarDataGridMateriales();
            this.buttonEliminar.Enabled = false;
        }
    }
}
