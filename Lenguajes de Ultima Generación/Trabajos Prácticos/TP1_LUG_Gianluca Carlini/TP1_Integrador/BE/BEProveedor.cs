using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProveedor : Entidad
    {

        #region Propiedades

        public string RazonSocial { get; set; }

        public string CUIT { get; set; }
        #endregion

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
