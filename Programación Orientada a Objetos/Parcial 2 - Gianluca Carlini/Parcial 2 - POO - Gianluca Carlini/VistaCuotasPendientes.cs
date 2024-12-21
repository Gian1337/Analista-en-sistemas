using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___POO___Gianluca_Carlini
{
    class VistaCuotasPendientes
    {
        List<VistaCuotasPendientes> _vistaCuotasPendientes;

        public string Codigo { get; set; }
        public DateTime FechaEmitida { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }

        public VistaCuotasPendientes()
        {
            _vistaCuotasPendientes = new List<VistaCuotasPendientes>();
        }

        public VistaCuotasPendientes(string pCodigo, DateTime pFechaEmitida, DateTime pFechaVencimiento, decimal pImporte)
        {
            Codigo = pCodigo;
            FechaEmitida = pFechaEmitida;
            FechaVencimiento = pFechaVencimiento;
            Importe = pImporte;
        }

        public List<VistaCuotasPendientes> CuotasPendientesSocios(Socio pSocio, List<Socio> Deudores)
        {
            List<VistaCuotasPendientes> aux = new List<VistaCuotasPendientes>();

            foreach (Cuota cuota in Deudores.Find(x => x.Legajo == pSocio.Legajo).listacuotas)
            {
                aux.Add(new VistaCuotasPendientes(cuota.Codigo, cuota.FechaEmitida, cuota.FechaVencimiento, cuota.Importe));
            }
            return aux;
        }
    }
}
