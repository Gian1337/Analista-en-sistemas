using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Itinerario_3
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
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public Persona()
            {

            }

            public Persona(string nombre, string apellido) : this()
            {
                Nombre = nombre;
                Apellido = apellido;
            }

            public void Caminar()
            {
                MessageBox.Show("Camino como una persona");
            }

            public void Comer()
            {
                MessageBox.Show("Como como una persona");
            }
        }
    }
}
