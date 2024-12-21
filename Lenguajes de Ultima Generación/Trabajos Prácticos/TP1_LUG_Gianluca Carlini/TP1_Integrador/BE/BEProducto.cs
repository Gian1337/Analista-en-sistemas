using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProducto : Entidad
    {
        #region Propiedades
        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }

        public BEProveedor Proveedor { get; set; }

        #endregion
    }
}
