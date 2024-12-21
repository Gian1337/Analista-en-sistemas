using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPFacturaCompra : IGestor<BEFacturaCompra>
    {
        const string archivo = @".\DATA\FacturaCompra.xml";
        public bool Borrar(BEFacturaCompra oBEFacturaCompra)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("FacturaCompra")
                            where int.Parse(e.Attribute("FacturaCompraId").Value) == oBEFacturaCompra.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int FacturaCompraId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("FacturaCompra")
                .Select(e => (int?)e.Attribute("FacturaCompraId"))
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
        public bool Guardar(BEFacturaCompra oBEFacturaCompra)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEFacturaCompra.Id == 0)
                {
                    oBEFacturaCompra.Id = FacturaCompraId();
                    docXml.Element("FacturasCompra").Add(new XElement("FacturaCompra",
                        new XAttribute("FacturaCompraId", oBEFacturaCompra.Id.ToString()),
                        new XElement("NumeroFactura", oBEFacturaCompra.Id.ToString()),
                        new XElement("Fecha", oBEFacturaCompra.Fecha.ToString()),
                        new XElement("TipoFactura", oBEFacturaCompra.Tipo),
                        new XElement("Total", oBEFacturaCompra.Total.ToString())
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("FacturaCompra")
                                where e.Attribute("FacturaCompraId").Value == oBEFacturaCompra.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("NumeroFactura").Value = oBEFacturaCompra.Numero;
                        e.Element("Fecha").Value = oBEFacturaCompra.Fecha.ToString();
                        e.Element("TipoFactura").Value = oBEFacturaCompra.Tipo.ToString();
                        e.Element("Total").Value = oBEFacturaCompra.Total.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEFacturaCompra> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("FacturaCompra")
                            select e;

                List<BEFacturaCompra> listaFacturaCompras = new List<BEFacturaCompra>();
                foreach (XElement e in query)
                {
                    BEFacturaCompra oBEFacturaCompra = new BEFacturaCompra();
                    oBEFacturaCompra.Id = int.Parse(e.Attribute("FacturaCompraId").Value);
                    oBEFacturaCompra.Numero = e.Element("NumeroFactura").Value;
                    oBEFacturaCompra.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEFacturaCompra.Tipo = e.Element("TipoFactura").Value;
                    oBEFacturaCompra.Total = double.Parse(e.Element("Total").Value);
                    listaFacturaCompras.Add(oBEFacturaCompra);
                }

                return listaFacturaCompras;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
