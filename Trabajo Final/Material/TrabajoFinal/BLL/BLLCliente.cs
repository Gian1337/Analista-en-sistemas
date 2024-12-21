using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLCliente : IGestor<BECliente>
    {
        public BLLCliente()
        {
            oMPPCliente = new MPPCliente();
        }
        MPPCliente oMPPCliente;
        public bool Borrar(BECliente oBECliente)
        {
            return oMPPCliente.Borrar(oBECliente);
        }

        public bool Guardar(BECliente oBECliente)
        {
            return oMPPCliente.Guardar(oBECliente);
        }

        public List<BECliente> ListarTodo()
        {
            return oMPPCliente.ListarTodo();
        }

    }
}
