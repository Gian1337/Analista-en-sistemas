using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using Services;

namespace MPP
{
    public class MPPEmpleado : IGestor<BEEmpleado>
    {
        const string archivo = @".\DATA\Empleado.xml";
        const string archivo2 = @".\DATA\Empleado_Permiso.xml";
        public bool Borrar(BEEmpleado oBEEmpleado)
        {
            // borramos el usuario
            XDocument docXml = XDocument.Load(archivo);
            var query = from e in docXml.Descendants("Empleado")
                        where e.Attribute("EmpleadoId").Value == oBEEmpleado.Id.ToString()
                        select e;
            query.Remove();
            
            XDocument docXml2 = XDocument.Load(archivo2);
            var query2 = from e in docXml2.Descendants("Empleado_Permiso")
                         where e.Element("EmpleadoId").Value == oBEEmpleado.Id.ToString()
                         select e;
            query2.Remove();

            docXml.Save(archivo);
            docXml2.Save(archivo2);

            return true;
        }
        public int UsuarioId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Empleado")
                .Select(e => (int?)e.Attribute("EmpleadoId"))
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
        public bool Guardar(BEEmpleado oBEEmpleado)
        {
            XDocument docXml = XDocument.Load(archivo);

            if (oBEEmpleado.Id == 0)
            {
                docXml.Element("Empleados").Add(new XElement("Empleado",
                new XAttribute("EmpleadoId", UsuarioId()),
                new XElement("NombreUsuario", oBEEmpleado.NombreUsuario.Trim()),
                new XElement("Password", Security.EncriptarMD5(oBEEmpleado.Password.Trim())),
                new XElement("Nombre", oBEEmpleado.Nombre.Trim()),
                new XElement("Apellido", oBEEmpleado.Apellido.Trim()),
                new XElement("Sector", oBEEmpleado.Sector.Trim())
                ));

                docXml.Save(archivo);
                return true;
            }
            else
            {
                var query = from e in docXml.Descendants("Empleado")
                            where e.Attribute("EmpleadoId").Value == oBEEmpleado.Id.ToString().Trim()
                            select e;
                foreach (XElement e in query)
                {
                    e.Element("NombreUsuario").Value = oBEEmpleado.NombreUsuario.Trim();
                    e.Element("Password").Value = Security.EncriptarMD5(oBEEmpleado.Password.Trim());
                    e.Element("Nombre").Value = oBEEmpleado.Nombre.Trim();
                    e.Element("Apellido").Value = oBEEmpleado.Apellido.Trim();
                    e.Element("Sector").Value = oBEEmpleado.Sector.Trim();
                }
                docXml.Save(archivo);
                return true;
            }
        }

        public List<BEEmpleado> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Empleado")
                            select e;

                List<BEEmpleado> listaEmpleados = new List<BEEmpleado>();
                foreach (XElement e in query)
                {
                    BEEmpleado oBEEmpleado = new BEEmpleado();
                    oBEEmpleado.Id = int.Parse(e.Attribute("EmpleadoId").Value);
                    oBEEmpleado.NombreUsuario = e.Element("NombreUsuario").Value;
                    oBEEmpleado.Nombre = e.Element("Nombre").Value;
                    oBEEmpleado.Apellido = e.Element("Apellido").Value;
                    oBEEmpleado.Password = e.Element("Password").Value;
                    oBEEmpleado.Sector = e.Element("Sector").Value;
                    listaEmpleados.Add(oBEEmpleado);
                }

                return listaEmpleados;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool VerificarDatos(BEEmpleado oBEEmpleado)
        {
            try
            {
                XElement xml = XElement.Load(archivo);

                var query = from e in xml.Descendants("Empleado")
                            where e.Element("NombreUsuario").Value.Trim() == oBEEmpleado.NombreUsuario.Trim()
                            where e.Element("Password").Value.Trim() == Security.EncriptarMD5(oBEEmpleado.Password.Trim())
                            select e;

                if (query.Any() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public string DesenscriptarPassword(BEEmpleado oBEEmpleado)
        {
            return Security.DesencriptarMD5(ListarTodo().Find(x => x.Id == oBEEmpleado.Id).Password);
        }
    }
}
