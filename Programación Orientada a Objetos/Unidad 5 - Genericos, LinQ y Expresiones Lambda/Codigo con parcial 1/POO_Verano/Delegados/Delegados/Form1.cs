using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate string MiPrimerDelegado(string pTexto);
        public delegate void MiSegundoDelegado(string pTexto);
        MiPrimerDelegado mpd;
        MiSegundoDelegado msd;
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(mpd("Hola Mundo !!!"));
        }

        private string Mayuscula(string pTexto) { return pTexto.ToUpper(); }
        private string Minuscula(string pTexto) { return pTexto.ToLower(); }
        private void MayusculaImprime(string pTexto) { MessageBox.Show(pTexto.ToUpper()); }
        private void MinusculaImprime(string pTexto) { MessageBox.Show(pTexto.ToLower()); }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            mpd = Mayuscula;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            mpd = Minuscula;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mpd = Mayuscula;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msd = null;
            msd += MayusculaImprime;
            msd += MinusculaImprime;
            msd("Prueba de doble suscripción !!!");
            msd = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            msd = null;
            for(int x=0;x<numericUpDown1.Value;x++)
                { msd += MayusculaImprime; }
            for (int x = 0; x < numericUpDown2.Value; x++)
            { msd += MinusculaImprime; }
            if (msd!=null) msd("Programación Orientada a Objetos !!!");
            msd = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcesadorDeTexto pt = new ProcesadorDeTexto(){Texto="Prueba de delegado !!!" };
            pt.Ejecuta(mpd);
        }
    }

    public class ProcesadorDeTexto
    {
        public string Texto { get; set; }
        public void Ejecuta(Form1.MiPrimerDelegado pDelegado)
        {
            MessageBox.Show(pDelegado(Texto));
        }
    }
}
