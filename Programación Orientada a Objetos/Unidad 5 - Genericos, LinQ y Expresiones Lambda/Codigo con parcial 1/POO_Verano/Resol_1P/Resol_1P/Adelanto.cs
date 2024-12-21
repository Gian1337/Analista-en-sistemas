using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public class Adelanto
    {
        Empleado beneficiario;
        public string Codigo { get; set; }
        public DateTime FechaOtorgado { get; set; }
        public decimal Importe { get; set; }
        public decimal Beneficio { get; set; }
        public decimal Pago { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Empleado RetornaBeneficiario() { return beneficiario; }
        public void CargaBeneficiario(Empleado pBeneficiario) { beneficiario=pBeneficiario; }

    }
}
