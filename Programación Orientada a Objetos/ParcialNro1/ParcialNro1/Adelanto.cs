using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialNro1
{
    public abstract class Adelanto
    {
        private string codigo;
        private DateTime fechaOtorgamiento;
        private DateTime? fechaDevolucion;
        public string Codigo
        {
            get { return codigo; }
            set
            {
                //codigo = (value.Length == 8 &&
                //          value.Substring(0, 4).All(char.IsDigit) &&
                //          value.Substring(4, 4).All(char.IsLetter) &&
                //          !value.Equals(codigo))
                //          ? value
                //          : throw new ArgumentException("El código de adelanto no es válido o ya existe.")

                codigo = value;
            }
        }

        public DateTime FechaOtorgamiento
        {
            get { return fechaOtorgamiento; }
            set
            {
                fechaOtorgamiento = value;
            }
        }

        public DateTime? FechaDevolucion
        {
            get { return fechaDevolucion; }
            set
            {
                if (value == null || value > fechaOtorgamiento)
                {
                    fechaDevolucion = value;
                }
                else
                {
                    throw new ArgumentException("La fecha de devolución no puede ser anterior a la fecha de otorgamiento.");
                }
            }
        }

        public decimal Importe { get; set; }
        public decimal ImporteAbonado { get; set; }

        public decimal Beneficio { get; set; }

        public decimal SaldoAdeudado { get; set; }

        public abstract decimal CalcularBeneficio(decimal pImporte);


    }
}
