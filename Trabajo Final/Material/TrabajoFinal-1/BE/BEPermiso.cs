using System;
using System.Collections.Generic;

namespace BE
{
    // Permisos individuales
    public class BEPermiso : BEComponente
    {

        public BEPermiso(string nombre) : base(nombre) { }

        public override void AgregarHijo(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }

        public override IList<BEComponente> ObtenerHijos()
        {
            throw new NotImplementedException();
        }
    }
}
