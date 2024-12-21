using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dos_Form
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El mensaje cargado en el formulario 2 es: {f2.s}");
        }
    }
}
