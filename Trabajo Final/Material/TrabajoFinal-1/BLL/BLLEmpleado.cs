using ABS;
using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLEmpleado : IGestor<BEEmpleado>
    {
        public BLLEmpleado()
        {
            oMPPEmpleado = new MPPEmpleado();
        }
        MPPEmpleado oMPPEmpleado;
        public bool Borrar(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.Borrar(oBEEmpleado);
        }

        public bool Guardar(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.Guardar(oBEEmpleado);
        }

        public List<BEEmpleado> ListarTodo()
        {
            return oMPPEmpleado.ListarTodo();
        }
        public bool VerificarDatos(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.VerificarDatos(oBEEmpleado);
        }
        public string DesenscriptarPassword(BEEmpleado oBEEmpleado)
        {
            return oMPPEmpleado.DesenscriptarPassword(oBEEmpleado);
        }
    }
}
