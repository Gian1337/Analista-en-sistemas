using ABS;
using BE;
using MPP;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class BLLBitacora : IGestor<BEBitacora>
    {
        public BLLBitacora()
        {
            oMPPBitacora = new MPPBitacora();
        }
        MPPBitacora oMPPBitacora;
        public bool Borrar(BEBitacora oBEBitacora)
        {
            return oMPPBitacora.Borrar(oBEBitacora);
        }

        public bool Guardar(BEBitacora oBEBitacora)
        {
            return oMPPBitacora.Guardar(oBEBitacora);
        }

        public List<BEBitacora> ListarTodo()
        {
            return oMPPBitacora.ListarTodo();
        }

        public void Log(BEEmpleado Usuario, string Evento)
        {
            // Registro de un evento en la bitacora
            BEBitacora oBEBitacora = new BEBitacora();
            BLLBitacora oBLLBitacora = new BLLBitacora();
            oBEBitacora.Fecha = DateTime.Now;
            oBEBitacora.Evento = Evento;
            oBEBitacora.UsuarioEmpleado = Usuario;
            oBLLBitacora.Guardar(oBEBitacora);
        }
    }
}
