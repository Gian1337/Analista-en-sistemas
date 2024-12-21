using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoVirtual
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
            TituloDr tr = new TituloDr("Ana");
            tr.MuestraTitulo();

            TituloDr tr2 = new TituloDr("Pedro","Garcia");
            tr2.MuestraTitulo();

            TituloAb tr3 = new TituloAb("María", "1234");
            tr3.MuestraTitulo();

            TituloGeneral tr4 = new TituloGeneral("Pedro");
            tr4.MuestraTitulo();
        }
    }

    public abstract class Titulo
    {
        public Titulo(string pNombre) { Nombre = pNombre; }
        public string Nombre { get; set; }
        public virtual void MuestraTitulo()
        {
            MessageBox.Show($"{Nombre}");
        }
    }
    public class TituloDr : Titulo
    {
        public string Apellido { get; set; }
        public TituloDr(string pNombre) : base(pNombre)
        {

        }
        public TituloDr(string pNombre, string pApellido) : this(pNombre)
        {
            Apellido = pApellido;           
        }

        public override void MuestraTitulo()
        {
            MessageBox.Show($"Dr {Nombre} {Apellido}");

        }
    }
    public class TituloAb : Titulo
    {
        public string Matricula { get; set; }
        public TituloAb(string pNombre) : base(pNombre)
        {

        }
        public TituloAb(string pNombre, string pMatricula) : this(pNombre)
        {
            Matricula = pMatricula;
        }

        public override void MuestraTitulo()
        {
            MessageBox.Show($"Abogado/a: {Nombre} - Matrícula: {Matricula}");

        }
    }
    public class TituloGeneral : Titulo
    {
      
        public TituloGeneral(string pNombre) : base(pNombre)
        {

        }
           
    }
}
