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

namespace Inter_IComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            p = new List<Persona>();
        }
        List<Persona> p;
        private void Form1_Load(object sender, EventArgs e)
        {
            p.AddRange(new Persona[] { new Persona() { Nombre = "Juan", Apellido = "Fernandez", Edad = 50 },
                                       new Persona() { Nombre = "Analía  ", Apellido = "Garcia", Edad = 55 },
                                       new Persona() { Nombre = "Pedro", Apellido = "Alvarez", Edad = 22 },
                                       new Persona() { Nombre = "Cecilia", Apellido = "Gonzalez", Edad = 30 },});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.ToList();
            textBox1.Clear();
            Persona.NombreASC pna = new Persona.NombreASC();
            pna.Compara += MuestraCompara;
            p.Sort(pna);
            pna.Compara -= MuestraCompara;

            dataGridView2.DataSource = p.ToList();
            p.Sort(new Persona.NombreDESC());
            dataGridView3.DataSource = p.ToList();
            p.Sort(new Persona.ApellidoASC());
            dataGridView4.DataSource = p.ToList();
            p.Sort(new Persona.ApellidoDESC());
            dataGridView5.DataSource = p.ToList();
            p.Sort(new Persona.EdadASC());
            dataGridView6.DataSource = p.ToList();
            p.Sort(new Persona.EdadDESC());
            dataGridView7.DataSource = p.ToList();
        }
        private void MuestraCompara(object sender, Persona.ComparaEventArgs e)
        {
            textBox1.Text += $"Valor: {e.ValorRetornado}{Constants.vbTab}- X: {e.PersonaX.ToString()}{Constants.vbTab}Compara con Y: {e.PersonaY.ToString()}{Environment.NewLine}";
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} {Edad}";
        }
        public class NombreASC : IComparer<Persona>
        {
            public event EventHandler<ComparaEventArgs> Compara;
            public int Compare(Persona x, Persona y)
            {
                int rdo=string.Compare(x.Nombre,y.Nombre);
                Compara?.Invoke(this, new ComparaEventArgs(x, y,rdo));
                return rdo;
            }
           
        }
        public class NombreDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Nombre, y.Nombre) * -1;
            }
        }
        public class ApellidoASC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Apellido, y.Apellido);
            }
        }
        public class ApellidoDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Apellido, y.Apellido) * -1;
            }
        }
        public class EdadASC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                int rdo = 0;
                if (x.Edad < y.Edad) rdo = -1;
                if (x.Edad > y.Edad) rdo = 1;
                return rdo;
            }
        }
        public class EdadDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                int rdo = 0;
                if (x.Edad < y.Edad) rdo = 1;
                if (x.Edad > y.Edad) rdo = -1;
                return rdo;
            }
        }
        public class ComparaEventArgs : EventArgs
        {
            Persona px,py;
            int v;
            public ComparaEventArgs(Persona pPX, Persona pPY,int pV) { px = pPX;py= pPY; v = pV; }
            public Persona PersonaX { get { return px; } }
            public Persona PersonaY { get { return py; } }
            public int ValorRetornado { get { return v; } }
        }
    }
}
