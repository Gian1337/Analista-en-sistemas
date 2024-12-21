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

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona persona;
        private void Form1_Load(object sender, EventArgs e)
        {
            persona = new Persona();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Persona()
            {

            }

            public Persona(string nombre, int edad) : this()
            {
                Nombre = nombre;
                Edad = edad;
            }
            ~Persona()
            {
                MessageBox.Show("El ciclo de vida ha finalizado");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = Interaction.InputBox("Ingrese un nombre");
            persona.Edad = Convert.ToInt32(Interaction.InputBox("Ingrese la edad"));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
