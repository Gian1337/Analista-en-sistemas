using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLFacturaCompra : IGestor<BEFacturaCompra>
    {
        public BLLFacturaCompra()
        {
            oMPPFacturaCompra = new MPPFacturaCompra();
        }
        MPPFacturaCompra oMPPFacturaCompra;
        public bool Borrar(BEFacturaCompra oBEFacturaCompra)
        {
            return oMPPFacturaCompra.Borrar(oBEFacturaCompra);
        }

        public bool Guardar(BEFacturaCompra oBEFacturaCompra)
        {
            return oMPPFacturaCompra.Guardar(oBEFacturaCompra);
        }

        public List<BEFacturaCompra> ListarTodo()
        {
            return oMPPFacturaCompra.ListarTodo();
        }

    }
}
