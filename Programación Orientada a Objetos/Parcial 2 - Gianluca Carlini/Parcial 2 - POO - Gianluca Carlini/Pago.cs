using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___POO___Gianluca_Carlini
{
    sealed class Pago
    {

        #region Propiedades
        private decimal total;
        private Socio socio;

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaPago { get; set; }

        public event EventHandler<PagoExcedenteEventArgs> PagoExcedente;
        public Socio Socio {
            get { return socio; }
            set { socio = value; } 
        }

        public decimal ImporteTotal
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
                if (value > 10000) PagoExcedente?.Invoke(this, new PagoExcedenteEventArgs(ImporteTotal));
            }
        }
        #endregion

        #region Constructor
        public Pago() { }

        public Pago(string pCodigo, DateTime pFechaPago, decimal pImporte,string pNombre ,Socio pSocio)
        {
            Codigo = pCodigo;
            FechaPago = pFechaPago;
            ImporteTotal = pImporte;
            Nombre = pNombre;
            Socio = pSocio;
        }
        #endregion

        #region Declaración de Evento
        
        public class PagoExcedenteEventArgs : EventArgs
        {
            private decimal pago;
            public decimal Pago_total { get { return pago; } }

            public PagoExcedenteEventArgs(decimal pPago)
            {
                pago = pPago;
            }
        }
        #endregion

        #region Ordenación con IComparable

        public class PagoAscendente : IComparer<Pago>
        {
            int IComparer<Pago>.Compare(Pago x, Pago y)
            {
                int resultado = 0;
                if (x.ImporteTotal > y.ImporteTotal) resultado = 1;
                if (y.ImporteTotal > x.ImporteTotal) resultado = 0;

                return resultado;
            }
        }

        public class PagoDescendente : IComparer<Pago>
        {
            int IComparer<Pago>.Compare(Pago x, Pago y)
            {
                int resultado = 0;
                if (x.ImporteTotal > y.ImporteTotal) resultado = -1;
                if (y.ImporteTotal > x.ImporteTotal) resultado = 1;

                return resultado;
            }
        }



        #endregion
    }
}
