namespace BE
{
    public class BEProducto : Entidad
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Material { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

    }
}
