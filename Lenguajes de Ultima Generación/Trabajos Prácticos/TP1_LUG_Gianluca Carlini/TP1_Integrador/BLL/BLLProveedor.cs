using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using MPP;

namespace BLL
{
    public class BLLProveedor : IGestor<BEProveedor>
    {

        public BLLProveedor()
        {
            objMPPProvedor = new MPPProveedor();
        }

        MPPProveedor objMPPProvedor;
        public bool Borrar(BEProveedor obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEProveedor obj)
        {
            return objMPPProvedor.Guardar(obj);
        }

        public List<BEProveedor> ListarTodo()
        {
            return objMPPProvedor.ListarTodo();
        }
    }
}
