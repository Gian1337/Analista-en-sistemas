using ABS;
using BE;
using System.Collections.Generic;

namespace BLL
{
    public abstract class BLLComponente : IGestor<BEComponente>
    {
        public abstract bool Borrar(BEComponente obj);
        public abstract bool Guardar(BEComponente obj);
        public abstract List<BEComponente> ListarTodo();
        public abstract IList<BEComponente> ObtenerHijos(BEComponente oBEComponente);
        public abstract void AgregarHijo(BEComponente oBEComponente);
    }
}
