using System.Collections.Generic;

namespace BE
{
    public class BERol : BEComponente
    {
        private List<BEComponente> _Permisos;

        public BERol(string nombre) : base(nombre)
        {
            _Permisos = new List<BEComponente>();
        }

        public override void AgregarHijo(BEComponente oBEComponente)
        {
            _Permisos.Add(oBEComponente);
        }

        public override IList<BEComponente> ObtenerHijos()
        {
            return _Permisos;
        }
    }
}
