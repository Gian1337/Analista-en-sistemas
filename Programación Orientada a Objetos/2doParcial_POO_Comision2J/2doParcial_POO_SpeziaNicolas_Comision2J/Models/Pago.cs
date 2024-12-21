using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    sealed class Pago
    {
        public event EventHandler<PagoMayorEventArgs> PagoMayor; //definicion del evento

        private decimal total;
        private Cliente cliente;
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPago { get; set; }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public decimal Importe_Total // propiedad que manejará valores totales con intereses acumulados
        {
            get
            {
                return total;
            }
            set
            {
                this.total = value;
                if (value > 10000) PagoMayor?.Invoke(this, new PagoMayorEventArgs(this.Importe_Total)); //desencadenamiento del evento   
            }
        }

        #region Constructores
        public Pago() { }

        public Pago(int pCodigo, string pNombre, DateTime pFechaDePago, decimal pImporte, string pCliente)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            FechaPago = pFechaDePago;
            Importe_Total = pImporte;
            Cliente.Nombre = pCliente;
        }
        #endregion

        #region Implementación de INTERFAZ DE ORDENAMIENTO DE IMPORTES DE PAGOS
        public class PagoASC : IComparer<Pago> //Implementacion de interfaz IComparer para ordenamiento ascendente
        {
            public int Compare(Pago x, Pago y)
            {
                int rdo = 0;
                if (x.Importe_Total > y.Importe_Total) rdo = 1;
                if (y.Importe_Total > x.Importe_Total) rdo = -1;
                return rdo;
            }
        }

        public class PagoDESC : IComparer<Pago> //Implementacion de interfaz IComparer para ordenamiento Descendente
        {
            public int Compare(Pago x, Pago y)
            {
                int rdo = 0;
                if (x.Importe_Total > y.Importe_Total) rdo = -1;
                if (y.Importe_Total > x.Importe_Total) rdo = 1;
                return rdo;
            }
        }
        #endregion
    }
    public class PagoMayorEventArgs : EventArgs //Creacion de clase para manejar el EventArgs personalizado
    {
        private decimal pago;
        public decimal Pago_Total { get { return this.pago; } }

        public PagoMayorEventArgs(decimal pPago)
        {
            this.pago = pPago;
        }
    }
}


