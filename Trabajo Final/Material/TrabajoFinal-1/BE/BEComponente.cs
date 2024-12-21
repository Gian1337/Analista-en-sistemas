using System.Collections.Generic;

namespace BE
{
    public abstract class BEComponente : Entidad
    {
        public string Nombre { get; set; }
        public bool isRol { get; set; }
        public BEComponente(string nombre)
        {
            Nombre = nombre;
        }
        public abstract IList<BEComponente> ObtenerHijos();

        public abstract void AgregarHijo(BEComponente oBEComponente);
        public override string ToString()
        {
            return Nombre;
        }
    }
}
