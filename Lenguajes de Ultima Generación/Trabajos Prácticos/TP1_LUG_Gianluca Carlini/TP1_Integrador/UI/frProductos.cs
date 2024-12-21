using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Microsoft.VisualBasic;

namespace UI
{
    public partial class frProductos : Form
    {
        public frProductos()
        {
            InitializeComponent();

            objBLLProveedor = new BLLProveedor();
            objBLLBolso = new BLLBolso();
            objBLLCalzado = new BLLCalzado();
        }

        BLLProveedor objBLLProveedor;
        BLLBolso objBLLBolso;
        BLLCalzado objBLLCalzado;
        private void frProductos_Load(object sender, EventArgs e)
        {
            this.rbtnCalzado.Checked = true;
            LoadComboProv();
        }

        void LoadComboProv()
        {
            comboBoxProv.DataSource = null;
            comboBoxProv.DataSource = objBLLProveedor.ListarTodo();
            comboBoxProv.DisplayMember = "Razon_Social";
            comboBoxProv.ValueMember = "Codigo";
            comboBoxProv.Refresh();
        }

        void LoadGrillaCalzado()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = objBLLCalzado.ListarTodo();
        }

        void LoadGrillaBolso()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = objBLLBolso.ListarTodo();
        }

        private void rbtnBolso_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrillaBolso();
            label8.Text = "Capacidad: ";
            label9.Text = null;
            textBox6.Visible = false;
        }

        private void rbtnCalzado_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Material";
            label9.Text = "Talle";
            textBox6.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    if(rbtnCalzado.Checked == true)
                    {
                        BECalzado objBECalzado = new BECalzado();

                        objBECalzado.Codigo = int.Parse(lblCodigo.Text);
                        objBECalzado.Descripcion = textBox1.Text;
                        objBECalzado.Marca = textBox2.Text;
                        objBECalzado.Precio = int.Parse(textBox3.Text);
                        objBECalzado.Proveedor = (BEProveedor)comboBoxProv.SelectedItem;
                        objBECalzado.Material = textBox5.Text;
                        objBECalzado.Talle = int.Parse(textBox6.Text);
                        objBLLCalzado.Guardar(objBECalzado);
                        MessageBox.Show("Producto cargado correctamente");
                        LoadGrillaCalzado();
                    }
                else if(rbtnBolso.Checked == true)
                {
                    BEBolso objBEBolso = new BEBolso();

                    objBEBolso.Codigo = int.Parse(lblCodigo.Text);
                    objBEBolso.Descripcion = textBox1.Text;
                    objBEBolso.Marca = textBox2.Text;
                    objBEBolso.Precio = int.Parse(textBox3.Text);
                    objBEBolso.Proveedor = (BEProveedor)comboBoxProv.SelectedItem;
                    objBEBolso.Capacidad = int.Parse(textBox5.Text);

                    objBLLBolso.Guardar(objBEBolso);
                    MessageBox.Show("Producto cargado correctamente");
                    LoadGrillaBolso();
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Dialog;

                if(rbtnCalzado.Checked == true)
                {
                    BECalzado objBECalzado = (BECalzado)this.dataGridView1.CurrentRow.DataBoundItem;

                    Dialog = MessageBox.Show("Desea eliminar el producto?", "INFO", MessageBoxButtons.YesNo);
                    if(Dialog == DialogResult.Yes)
                    {
                        objBLLCalzado.Borrar(objBECalzado);
                        LoadGrillaCalzado();
                    }
                }
                else
                {
                    BEBolso objBEBolso = (BEBolso)this.dataGridView1.CurrentRow.DataBoundItem;

                    Dialog = MessageBox.Show("Desea eliminar el producto?", "INFO", MessageBoxButtons.YesNo);
                    if (Dialog == DialogResult.Yes)
                    {
                        objBLLBolso.Borrar(objBEBolso);
                        LoadGrillaBolso();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
