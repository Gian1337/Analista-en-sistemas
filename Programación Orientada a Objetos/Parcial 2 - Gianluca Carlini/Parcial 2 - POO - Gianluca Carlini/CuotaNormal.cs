using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___POO___Gianluca_Carlini
{
    sealed class CuotaNormal : Cuota
    {

        public override decimal ObtenerIntereses(decimal valor, int diasExcedidos)
        {
            decimal interes = 0;
            decimal total = 0;

            total = valor * (0.5m / 100);
            interes = total * diasExcedidos;
            return interes;
        }

    }
}
