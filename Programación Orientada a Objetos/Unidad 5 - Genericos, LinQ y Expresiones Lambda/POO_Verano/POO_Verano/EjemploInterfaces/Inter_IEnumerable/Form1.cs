using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_IEnumerable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto p;
        List<Producto> lp;
        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Producto() {Codigo="7791762833069", Descripción="Cuaderno Universitario" };

            lp = new List<Producto>();
            lp.AddRange(new Producto[]
                {
                new Producto() { Codigo = "7791762833069", Descripción = "Cuaderno Universitario" } ,
                new Producto() { Codigo = "7894325342150", Descripción = "Lápiz" } ,
                new Producto() { Codigo = "4460987654321", Descripción = "Goma" }
        });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.EnumeraPorEAN13 = false;
            textBox1.Clear();
            foreach (var item in p)
            {
                textBox1.Text += $"{item.ToString()}{Environment.NewLine}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            string[] descri = new string[] {"Código","Descripción" };
            foreach (var item in lp)
            {
                item.EnumeraPorEAN13 = false;           
                int c = 0;
                foreach (var s in item)
                {
                    string des = c == 0 ? descri[0] : descri[1];
                    textBox1.Text += $"{des}: {s.ToString()}   ";
                    c++;
                }
                textBox1.Text += $"{Environment.NewLine}"; 

            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.EnumeraPorEAN13 = true;
            textBox1.Clear();
            string[] descri = new string[] { "País: ", "Empresa: ","Producto: ", "DV: " };
            int c = 0;
            foreach (var item in p)
            {
                textBox1.Text += $"{descri[c]}{item.ToString()}   ";
                c++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string[] descri = new string[] { "País: ", "Empresa: ", "Producto: ", "DV: " };
            foreach (var item in lp)
            {
                item.EnumeraPorEAN13 = true;
                int c = 0;
                foreach (var s in item)
                {                   
                    textBox1.Text += $"{descri[c]}: {s.ToString()}   ";
                    c++;
                }
                textBox1.Text += $"{Environment.NewLine}";
            }
        }
    }

    public class Producto : System.Collections.IEnumerable
    {

        public string Codigo { get; set; }

        public string Descripción { get; set; }
        public bool EnumeraPorEAN13 { get; set; }
        public IEnumerator GetEnumerator()
        {
            System.Collections.IEnumerator ie = new Enumerador_EAN13(this);
            if (!EnumeraPorEAN13) ie = new Enumerador_Propiedades(this);
            return ie;
        }

       
    }
}
