using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    abstract class Cobro
    {
        #region Campos y propiedades
        private Cliente cliente;
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime Vencimiento { get; set; }
        public decimal Importe { get; set; }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        #endregion

        #region Constructores
        public Cobro() { }
        public Cobro(int pCodigo, string pNombre, DateTime pVencimiento, decimal pImporte)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Vencimiento = pVencimiento;
            Importe = pImporte;
        }
        #endregion
        public void AsignarCobroCliente(Cliente pCliente) // asigna el campo cliente al que le pase por parámetro
        {
            try
            {
                if (cliente == null)
                {
                    cliente = pCliente;
                }
                else
                    throw new Exception("Ya tiene un cliente asignado este cobro");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public Cliente RetornaCliente()
        {
            return cliente;
        }
        public abstract decimal ValorInteres(decimal valor, int pDiasMoratoria); //funcion polimorfica

    }
}
