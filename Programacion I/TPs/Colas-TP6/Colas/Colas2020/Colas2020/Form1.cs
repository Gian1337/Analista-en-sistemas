using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas2020
{
    public partial class Form1 : Form
    {

        Cola miCola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre de nodo válido");
            }
            else
            {
                Nodo unNuevoNuevo = new Nodo();
                unNuevoNuevo.Nombre = txtNombreNodo.Text;
                miCola.Encolar(unNuevoNuevo);
                MostrarCola();
                txtNombreNodo.Text = "";
                txtNombreNodo.Focus();
            }
        }

        


        private void MostrarCola()
        {
            lstColaF.Items.Clear();
            lstColaM.Items.Clear();
            MostrarNodoEnPantallaF(miCola.InicioF);
            MostrarNodoEnPantallaM(miCola.InicioM);
        }


        private void MostrarNodoEnPantallaF(Nodo unNodo)
        {

            if (unNodo != null)
            {
                lstColaF.Items.Add(unNodo.Nombre);

                if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantallaF(unNodo.Siguiente);
                }
              
            }

          
        }

        private void MostrarNodoEnPantallaM(Nodo unNodo)
        {

            if (unNodo != null)
            {
                lstColaM.Items.Add(unNodo.Nombre);

                if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantallaM(unNodo.Siguiente);
                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
