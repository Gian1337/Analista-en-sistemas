using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstraccion;

namespace BLL
{
    public class BLLCalzado : BLLProducto, IGestor<BECalzado>
    {
        public BLLCalzado()
        {
            objMPPCalzado = new MPPCalzado();
        }

        MPPCalzado objMPPCalzado;
        public bool Borrar(BECalzado obj)
        {
            return objMPPCalzado.Borrar(obj);
        }

        public bool Guardar(BECalzado obj)
        {
            return objMPPCalzado.Guardar(obj);
        }

        public List<BECalzado> ListarTodo()
        {
            return objMPPCalzado.ListarTodo();
        }

        public bool GuardarProducto_Cliente(BECliente objBECliente, BECalzado objBECalzado)
        {
            return objMPPCalzado.GuardarProducto_Cliente(objBECliente, objBECalzado);
        }
    }
}
