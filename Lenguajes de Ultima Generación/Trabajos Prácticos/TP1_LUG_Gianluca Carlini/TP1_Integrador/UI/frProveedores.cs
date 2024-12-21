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
using BE;
using BLL;

namespace UI
{
    public partial class frProveedores : Form
    {
        public frProveedores()
        {
            InitializeComponent();
            objBLLProveedor = new BLLProveedor();
        }

        BLLProveedor objBLLProveedor;

        private void frProveedores_Load(object sender, EventArgs e)
        {
            LoadGrillaProveedores();
        }

        void LoadGrillaProveedores()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = objBLLProveedor.ListarTodo();
        }

        private void btnAgregarPrv_Click(object sender, EventArgs e)
        {
            BEProveedor objBEProveedor = new BEProveedor();

            objBEProveedor.RazonSocial = Interaction.InputBox("Ingrese la Razón Social: ");
            objBEProveedor.CUIT = Interaction.InputBox("Ingresete el CUIT del proveedor: ");

            objBLLProveedor.Guardar(objBEProveedor);
            LoadGrillaProveedores();
            MessageBox.Show("Proveedor ingresado correctamente");
        }
    }
}
