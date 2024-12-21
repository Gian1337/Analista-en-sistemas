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
using Microsoft.VisualBasic;

namespace UI
{
    public partial class frCompras : Form
    {
        public frCompras()
        {
            InitializeComponent();
            objBLLCliente = new BLLCliente();
            objBLLCalzado = new BLLCalzado();
            objBLLBolso = new BLLBolso();
        }

        BLLCliente objBLLCliente;
        BLLCalzado objBLLCalzado;
        BLLBolso objBLLBolso;

        List<BEProducto> ListaProducto = new List<BEProducto>();

        private void frCompras_Load(object sender, EventArgs e)
        {
            LoadGrillaClientes();
            radioButton1.Checked = true;
        }

        void LoadGrillaClientes()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objBLLCliente.ListarTodo();
        }

        void LoadGrillaProdCalzado()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = objBLLCalzado.ListarTodo();
        }

        void LoadGrillaProdBolso()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = objBLLBolso.ListarTodo();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrillaProdCalzado();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrillaProdBolso();
        }

        void LoadGrillaCompras(BECliente objBECLiente)
        {
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = objBECLiente.ListaProductos;
            this.dataGridView3.Columns.Remove("Proveedor");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BECliente objBeCliente = (BECliente)this.dataGridView1.CurrentRow.DataBoundItem;
                LoadGrillaCompras(objBeCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BECliente objBECliente = (BECliente)this.dataGridView1.CurrentRow.DataBoundItem;
                DialogResult dialog = MessageBox.Show($"Desea registrar la compra de {objBECliente.Nombre} {objBECliente.Apellido} (DNI: {objBECliente.DNI}) ?","Información",MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    foreach (BEProducto prod in ListaProducto)
                    {
                        if (prod is BECalzado)
                        {
                            objBLLCalzado.GuardarProducto_Cliente(objBECliente, prod as BECalzado);
                        }else objBLLBolso.GuardarProducto_Cliente(objBECliente, prod as BEBolso);
                    }
                }
                ListaProducto.Clear();
                LoadGrillaCompras(objBLLCliente.ListarTodo().Find(x => x.Codigo == objBECliente.Codigo));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
