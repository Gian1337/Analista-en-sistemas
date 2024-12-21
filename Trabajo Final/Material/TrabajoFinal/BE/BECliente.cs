namespace BE
{
    public class BECliente : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string DireccionEntrega { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string RazonSocial { get; set; }
    }
}
