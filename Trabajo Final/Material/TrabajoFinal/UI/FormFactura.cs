using BE;
using BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace UI
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
            oBLLPedido = new BLLPedido();
            oBLLFactura = new BLLFacturaCompra();
            this.dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.AllowUserToAddRows = false;
        }
        public BEPedido oBEPedido;
        BLLPedido oBLLPedido;
        BLLFacturaCompra oBLLFactura;

        private void FormFactura_Load(object sender, EventArgs e)
        {
            if (oBEPedido.FacturaCompra.Id == 0)
            {
                GenerarFacturaPedido();
            }
            CargarDatosForm();
        }

        private void GenerarFacturaPedido()
        {
            try
            {
                BEFacturaCompra oBEFactura = new BEFacturaCompra();
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                oBEFactura.Tipo = "C";
                oBEFactura.Fecha = DateTime.Parse(fecha);
                oBEFactura.Total = oBEPedido.ImporteTotal;

                oBLLFactura.Guardar(oBEFactura);
                oBEPedido.FacturaCompra = oBEFactura;
                oBLLPedido.Guardar(oBEPedido);
                oBEPedido = oBLLPedido.ListarTodo().Find(x => x.Id == oBEPedido.Id);

            }
            catch (Exception) { throw; }
        }
        private void CargarDatosForm()
        {
            try
            {
                this.labelNroFac.Text = oBEPedido.FacturaCompra.Numero.ToString();
                this.labelFechaEmision.Text = oBEPedido.FacturaCompra.Fecha.ToString("dd/MM/yyyy");
                this.labelRazonSocial.Text = "Lefler y Wollert";
                this.labelDomicilioComer.Text = "Sargento Cabral 550";
                this.labelDni.Text = oBEPedido.Cliente.NroDocumento.ToString();
                this.labelNomYApe.Text = oBEPedido.Cliente.Nombre + " " + oBEPedido.Cliente.Apellido;
                this.labelDomicilio.Text = oBEPedido.Cliente.Direccion;
                this.labelSubTotal.Text = "$" + oBEPedido.listaProductos.Sum(x => x.Cantidad * x.Precio).ToString();
                this.labelTotal.Text = "$" + oBEPedido.ImporteTotal.ToString();

                this.dataGridViewProductos.DataSource = oBEPedido.listaProductos;
                this.dataGridViewProductos.Columns["Nombre"].FillWeight = 400;
                this.dataGridViewProductos.Columns.Remove("Id");
                this.dataGridViewProductos.Columns.Remove("Tipo");
                this.dataGridViewProductos.Columns.Remove("Material");
                this.dataGridViewProductos.Columns.Remove("Descripcion");
                this.dataGridViewProductos.Columns["Precio"].HeaderText = "Precio unitario";
                this.dataGridViewProductos.ClearSelection();
            }
            catch (Exception) { throw; }
        }

        private void buttonGuardarFac_Click(object sender, EventArgs e)
        {
            // Realizamos un bitmap de la factura y la guardamos en PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar factura";
            saveFileDialog.FileName = $"Factura C {oBEPedido.Fecha.ToString("dd-MM-yyyy HH-mm-ss")}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string directorioPdf = saveFileDialog.FileName;

                try
                {
                    System.Drawing.Rectangle rectanguloPanel = this.panel1.Bounds;
                    Bitmap bmap = new Bitmap(rectanguloPanel.Width, rectanguloPanel.Height);
                    using (Document documento = new Document(PageSize.A4, 0, 0, 0, 0))
                    {

                        PdfWriter pWriter = PdfWriter.GetInstance(documento, new FileStream(directorioPdf, FileMode.Create));
                        documento.Open();
                        PdfContentByte contentbyte = pWriter.DirectContent;
                        this.panel1.DrawToBitmap(bmap, new System.Drawing.Rectangle(0, 0, rectanguloPanel.Width, rectanguloPanel.Height));
                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(bmap, BaseColor.WHITE);

                        float x = (documento.PageSize.Width - imagen.ScaledWidth) / 2;
                        float y = (documento.PageSize.Height - imagen.ScaledHeight) / 2;

                        imagen.SetAbsolutePosition(x, y);
                        documento.Add(imagen);

                        MessageBox.Show("Se ha guardado la factura correctamente");
                        documento.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewProductos.ClearSelection();
        }
    }
}
