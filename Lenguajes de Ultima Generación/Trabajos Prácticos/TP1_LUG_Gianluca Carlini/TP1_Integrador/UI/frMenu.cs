using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void clienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frClientes FormClientes = new frClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProveedores FormProveedores = new frProveedores();
            FormProveedores.MdiParent = this;
            FormProveedores.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProductos FormProductos = new frProductos();
            FormProductos.MdiParent = this;
            FormProductos.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCompras FormCompra = new frCompras();
            FormCompra.MdiParent = this;
            FormCompra.Show();
        }
    }
}
