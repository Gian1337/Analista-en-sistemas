using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    sealed class CobroNormal : Cobro
    {
        public CobroNormal() : base() { }

        public CobroNormal(int pCodigo, string pNombre, DateTime pVencimiento, decimal pImporte, string pCliente) : base(pCodigo, pNombre, pVencimiento, pImporte) { }

        public override decimal ValorInteres(decimal valor, int pDiasMoratoria)
        {
            decimal interes = 0;
            decimal subtotal = 0;

            subtotal = valor * 1 / 100;
            interes = subtotal * pDiasMoratoria;
            return interes;
        }
    }
}
