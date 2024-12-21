using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Agregacion
{
    public partial class Form1 : Form
    {
        List<Factura> _facturas;
        public Form1()
        {
            InitializeComponent();
            _facturas = new List<Factura>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Capturar y validar los datos ingresados por el usuario
                string tipo = Interaction.InputBox("Ingrese el tipo: ");
                string ptovta = Interaction.InputBox("Ingrese el punto de venta: ");
                if (!Information.IsNumeric(ptovta)) throw new Exception("El punto de venta debe ser numérico !!!");
                string numero = Interaction.InputBox("Ingrese el número de factura: ");
                if (!Information.IsNumeric(numero)) throw new Exception("El punto de venta debe ser numérico !!!");
                string cliente = Interaction.InputBox("Ingrese el cliente: ");
                string codigo, desc, cantidad, precio_unitario;
                CapturaDatosItem(out codigo, out desc, out cantidad, out precio_unitario);


                //_facturas.Add(new Factura(............));
                _facturas.Add(new Factura(tipo, int.Parse(ptovta), int.Parse(numero), cliente, int.Parse(codigo), desc, int.Parse(cantidad), decimal.Parse(precio_unitario)));

                // llamar a la función ver para refrescar las grillas 
                List<Cabecera> lc = new List<Cabecera>();
                foreach (Factura f in _facturas)
                {
                    lc.Add(f.RetornaCabecera);
                }
                dataGridView1.DataSource = null; dataGridView1.DataSource = lc;
                dataGridView1_RowEnter(null, null);
                RefrescaGrilla3();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void RefrescaGrilla3()
        {
            dataGridView3.DataSource = null; dataGridView3.DataSource = (new CabeceraVista()).FormateaVistaListaCabecera(_facturas);
        }

        private void CapturaDatosItem(out string codigo, out string desc, out string cantidad, out string precio_unitario)
        {
            codigo = Interaction.InputBox("Ingrese el código de item: ");
            if (!Information.IsNumeric(codigo)) throw new Exception("El código de item debe ser numérico !!!");
            desc = Interaction.InputBox("Ingrese la descripción del item: ");
            cantidad = Interaction.InputBox("Ingrese la cantidad para este item: ");
            if (!Information.IsNumeric(cantidad)) throw new Exception("La cantidad de este item debe ser numérico !!!");
            precio_unitario = Interaction.InputBox("Ingrese el precio unitadio del item: ");
            if (!Information.IsNumeric(precio_unitario)) throw new Exception("El precio unitario del item debe ser numérico !!!");
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dataGridView1.CurrentRow
                Factura f = RecuperaFacturaGrilla1();
                dataGridView2.DataSource = null; dataGridView2.DataSource = f.RetornaItems();
                RefrescaTotal(f);
            }
            catch (Exception) { }
        }

        private void RefrescaTotal(Factura f)
        {
            textBox1.Text = f.Total().ToString();
        }

        private Factura RecuperaFacturaGrilla1()
        {
            Cabecera c = (dataGridView1.SelectedRows[0].DataBoundItem as Cabecera);
            var f = _facturas.Find(x => x.RetornaCabecera.Tipo == c.Tipo && x.RetornaCabecera.PuntoVenta == c.PuntoVenta && x.RetornaCabecera.Numero == c.Numero);
            return f;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Factura f = RecuperaFacturaGrilla1();
                string codigo, desc, cantidad, precio_unitario;
                CapturaDatosItem(out codigo, out desc, out cantidad, out precio_unitario);
                f.AgregarItem(int.Parse(codigo), desc, int.Parse(cantidad), decimal.Parse(precio_unitario));
                dataGridView2.DataSource = null; dataGridView2.DataSource = f.RetornaItems();
                RefrescaTotal(f);
                RefrescaGrilla3();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
