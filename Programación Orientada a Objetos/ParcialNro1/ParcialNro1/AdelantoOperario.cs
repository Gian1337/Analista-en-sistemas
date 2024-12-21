using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcialNro1
{
    public class AdelantoOperario : Adelanto
    {
        public decimal Porcentaje { get; set; } = 10.0M;

        public override decimal CalcularBeneficio(decimal pImporte)
        {
            return pImporte * Porcentaje / 100;
        }
    }
}
