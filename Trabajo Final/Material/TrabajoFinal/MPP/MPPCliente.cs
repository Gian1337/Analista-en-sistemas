using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCliente : IGestor<BECliente>
    {
        const string archivo = @".\DATA\Cliente.xml";
        const string archivo2 = @".\DATA\Pedido.xml";

        public bool Borrar(BECliente oBECliente)
        {

            XDocument docXml = XDocument.Load(archivo2);

            int cantidadVentas = docXml.Descendants("Pedido").Count(pedido => (int)pedido.Element("ClienteId") == oBECliente.Id);

            if(cantidadVentas == 0)
            {
                // El cliente no tiene pedidos registrados
                XDocument docXml2 = XDocument.Load(archivo);

                var query = from e in docXml2.Descendants("Cliente")
                            where int.Parse(e.Attribute("ClienteId").Value) == oBECliente.Id
                            select e;

                query.Remove();
                docXml2.Save(archivo);
                return true;
            }
            else
            {
                // El cliente tiene pedidos registrados
                return false;
            }
        }
        public int ClienteId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Cliente")
                .Select(e => (int?)e.Attribute("ClienteId"))
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
        public bool Guardar(BECliente oBECliente)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBECliente.Id == 0)
                {
                    docXml.Element("Clientes").Add(new XElement("Cliente",
                        new XAttribute("ClienteId", ClienteId()),
                        new XElement("Nombre", oBECliente.Nombre.Trim()),
                        new XElement("Apellido", oBECliente.Apellido.Trim()),
                        new XElement("NroDocumento", oBECliente.NroDocumento.Trim()),
                        new XElement("TipoDocumento", oBECliente.TipoDocumento.Trim()),
                        new XElement("Direccion", oBECliente.Direccion.Trim()),
                        new XElement("DireccionEntrega", oBECliente.DireccionEntrega.Trim()),
                        new XElement("Email", oBECliente.Email.Trim()),
                        new XElement("Telefono", oBECliente.Telefono.Trim()),
                        new XElement("RazonSocial", oBECliente.RazonSocial.Trim())
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Cliente")
                                where e.Attribute("ClienteId").Value == oBECliente.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Nombre").Value = oBECliente.Nombre.Trim();
                        e.Element("Apellido").Value = oBECliente.Apellido.Trim();
                        e.Element("NroDocumento").Value = oBECliente.NroDocumento.Trim();
                        e.Element("TipoDocumento").Value = oBECliente.TipoDocumento.Trim();
                        e.Element("Direccion").Value = oBECliente.Direccion.Trim();
                        e.Element("DireccionEntrega").Value = oBECliente.DireccionEntrega.Trim();
                        e.Element("Email").Value = oBECliente.Email.Trim();
                        e.Element("Telefono").Value = oBECliente.Telefono.Trim();
                        e.Element("RazonSocial").Value = oBECliente.RazonSocial.Trim();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BECliente> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Cliente")
                            select e;

                List<BECliente> listaClientes = new List<BECliente>();
                foreach (XElement e in query)
                {
                    BECliente oBECliente = new BECliente();
                    oBECliente.Id = int.Parse(e.Attribute("ClienteId").Value);
                    oBECliente.Nombre = e.Element("Nombre").Value;
                    oBECliente.Apellido = e.Element("Apellido").Value;
                    oBECliente.NroDocumento = e.Element("NroDocumento").Value;
                    oBECliente.TipoDocumento = e.Element("TipoDocumento").Value;
                    oBECliente.Direccion = e.Element("Direccion").Value;
                    oBECliente.DireccionEntrega = e.Element("DireccionEntrega").Value;
                    oBECliente.Email = e.Element("Email").Value;
                    oBECliente.Telefono = e.Element("Telefono").Value;
                    oBECliente.RazonSocial = e.Element("RazonSocial").Value;

                    listaClientes.Add(oBECliente);
                }

                return listaClientes;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
