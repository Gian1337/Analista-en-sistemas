using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6
{
     class Cola
    {
        Nadadores _inicio;
        public void Encolar(Nadadores unNadador)
        {
            if(_inicio == null)
            {
                _inicio = unNadador;
            }
            else
            {
                Nadadores auxiliar = Buscar_Ultimo(_inicio);
                auxiliar.Siguiente = unNadador;
            }
        }

        private Nadadores Buscar_Ultimo(Nadadores unNadador) //RECURSION
        {
            if(unNadador.Siguiente == null)
            {
                return unNadador;
            }
            else
            {
                return Buscar_Ultimo(unNadador.Siguiente);
            }

        }

        public Nadadores Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public void Desencolar()
        {
                _inicio = _inicio.Siguiente;
        }


        public bool Vacio()
        {
            return (_inicio == null);
        }
        
    }
}
