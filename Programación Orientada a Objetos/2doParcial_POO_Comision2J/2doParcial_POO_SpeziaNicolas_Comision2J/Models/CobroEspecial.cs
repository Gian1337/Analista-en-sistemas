using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    sealed class CobroEspecial : Cobro
    {
        public CobroEspecial() : base() { }

        public CobroEspecial(int pCodigo, string pNombre, DateTime pVencimiento, decimal pImporte, string pCliente) : base(pCodigo, pNombre, pVencimiento, pImporte) { }

        public override decimal ValorInteres(decimal valor, int pDiasMoratoria) 
        {
            decimal interes = 0;
            interes = pDiasMoratoria * 1000;
            valor = interes;
            return interes;
        }
    }
}
