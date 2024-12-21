using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6
{
    public partial class Form1 : Form
    {   
        Cola ColaFemenina = new Cola();
        Cola ColaMasculina = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtAgregarNad.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un nadador válido");
            }
            else if(txtAgregarNad.Text.StartsWith("f"))
            {
                Nadadores unNadadorNuevo = new Nadadores();

                unNadadorNuevo.Nombre = txtAgregarNad.Text;
                ColaFemenina.Encolar(unNadadorNuevo);
                MostrarColas();

            }
            else if (txtAgregarNad.Text.StartsWith("m"))
            {
                Nadadores otroNadadorNuevo = new Nadadores();

                otroNadadorNuevo.Nombre = txtAgregarNad.Text;
                ColaMasculina.Encolar(otroNadadorNuevo);
                MostrarColas();
            }

            /*else
            {
                Nadadores unNadadorNuevo = new Nadadores();

                unNadadorNuevo.Nombre = txtAgregarNad.Text;
                ColaFemenina.Encolar(unNadadorNuevo);
                MostrarColas();

            }
            */
        }

        //DESENCOLAR COLA FEMENINA
        private void btnDesencolarFem_Click(object sender, EventArgs e)
        {
            if (ColaFemenina.Vacio())
            {
                MessageBox.Show("Esta cola está vacía");
            }
            else
            {
                ColaFemenina.Desencolar();
                MostrarColas();
            }
        }

        //DESENCOLAR COLA MASCULINA
        private void btnDesencolarMasc_Click(object sender, EventArgs e)
        {
            if (ColaMasculina.Vacio())
            {
                MessageBox.Show("Esta cola está vacía");
            }
            else
            {
                ColaMasculina.Desencolar();
                MostrarColas();
            }
        }
        
        private void MostrarColas()
        {
            lstColaFem.Items.Clear();
            lstColaMasc.Items.Clear();

            MostrarNadadores(ColaFemenina.Inicio);
            MostrarNadadores(ColaMasculina.Inicio);
        }


        private void MostrarNadadores(Nadadores unNadador)
        {
            if(unNadador != null)
            {
                lstColaFem.Items.Add(unNadador.Nombre);
                lstColaMasc.Items.Add(unNadador.Nombre);

                if (unNadador.Siguiente != null)
                {
                    MostrarNadadores(unNadador.Siguiente);
                }
                
            }
            
        }
    }
}
