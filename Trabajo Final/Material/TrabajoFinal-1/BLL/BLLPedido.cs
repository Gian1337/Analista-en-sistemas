using ABS;
using BE;
using MPP;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BLLPedido : IGestor<BEPedido>
    {
        public BLLPedido()
        {
            oMPPPedido = new MPPPedido();
        }
        MPPPedido oMPPPedido;
        public bool Borrar(BEPedido oBEPedido)
        {
            return oMPPPedido.Borrar(oBEPedido);
        }

        public bool Guardar(BEPedido oBEPedido)
        {
            return oMPPPedido.Guardar(oBEPedido);
        }

        public List<BEPedido> ListarTodo()
        {
            return oMPPPedido.ListarTodo();
        }
        public double calcularImporteTotal(BEPedido oBEPedido)
        {
            double total = 0;
            foreach (BEProducto p in oBEPedido.listaProductos)
            {
                total += p.Cantidad * p.Precio;
            }
            total += total * 0.21;
            return total;
        }
        public double calcularImporte(BEPedido oBEPedido)
        {
            return oBEPedido.listaProductos.Sum(x => x.Precio * x.Cantidad);
        }
    }
}
