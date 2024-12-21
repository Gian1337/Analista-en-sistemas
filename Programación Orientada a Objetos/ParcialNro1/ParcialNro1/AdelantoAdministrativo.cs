using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialNro1
{
    public class AdelantoAdministrativo : Adelanto
    {
        public decimal Porcentaje { get; set; } = 5.0M;

        public override decimal CalcularBeneficio(decimal pImporte)
        {
            return pImporte * Porcentaje / 100;
        }
    }
}
