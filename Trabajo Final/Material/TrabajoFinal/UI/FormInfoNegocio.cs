using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using BE;

namespace UI
{
    public partial class FormInfoNegocio : Form
    {
        public FormInfoNegocio()
        {
            InitializeComponent();
            oBLLPedido = new BLLPedido();
            oBLLProducto = new BLLProducto();
        }
        BLLPedido oBLLPedido;
        BLLProducto oBLLProducto;

        private void FormInfoNegocio_Load(object sender, EventArgs e)
        {
            CargarVentasPorMes();
            MostrarArticuloMasVendido();
            this.Shown += Form_Shown;
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            CargarDataGridProdVendidos();
        }
        private void CargarDataGridProdVendidos()
        {    
            // Se listan los productos más vendidos en orden descendente
            this.dataGridViewProdVendidos.DataSource = null;
            this.dataGridViewProdVendidos.DataSource = oBLLProducto.ListaProductosPorCantidadVendida();
            this.dataGridViewProdVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdVendidos.Columns["Nombre"].Width = 150;
            this.dataGridViewProdVendidos.Columns["Nombre"].HeaderText = "Producto";
            this.dataGridViewProdVendidos.Columns.Remove("Codigo");
            this.dataGridViewProdVendidos.Columns.Remove("Descripcion");
            this.dataGridViewProdVendidos.Columns.Remove("Material");
            this.dataGridViewProdVendidos.Columns.Remove("Tipo");
            this.dataGridViewProdVendidos.Columns.Remove("Precio");
            this.dataGridViewProdVendidos.Columns.Remove("Id");
        }

        private void MostrarArticuloMasVendido()
        {
            try
            {
                // Se muestra el producto más vendido
                BEProducto oBEProducto = oBLLProducto.ListaProductosPorCantidadVendida().First();
                if(oBEProducto != null)
                {
                    this.labelArticulo.Text = oBEProducto.Nombre;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void CargarVentasPorMes()
        {
            try
            {
                // Se muestra en un chart las ventas por mes en un grafico de barras
                Dictionary<string,double> listaChart = new Dictionary<string, double>();
                string mes = "";
                foreach(BEPedido oBEPedido in oBLLPedido.ListarTodo())
                {
                    mes = oBEPedido.Fecha.ToString("yyyy-MM");

                    if (!listaChart.ContainsKey(mes))
                    {
                        listaChart[mes] = 0;
                    }
                    listaChart[mes] += oBEPedido.ImporteTotal;
                }

                chartVentas.Titles.Clear();
                chartVentas.Series.Clear();
                chartVentas.ChartAreas.Clear();
                chartVentas.Titles.Add(new Title("Recaudación de ventas por mes"));
                chartVentas.ChartAreas.Add(new ChartArea());

                Series serie1 = new Series("Ventas");
                serie1.ChartType = SeriesChartType.Column;
                serie1.Points.DataBindXY(listaChart.Keys, listaChart.Values);
                chartVentas.Series.Add(serie1);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
