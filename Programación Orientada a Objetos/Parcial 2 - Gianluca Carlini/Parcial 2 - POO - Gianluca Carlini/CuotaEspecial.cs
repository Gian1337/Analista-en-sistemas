using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___POO___Gianluca_Carlini
{
    sealed class CuotaEspecial : Cuota
    {
        
        public override decimal ObtenerIntereses(decimal valor, int diasExcedidos)
        {
            decimal interes = 0;
            
            interes = 100 * diasExcedidos;
            return interes;
        }
    }
}
