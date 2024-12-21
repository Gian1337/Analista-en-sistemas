using System;

namespace BE
{
    public class BEEntrega : Entidad
    {
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public BEPedido Pedido { get; set; }
    }
}
