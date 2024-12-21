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

namespace Eventos
{
    public partial class Form1 : Form
    {
        Termostato T,T2;
        Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T = new Termostato("T001");
            T2 = new Termostato("T002");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 3. Suscripción al evento
            T.Peligro += AltaTemperatura;
            T2.Peligro += AltaTemperatura;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if(r.Next(2)==0) T.Temperatura = int.Parse(Interaction.InputBox("Ingrese la temperatura: "));
            else T2.Temperatura = int.Parse(Interaction.InputBox("Ingrese la temperatura: "));
        }

        private void AltaTemperatura(object sender, DatosPeligroEventArgs e)
        {
            MessageBox.Show("Cuidado Alta Temperatura que supera 100 grados !!!");
        }
        private void Alarma(object sender, DatosPeligroEventArgs e)
        {
            MessageBox.Show($"La alarma en el termostato {(sender as Termostato).Nombre} está sonando !!!{Environment.NewLine}" +
                            $"La temperatura peligrosa es: {e.TemperturaPeligrosa} y el Delta es: {e.Delta}");
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T.Peligro -= AltaTemperatura;
            T2.Peligro -= AltaTemperatura;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T.Peligro += Alarma;
            T2.Peligro += Alarma;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            T.Peligro -= Alarma;
            T2.Peligro -= Alarma;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X: {e.X}  -  Y:{e.Y}  -  Botón: {e.Button}";
        }

        private void CambioColor(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            
        }

    }

    public class Termostato
    {
        private int temperatura;

        // 1. Declaración del evento
        public event EventHandler<DatosPeligroEventArgs> Peligro;
        public string Nombre { get; set; }
        public Termostato(string pNombre) { Nombre = pNombre; }
        public int Temperatura
        {
            get { return temperatura; }
            set { 
                    temperatura = value;
                // 2. Desencadenamiento del evento cuando la temperatura ingresada supere 100 grados
                if (Temperatura > 100) Peligro?.Invoke(this, new DatosPeligroEventArgs(Temperatura));
                // El signo de pregunta antes del Invoke reemplaza el siguiente if
                // if (Peligro != null) Peligro.Invoke(null, null);
            }
        }


    }

    public class DatosPeligroEventArgs : EventArgs
    {
        public DatosPeligroEventArgs(int pTemperaturaPeligrosa)
        {
            TemperturaPeligrosa = pTemperaturaPeligrosa;
            Delta = TemperturaPeligrosa - 100;
        }
        public int TemperturaPeligrosa { get; set; }
        public int Delta { get; set; }
    }



   

}
