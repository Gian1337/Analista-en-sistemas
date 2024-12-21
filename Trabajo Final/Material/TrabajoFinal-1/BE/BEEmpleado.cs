using System.Collections.Generic;

namespace BE
{
    public class BEEmpleado : Entidad
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sector { get; set; }
        public List<BEComponente> listaPermisos = new List<BEComponente>();

        public BEEmpleado() { }
        public BEEmpleado(int id, string nombreUsuario, string password, string nombre, string apellido, string sector)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Sector = sector;
        }
    }
}
