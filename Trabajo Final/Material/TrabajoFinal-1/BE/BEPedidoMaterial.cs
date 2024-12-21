using System;
using System.Collections.Generic;

namespace BE
{
    public class BEPedidoMaterial : Entidad
    {
        public DateTime Fecha { get; set; }
        public List<BEProducto> Productos = new List<BEProducto>();
    }
}
