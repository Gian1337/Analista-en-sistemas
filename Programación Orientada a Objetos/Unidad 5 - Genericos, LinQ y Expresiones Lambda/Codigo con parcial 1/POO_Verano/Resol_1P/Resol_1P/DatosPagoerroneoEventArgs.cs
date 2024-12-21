using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public class DatosPagoerroneoEventArgs
    {
        decimal importeAdeudado, importeAPagar;
        public DatosPagoerroneoEventArgs(decimal pImporteAdeudado, decimal pImporteAPagar)
        {
            importeAdeudado = pImporteAdeudado; importeAPagar = pImporteAPagar;

        }
        public decimal ImporteAdeudado { get{ return importeAdeudado; } }
        public decimal ImporteAPagar { get { return importeAPagar; } }
    }
}
