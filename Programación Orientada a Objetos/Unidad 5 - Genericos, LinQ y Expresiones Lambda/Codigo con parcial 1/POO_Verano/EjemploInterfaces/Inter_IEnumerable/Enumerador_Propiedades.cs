using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IEnumerable
{
    public class Enumerador_Propiedades : System.Collections.IEnumerator
    {
        string s = "";
        int c = 0;
        Producto p = null;
        public Enumerador_Propiedades(Producto pProducto)
        {
            p = pProducto;
        }

        public object Current => s;

        public bool MoveNext()
        {
            bool rta = true;
            if(c<2)
            {
                if (c == 0)
                { s = p.Codigo; }
                else { s = p.Descripción; }
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
