using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPEstado : IGestor<BEEstado>
    {
        const string archivo = @".\DATA\Estado.xml";
        public bool Borrar(BEEstado oBEEstado)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Estado")
                            where int.Parse(e.Attribute("EstadoId").Value) == oBEEstado.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int EstadoId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Almacen")
                .Select(e => (int?)e.Attribute("AlmacenId"))
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
        public bool Guardar(BEEstado oBEEstado)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEEstado.Id == 0)
                {
                    docXml.Element("Entregas").Add(new XElement("Entrega",
                        new XAttribute("EntregaId", EstadoId()),
                        new XElement("Fecha", oBEEstado.Tipo.ToString())
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Estado")
                                where e.Attribute("EstadoId").Value == oBEEstado.Id.ToString().Trim()
                                select e;

                    foreach (XElement e in query)
                    {
                        e.Element("Tipo").Value = oBEEstado.Tipo.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEEstado> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Estado")
                            select e;

                List<BEEstado> listaEstados = new List<BEEstado>();
                foreach (XElement e in query)
                {
                    BEEstado oBEEstado = new BEEstado();
                    oBEEstado.Id = int.Parse(e.Attribute("EstadoId").Value);
                    oBEEstado.Tipo = e.Element("Tipo").Value.ToString();
                    listaEstados.Add(oBEEstado);
                }

                return listaEstados;
            }
            catch (Exception ex) { throw ex; }
        }
        public BEEstado actualizarEstado(BEPedido oBEPedido)
        {
            if (oBEPedido.Estado == null)
            {
                return ListarTodo().First();
            }
            else
            {
                BEEstado oBEEstado = ListarTodo().Find(x => x.Id == oBEPedido.Estado.Id + 1);
                if (oBEEstado != null)
                {
                    return oBEEstado;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
