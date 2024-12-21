using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace MPP
{
    public class MPPAlmacen : IGestor<BEAlmacen>
    {
        const string archivo = @".\DATA\Almacen.xml";
        const string archivo2 = @".\DATA\Almacen_Producto.xml";

        public bool Borrar(BEAlmacen oBEAlmacen)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Almacen")
                            where int.Parse(e.Attribute("AlmacenId").Value) == oBEAlmacen.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int AlmacenId()
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
        public bool Guardar(BEAlmacen oBEAlmacen)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEAlmacen.Id == 0)
                {
                    docXml.Element("Almacenes").Add(new XElement("Almacen",
                        new XAttribute("AlmacenId", AlmacenId()),
                        new XElement("Deposito", oBEAlmacen.Deposito.Trim()),
                        new XElement("Estanteria", oBEAlmacen.Estanteria.Trim()),
                        new XElement("Ubicacion", oBEAlmacen.Ubicacion.Trim())
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Almacen")
                                where e.Attribute("AlmacenId").Value == oBEAlmacen.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Deposito").Value = oBEAlmacen.Deposito.Trim();
                        e.Element("Estanteria").Value = oBEAlmacen.Estanteria.Trim();
                        e.Element("Ubicacion").Value = oBEAlmacen.Ubicacion.Trim();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEAlmacen> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Almacen")
                            select e;

                List<BEAlmacen> listaAlmacenes = new List<BEAlmacen>();
                foreach (XElement e in query)
                {
                    BEAlmacen oBEAlmacen = new BEAlmacen();
                    oBEAlmacen.Id = int.Parse(e.Attribute("AlmacenId").Value);
                    oBEAlmacen.Deposito = e.Element("Deposito").Value;
                    oBEAlmacen.Estanteria = e.Element("Estanteria").Value;
                    oBEAlmacen.Ubicacion = e.Element("Ubicacion").Value;

                    listaAlmacenes.Add(oBEAlmacen);
                }

                return listaAlmacenes;
            }
            catch (Exception ex) { throw ex; }
        }
        public void ActualizarStockAlmacen(BEProducto oBEProducto)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo2);
                var query = from e in docXml.Descendants("Almacen_Producto")
                            where e.Element("ProductoId").Value == oBEProducto.Id.ToString()
                            select e;

                foreach (XElement e in query)
                {
                    e.Element("Cantidad").Value = (int.Parse(e.Element("Cantidad").Value) - oBEProducto.Cantidad).ToString();
                }
                docXml.Save(archivo2);
            }
            catch (Exception) { throw; }
        }
    }
}
