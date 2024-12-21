using System;

namespace BE
{
    public class BEFacturaCompra : Entidad
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public Double Total { get; set; }
    }
}
