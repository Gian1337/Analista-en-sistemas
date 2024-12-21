using System;

namespace BE
{
    public class BEBitacora : Entidad
    {
        public DateTime Fecha { get; set; }
        public string Evento { get; set; }
        public BEEmpleado UsuarioEmpleado { get; set; }
        public override string ToString()
        {
            return Fecha.ToString() + " " + Evento + " " + UsuarioEmpleado.ToString();
        }
    }
}
