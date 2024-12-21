using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IEnumerable
{
    public class Enumerador_EAN13 : System.Collections.IEnumerator
    {
        string s = "";
        int c = 0;
        Producto p = null;
        int desde = 0;       
        int[] v = {3,4,5,1};
        int largo = 0;
        public Enumerador_EAN13(Producto pProducto)
        {
            p = pProducto;
        }

        public object Current => s;

        public bool MoveNext()
        {
            bool rta = true;         
            if (c <4)
            {
                //Índices del string Códifo 0 1 2 3 4 5 6 7 8 9 0 1 2
                //                          7 7 9 2 4 3 5 6 7 4 3 2 1
                largo = v[c];
                s = p.Codigo.Substring(desde, largo);
                desde += largo;
                c++;
            }         
            else { rta = false; Reset(); }
            return rta;
        }

        public void Reset()
        {
            s = "";
            c = 0;
        }
    }
}
