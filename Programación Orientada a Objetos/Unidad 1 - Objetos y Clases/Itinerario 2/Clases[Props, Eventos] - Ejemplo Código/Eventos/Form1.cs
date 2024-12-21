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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Termostato T;
        private void button1_Click(object sender, EventArgs e)
        {
            T = new Termostato();
            // 3. Suscripción al evento
            T.Peligro += AltaTemperatura;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T.Temperatura = int.Parse(Interaction.InputBox("Ingrese la temperatura: "));
        }

        private void AltaTemperatura(object sender, EventArgs e)
        {
            MessageBox.Show("Cuidado Alta Temperatura que supera 100 grados !!!");
        }
    }

    public class Termostato
    {
        private int temperatura;

        // 1. Declaración del evento
        public event EventHandler Peligro;

        public int Temperatura
        {
            get { return temperatura; }
            set { 
                    temperatura = value;
                // 2. Desencadenamiento del evento cuando la temperatura ingresada supere 100 grados
                if (Temperatura > 100) Peligro?.Invoke(null, null);    
            }
        }


    }


}
