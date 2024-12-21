using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    public class CabeceraVista
    {
        public CabeceraVista() { }
        public CabeceraVista(string pTipo, int pPuntoVenta, int pNumero, string pCliente, decimal pTotal)
        { Tipo = pTipo; PuntoVenta = pPuntoVenta; Numero = pNumero; Cliente = pCliente;Total = pTotal; }
        public string Tipo { get; set; }
        public int PuntoVenta { get; set; }
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }

        public List<CabeceraVista> FormateaVistaListaCabecera(List<Factura> pFacturas)
        {
            List<CabeceraVista> cv = new List<CabeceraVista>();
            foreach (Factura f in pFacturas)
            {
                cv.Add(new CabeceraVista(f.RetornaCabecera.Tipo, f.RetornaCabecera.PuntoVenta, f.RetornaCabecera.Numero, f.RetornaCabecera.Cliente, f.Total()));
            }

            return cv;
        
        }

    }
}
