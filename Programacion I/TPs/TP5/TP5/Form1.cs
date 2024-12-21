using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        Pila_uno Primera_Pila = new Pila_uno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNum_Click(object sender, EventArgs e)
        {
            Nodo_uno nuevo_Nodo = new Nodo_uno();
            nuevo_Nodo.Numero = txtNum.Text;

            Primera_Pila.Apilar(nuevo_Nodo);
            MostrarStack();
        }

        void MostrarStack()
        {
            lstMostrarNum.Items.Clear();

            if(Primera_Pila.Tope() != null)
            {
                MostrarNodo(Primera_Pila.Tope());
            }
            
        }

        void MostrarNodo(Nodo_uno Un_Nodo)
        {
            lstMostrarNum.Items.Add(Un_Nodo.Numero);

            if (Un_Nodo.Siguiente != null)
            {
                MostrarNodo(Un_Nodo.Siguiente);
            }
        }
    }
}
