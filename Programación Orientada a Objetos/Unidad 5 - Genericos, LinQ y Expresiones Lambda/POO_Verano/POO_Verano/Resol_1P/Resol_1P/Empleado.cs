using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public abstract class Empleado
    {
       
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo { get; set; }

        public abstract void Pagar(Adelanto pAdelanto, decimal pImporte, DateTime pFechaDevolucion);


    }
}
