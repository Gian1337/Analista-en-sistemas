using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLProducto : IGestor<BEProducto>
    {
        public BLLProducto()
        {
            oMPPProducto = new MPPProducto();
        }
        MPPProducto oMPPProducto;
        public bool Borrar(BEProducto oBEProducto)
        {
            return oMPPProducto.Borrar(oBEProducto);
        }

        public bool Guardar(BEProducto oBEProducto)
        {
            return oMPPProducto.Guardar(oBEProducto);
        }

        public List<BEProducto> ListarTodo()
        {
            return oMPPProducto.ListarTodo();
        }
        public List<BEProducto> ListaProductosPorCantidadVendida()
        {
            return oMPPProducto.ListaProductosPorCantidadVendida();
        }
    }
}
