using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public class Adelanto
    {
        public string Codigo { get; set; }
        public DateTime FechaOtorgado { get; set; }
        public decimal Importe { get; set; }
        public decimal Beneficio { get; set; }
        public decimal Pago { get; set; }
        public DateTime FechaDevolucion { get; set; }

    }
}
