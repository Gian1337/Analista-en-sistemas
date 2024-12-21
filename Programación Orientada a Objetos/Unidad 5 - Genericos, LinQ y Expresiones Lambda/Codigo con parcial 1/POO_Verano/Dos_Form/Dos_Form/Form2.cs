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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string s;
        private void Form2_Load(object sender, EventArgs e)
        {
            Form2.CheckForIllegalCrossThreadCalls = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            s = textBox1.Text;
            if (e.KeyChar == 13) this.Close();
        }
    }
}
