using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLOrdenProduccion : IGestor<BEOrdenProduccion>
    {
        public BLLOrdenProduccion()
        {
            oMPPOrdenProduccion = new MPPOrdenProduccion();
        }
        MPPOrdenProduccion oMPPOrdenProduccion;
        public bool Borrar(BEOrdenProduccion oBEOrdenProduccion)
        {
            return oMPPOrdenProduccion.Borrar(oBEOrdenProduccion);
        }

        public bool Guardar(BEOrdenProduccion oBEOrdenProduccion)
        {
            return oMPPOrdenProduccion.Guardar(oBEOrdenProduccion);
        }

        public List<BEOrdenProduccion> ListarTodo()
        {
            return oMPPOrdenProduccion.ListarTodo();
        }
        public bool CalcularMateriaPrima(BEOrdenProduccion oBEOrdenProduccion)
        {
            return oMPPOrdenProduccion.CalcularMateriaPrima(oBEOrdenProduccion);
        }
        public void AsignarOrdenEmpleado(BEOrdenProduccion oBEOrdenProduccion)
        {
            oMPPOrdenProduccion.AsignarEmpleadoOrdenProduccion(oBEOrdenProduccion);
        }
        public void FinalizarOrdenProduccion(BEOrdenProduccion oBEOrdenProduccion)
        {
            oMPPOrdenProduccion.FinalizarOrdenProduccion(oBEOrdenProduccion);
        }
    }
}
