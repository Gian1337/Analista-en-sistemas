using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLPedidoMaterial : IGestor<BEPedidoMaterial>
    {
        public BLLPedidoMaterial()
        {
            oMPPPedidoMaterial = new MPPPedidoMaterial();
        }
        MPPPedidoMaterial oMPPPedidoMaterial;
        public bool Borrar(BEPedidoMaterial oBEPedidoMaterial)
        {
            return oMPPPedidoMaterial.Borrar(oBEPedidoMaterial);
        }

        public bool Guardar(BEPedidoMaterial oBEPedidoMaterial)
        {
            return oMPPPedidoMaterial.Guardar(oBEPedidoMaterial);
        }

        public List<BEPedidoMaterial> ListarTodo()
        {
            return oMPPPedidoMaterial.ListarTodo();
        }
        public void FinalizarPedidoMaterial(BEPedidoMaterial oBEPedidoMaterial)
        {
            oMPPPedidoMaterial.FinalizarPedidoMaterial(oBEPedidoMaterial);
        }
    }
}
