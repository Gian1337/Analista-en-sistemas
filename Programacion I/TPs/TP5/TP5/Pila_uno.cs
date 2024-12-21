using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    internal class Pila_uno
    {
        Nodo_uno top;

        public Nodo_uno Tope()
        {
            return top;
        }
        public void Apilar(Nodo_uno Un_Nodo)
        {
            if(top == null)
            {
                top = Un_Nodo;
            }
            else
            {
                Nodo_uno aux = top;
                top = Un_Nodo;
                top.Siguiente = aux; 
            }
        }
    }
}
