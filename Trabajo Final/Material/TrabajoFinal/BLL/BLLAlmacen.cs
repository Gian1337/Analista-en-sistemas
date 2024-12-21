using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLAlmacen : IGestor<BEAlmacen>
    {
        public BLLAlmacen()
        {
            oMPPAlmacen = new MPPAlmacen();
        }
        MPPAlmacen oMPPAlmacen;
        public bool Borrar(BEAlmacen oBEAlmacen)
        {
            return oMPPAlmacen.Borrar(oBEAlmacen);
        }

        public bool Guardar(BEAlmacen oBEAlmacen)
        {
            return oMPPAlmacen.Guardar(oBEAlmacen);
        }

        public List<BEAlmacen> ListarTodo()
        {
            return oMPPAlmacen.ListarTodo();
        }
        public void ActualizarStockAlmacen(BEProducto oBEProducto)
        {
            oMPPAlmacen.ActualizarStockAlmacen(oBEProducto);
        }

    }
}
