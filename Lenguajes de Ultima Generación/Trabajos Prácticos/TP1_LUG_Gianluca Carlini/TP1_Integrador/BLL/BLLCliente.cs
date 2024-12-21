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
    public class BLLCliente : IGestor<BECliente>
    {

        public BLLCliente()
        {
            objMPPCliente = new MPPCliente();
        }

        MPPCliente objMPPCliente;
        public bool Borrar(BECliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BECliente obj)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            return objMPPCliente.ListarTodo();
        }
    }
}
