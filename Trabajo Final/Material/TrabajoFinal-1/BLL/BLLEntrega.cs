using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLEntrega : IGestor<BEEntrega>
    {
        public BLLEntrega()
        {
            oMPPEntrega = new MPPEntrega();
        }
        MPPEntrega oMPPEntrega;
        public bool Borrar(BEEntrega oBEEntrega)
        {
            return oMPPEntrega.Borrar(oBEEntrega);
        }

        public bool Guardar(BEEntrega oBEEntrega)
        {
            return oMPPEntrega.Guardar(oBEEntrega);
        }

        public List<BEEntrega> ListarTodo()
        {
            return oMPPEntrega.ListarTodo();
        }
        public BEEntrega BuscarOrdenEntregaPorCodigo(string codigo)
        {
            return oMPPEntrega.BuscarOrdenEntregaPorCodigo(codigo);
        }
        public void CumplirOrdenEntrega(BEEntrega oBEEntrega)
        {
            oMPPEntrega.CumplirOrdenEntrega(oBEEntrega);
        }

    }
}
