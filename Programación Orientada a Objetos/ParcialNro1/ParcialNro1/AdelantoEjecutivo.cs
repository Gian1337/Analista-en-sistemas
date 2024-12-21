using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialNro1
{
    public class AdelantoEjecutivo : Adelanto
    {
        public decimal Porcentaje { get; set; } = 1.0M;

        public override decimal CalcularBeneficio(decimal pImporte)
        {
            return pImporte * Porcentaje / 100;
        }
    }
}
