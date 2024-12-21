using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Alumno> la;
        private void Form1_Load(object sender, EventArgs e)
        {
            la = new List<Alumno>();
            la.AddRange(new Alumno[] { new Alumno() {Legajo=1,Nombre="Ana",Apellido="Garcia" },
                                      new Alumno() {Legajo=2,Nombre="Martin",Apellido="Martinez" },
                                      new Alumno() {Legajo=3,Nombre="Cecilia",Apellido="Fernandez" },
                                      new Alumno() {Legajo=4,Nombre="Pedro",Apellido="Alvarez" },} );
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<Alumno> q;
            if (comboBox1.SelectedIndex == 0)
            { q = from alu in la where alu.Legajo < numericUpDown1.Value select alu; }
            else if(comboBox1.SelectedIndex == 1)
            { q = from alu in la where alu.Legajo == numericUpDown1.Value select alu; }
            else { q = from alu in la where alu.Legajo > numericUpDown1.Value select alu; }
            
            dataGridView1.DataSource = null;dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = (from alu in la select new { Datos = $"{alu.Apellido}, {alu.Nombre}" }).ToList();
        }
    }

    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
