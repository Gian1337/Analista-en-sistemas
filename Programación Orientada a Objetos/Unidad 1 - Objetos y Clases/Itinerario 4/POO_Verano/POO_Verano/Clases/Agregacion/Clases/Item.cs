using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Item
    {

        public Item(int pCodigo, string pDescripcion, int pCantidad, decimal pPrecioUnitario)
        { Codigo = pCodigo;Descripcion = pDescripcion;Cantidad = pCantidad;PrecioUnitario = pPrecioUnitario; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

    }
}
