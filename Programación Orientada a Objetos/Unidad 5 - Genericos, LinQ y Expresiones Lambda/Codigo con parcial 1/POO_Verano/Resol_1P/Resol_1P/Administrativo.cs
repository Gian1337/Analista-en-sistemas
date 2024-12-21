using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public class Administrativo : Empleado
    {
        public event EventHandler<DatosPagoerroneoEventArgs> PagoErroneo;
        public override void Pagar(Adelanto pAdelanto, decimal pImporte, DateTime pFechaDevolucion)
        {
            decimal auxBeneficio = pAdelanto.Importe * 0.05m;
            if (pAdelanto.Importe - auxBeneficio == pImporte)
            {
                pAdelanto.Beneficio = auxBeneficio;
                pAdelanto.FechaDevolucion = pFechaDevolucion;
                pAdelanto.Pago = pImporte;
            }
            else
            {
                PagoErroneo?.Invoke(this, new DatosPagoerroneoEventArgs(pAdelanto.Importe - auxBeneficio, pImporte));
            }
        }
    }
}
