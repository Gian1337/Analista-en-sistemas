using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECalzado : BEProducto
    {
        #region Propiedades

        public string Material { get; set; }

        public int Talle { get; set; }
        #endregion
    }
}
