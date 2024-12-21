using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas2020
{
    class Cola
    {
        Nodo _inicioF;
        Nodo _inicioM;

        public void Encolar(Nodo unNodo)
        {
           
            if (unNodo.Nombre.Substring(0,1)=="F" || unNodo.Nombre.Substring(0, 1) == "f")
            {
          
                if (_inicioF == null)
                {
                    _inicioF = unNodo;
                }
                else
                {
                    Nodo aux = BuscarUltimo(_inicioF);
                    aux.Siguiente = unNodo;
                }
            }
            else
            {
                if (_inicioM == null)
                {
                    _inicioM = unNodo;
                }
                else
                {
                    Nodo aux = BuscarUltimo(_inicioM);
                    aux.Siguiente = unNodo;
                }

            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }
       

        public Nodo InicioF
        {
            get
            {
                return _inicioF;
            }
        }

        public Nodo InicioM
        {
            get
            {
                return _inicioM;
            }
        }


        public bool Vacia()
        {
            return (_inicioF == null);
        }

    }
}
