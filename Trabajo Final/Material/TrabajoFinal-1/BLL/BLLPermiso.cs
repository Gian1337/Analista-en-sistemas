using ABS;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLPermiso : BLLComponente, IGestor<BEComponente>
    {
        public BLLPermiso()
        {
            oMPPPermiso = new MPPPermiso();
        }
        MPPPermiso oMPPPermiso;

        public override bool Borrar(BEComponente obj)
        {
            throw new NotImplementedException();
        }

        public override bool Guardar(BEComponente obj)
        {
            throw new NotImplementedException();
        }

        public override List<BEComponente> ListarTodo()
        {
            throw new NotImplementedException();
        }
        public List<BEComponente> ListarRoles()
        {
            return oMPPPermiso.ListarRoles();
        }

        public override IList<BEComponente> ObtenerHijos(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }

        public override void AgregarHijo(BEComponente oBEComponente)
        {
            throw new NotImplementedException();
        }
        public List<BEComponente> ListarPermisosUsuario(BEEmpleado oBEEmpleado)
        {
            return oMPPPermiso.ListarPermisosUsuario(oBEEmpleado);
        }
        public bool AsignarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEPermiso)
        {
            return oMPPPermiso.AsignarPermisoUsuario(oBEEmpleado, oBEPermiso);
        }
        public bool BorrarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEComponente)
        {
            return oMPPPermiso.BorrarPermisoUsuario(oBEEmpleado, oBEComponente);
        }

    }
}
