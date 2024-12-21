using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPPermiso : IGestor<BEComponente>
    {
        const string archivo = @".\DATA\Permiso.xml";
        const string archivo2 = @".\DATA\Permiso_Permiso.xml";
        const string archivo3 = @".\DATA\Empleado_Permiso.xml";
        public bool Borrar(BEComponente oBEComponente)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Permiso")
                            where int.Parse(e.Attribute("PermisoId").Value) == oBEComponente.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int PermisoId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Permiso")
                .Select(e => (int?)e.Attribute("PermisoId"))
                .Max() ?? 0;

            if (ultimoId == 0)
            {
                ultimoId = 1;
            }
            else
            {
                ultimoId++;
            }
            return ultimoId;
        }
        public bool Guardar(BEComponente oBEComponente)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEComponente.Id == 0)
                {
                    docXml.Element("Permisos").Add(new XElement("Permiso",
                        new XAttribute("PermisoId", PermisoId()),
                        new XElement("Nombre", oBEComponente.Nombre),
                        new XElement("Rol", oBEComponente.isRol.ToString())
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Permiso")
                                where e.Attribute("PermisoId").Value == oBEComponente.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Nombre").Value = oBEComponente.Nombre;
                        e.Element("Rol").Value = oBEComponente.isRol.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEComponente> ListarTodo()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex) { throw ex; }
        }
        public List<BEComponente> ListarRoles()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);
                List<BEComponente> listaRoles = new List<BEComponente>();
                List<BEComponente> listaPermisos = new List<BEComponente>();

                var perm = from r in docXml.Descendants("Permiso")
                           select r;

                foreach (XElement r in perm)
                {
                    if ((bool)r.Element("Rol") == true)
                    {
                        BEComponente BERol = new BERol(
                            nombre: r.Element("Nombre").Value
                        );
                        BERol.Id = int.Parse(r.Attribute("PermisoId").Value);
                        listaRoles.Add(BERol);
                    }
                    else
                    {
                        BEComponente BEPermiso = new BEPermiso(
                            nombre: r.Element("Nombre").Value
                        );
                        BEPermiso.Id = int.Parse(r.Attribute("PermisoId").Value);
                        listaPermisos.Add(BEPermiso);
                    }
                }

                foreach (BEComponente rol in listaRoles)
                {
                    var rolperm = from rp in docXml2.Descendants("Permiso_Permiso")
                                  where int.Parse(rp.Element("PermisoPadreId").Value) == rol.Id
                                  select int.Parse(rp.Element("PermisoHijoId").Value);
                    foreach (int rp in rolperm)
                    {
                        rol.AgregarHijo(listaPermisos.Find(x => x.Id == rp));
                    }
                }

                return listaRoles;
            }
            catch (Exception ex) { throw ex; }
        }
        public List<BEComponente> ListarPermisosUsuario(BEEmpleado oBEEmpleado)
        {
            try
            {
                List<BEComponente> listaPermisos = ListarRoles();
                XDocument docXml = XDocument.Load(archivo3);
                var query = from p in docXml.Descendants("Empleado_Permiso")
                            where int.Parse(p.Element("EmpleadoId").Value) == oBEEmpleado.Id
                            select int.Parse(p.Element("PermisoId").Value);
                List<BEComponente> listaPermisosUsuario = new List<BEComponente>();
                foreach (int Idp in query)
                {
                    if (listaPermisos.Exists(x => x.Id == Idp))
                    {
                        listaPermisosUsuario.Add(listaPermisos.Find(x => x.Id == Idp));
                    }
                    else
                    {
                        foreach (BEComponente c in listaPermisos)
                        {
                            if (c.ObtenerHijos().ToList().Exists(x => x.Id == Idp) && !listaPermisosUsuario.Exists(x => x.Id == Idp))
                            {
                                listaPermisosUsuario.Add(c.ObtenerHijos().First(x => x.Id == Idp));
                            }
                        }
                    }
                }
                return listaPermisosUsuario;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool AsignarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEPermiso)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo3);
                docXml.Element("Empleado_Permisos").Add(new XElement("Empleado_Permiso",
                        new XElement("EmpleadoId", oBEEmpleado.Id.ToString()),
                        new XElement("PermisoId", oBEPermiso.Id.ToString())
                        ));
                docXml.Save(archivo3);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool BorrarPermisoUsuario(BEEmpleado oBEEmpleado, BEComponente oBEComponente)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo3);

                var query = from e in docXml.Descendants("Empleado_Permiso")
                            where int.Parse(e.Element("EmpleadoId").Value) == oBEEmpleado.Id
                            where int.Parse(e.Element("PermisoId").Value) == oBEComponente.Id
                            select e;

                query.Remove();
                docXml.Save(archivo3);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
