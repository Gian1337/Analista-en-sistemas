using System;
using System.Collections.Generic;

namespace BE
{
    public class BEOrdenProduccion : Entidad
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; }
        public List<string> Tareas = new List<string>();
        public BEEmpleado Empleado = new BEEmpleado();
        public BEPedidoMaterial PedidoMaterial = new BEPedidoMaterial();
        public BEProducto Producto { get; set; }
    }
}
