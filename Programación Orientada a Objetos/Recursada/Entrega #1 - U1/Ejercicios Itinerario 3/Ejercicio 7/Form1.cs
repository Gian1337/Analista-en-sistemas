using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
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

        public class Persona
        {
            private decimal dni;

            public decimal DNI
            {
                get { return dni; }
            }

            private int edad;

            public int Edad
            { 
                set { edad = value; }
            }

            public int Nombre { get; set; }


            private string _nombre;

            public string NombreCompleto
            {
                get { return _nombre; }
                set
                {
                    string[] partes = value.Split(' ');
                    _nombre = partes[0];
                }
            }
        }
    }
}
