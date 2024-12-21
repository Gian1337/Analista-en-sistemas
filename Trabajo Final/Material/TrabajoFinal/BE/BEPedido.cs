using System;
using System.Collections.Generic;

namespace BE
{
    public class BEPedido : Entidad
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double ImporteTotal { get; set; }
        public BECliente Cliente = new BECliente();
        public BEFacturaCompra FacturaCompra = new BEFacturaCompra();

        public BEEstado Estado = new BEEstado();
        public List<BEProducto> listaProductos = new List<BEProducto>();
    }
}
