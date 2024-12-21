using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Factura
    {

        private Cabecera _cabecera;
        private List<Item> _items;
        public Factura(string pTipoCab, int pPuntoVentaCab, int pNumeroCab, string pClienteCab,
                       int pCodigoIt, string pDescripcionIt, int pCantidadIt, decimal pPrecioUnitarioIt)
        {
            _cabecera = new Cabecera(pTipoCab, pPuntoVentaCab, pNumeroCab, pClienteCab);
            _items.Add(CreaItem(pCodigoIt, pDescripcionIt, pCantidadIt, pPrecioUnitarioIt));
        }
        public void AgregarItem(int pCodigoIt, string pDescripcionIt, int pCantidadIt, decimal pPrecioUnitarioIt)
        { _items.Add(CreaItem(pCodigoIt, pDescripcionIt, pCantidadIt, pPrecioUnitarioIt)); }
        public List<Item> RetornaItems()
        {
            List<Item> _aux = new List<Item>();
            foreach(Item i in _items)
            {
                _aux.Add(new Item(i.Codigo,i.Descripcion,i.Cantidad,i.PrecioUnitario));
            }
            return _aux;
        }   
        private Item CreaItem(int pCodigoIt, string pDescripcionIt, int pCantidadIt, decimal pPrecioUnitarioIt)
        {
           return  new Item(pCodigoIt, pDescripcionIt, pCantidadIt, pPrecioUnitarioIt);
        }
        public decimal Total()
        {
            decimal _total = 0;
            foreach (Item i in _items)
            {
                _total += (i.PrecioUnitario * Convert.ToDecimal(i.Cantidad));
            }
            return _total;
        }
    ~Factura()
        {
            _cabecera = null;_items = null;  
        }

    }
}
