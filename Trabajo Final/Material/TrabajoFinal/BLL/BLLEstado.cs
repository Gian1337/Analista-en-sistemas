using ABS;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLEstado : IGestor<BEEstado>
    {
        public BLLEstado()
        {
            oMPPEstado = new MPPEstado();
        }
        MPPEstado oMPPEstado;
        public bool Borrar(BEEstado obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEEstado obj)
        {
            throw new NotImplementedException();
        }

        public List<BEEstado> ListarTodo()
        {
            return oMPPEstado.ListarTodo();
        }
        public BEEstado actualizarEstado(BEPedido oBEPedido)
        {
            return oMPPEstado.actualizarEstado(oBEPedido);
        }
    }
}
