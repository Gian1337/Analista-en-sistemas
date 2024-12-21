using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iter_InterfazPropia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EjecutaAccion(new Suma());
        }
        private void EjecutaAccion(IOperacion pIOpracion)
        {
            textBox3.Text = pIOpracion.Ejecutar(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjecutaAccion(new Resta());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EjecutaAccion(new Producto());
        }
    }

    public interface IOperacion
    {
        decimal Ejecutar(decimal n1, decimal n2);
    }

    public class Suma : IOperacion
    {
        public decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
    }
    public class Resta : IOperacion
    {
        public decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
    }
    public class Producto : IOperacion
    {
        public decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
    }
}
