using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
using MPP;

namespace BLL
{
    public class BLLBolso : BLLProducto, IGestor<BEBolso>
    {

        public BLLBolso()
        {
            objMPPBolso = new MPPBolso();
        }

        MPPBolso objMPPBolso;
        public bool Borrar(BEBolso obj)
        {
           return objMPPBolso.Borrar(obj);
        }

        public bool Guardar(BEBolso obj)
        {
            return objMPPBolso.Guardar(obj);
        }

        public List<BEBolso> ListarTodo()
        {
            return objMPPBolso.ListarTodo();
        }

        public bool GuardarProducto_Cliente(BECliente objBECliente, BEBolso objBEBolso)
        {
            return objMPPBolso.GuardarProducto_Cliente(objBECliente, objBEBolso);
        }
    }
}
