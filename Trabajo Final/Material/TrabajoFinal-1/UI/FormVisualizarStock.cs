using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace UI
{
    public partial class FormVisualizarStock : Form
    {
        public FormVisualizarStock()
        {
            InitializeComponent();
            this.dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            oBLLProducto = new BLLProducto();
        }
        BLLProducto oBLLProducto;
        private void FormVisualizarStock_Load(object sender, EventArgs e)
        {
            CargarDataGridProductos();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipo.Text == "Producto")
            {
                CargarDataGridProductos();
            }
            else
            {
                CargarDataGridMateriales();
            }
        }

        private void CargarDataGridMateriales()
        {
            this.dataGridViewStock.DataSource = null;
            this.dataGridViewStock.DataSource = oBLLProducto.ListarTodo().FindAll(x => x.Tipo == "Material");
            this.dataGridViewStock.Columns.Remove("Descripcion");
            this.dataGridViewStock.Columns.Remove("Material");
            this.dataGridViewStock.Columns.Remove("Precio");
        }

        private void CargarDataGridProductos()
        {
            this.dataGridViewStock.DataSource = null;
            this.dataGridViewStock.DataSource = oBLLProducto.ListarTodo().FindAll(x => x.Tipo != "Material");
        }
    }
}
