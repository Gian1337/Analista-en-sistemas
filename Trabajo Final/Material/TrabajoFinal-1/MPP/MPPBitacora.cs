using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPBitacora : IGestor<BEBitacora>
    {
        const string archivo = @".\DATA\Bitacora.xml";
        public bool Borrar(BEBitacora oBEBitacora)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Bitacora")
                            where int.Parse(e.Attribute("BitacoraId").Value) == oBEBitacora.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int BitacoraId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Bitacora")
                .Select(e => (int?)e.Attribute("BitacoraId"))
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
        public bool Guardar(BEBitacora oBEBitacora)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEBitacora.Id == 0)
                {
                    docXml.Element("Bitacoras").Add(new XElement("Bitacora",
                        new XAttribute("BitacoraId", BitacoraId()),
                        new XElement("Fecha", oBEBitacora.Fecha.ToString()),
                        new XElement("EmpleadoId", oBEBitacora.UsuarioEmpleado.Id),
                        new XElement("Evento", oBEBitacora.Evento)
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEBitacora> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                MPPEmpleado oMPPUsuario = new MPPEmpleado();

                var query = from e in docXml.Descendants("Bitacora")
                            select e;

                List<BEBitacora> listaBitacora = new List<BEBitacora>();
                foreach (XElement e in query)
                {
                    BEBitacora oBEBitacora = new BEBitacora();
                    oBEBitacora.Id = int.Parse(e.Attribute("BitacoraId").Value);
                    oBEBitacora.UsuarioEmpleado = oMPPUsuario.ListarTodo().Find(x => x.Id == int.Parse(e.Element("EmpleadoId").Value));
                    oBEBitacora.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEBitacora.Evento = e.Element("Evento").Value;

                    listaBitacora.Add(oBEBitacora);
                }

                return listaBitacora;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
