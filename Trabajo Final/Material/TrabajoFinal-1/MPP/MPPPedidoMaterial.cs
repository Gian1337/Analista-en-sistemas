using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPPedidoMaterial : IGestor<BEPedidoMaterial>
    {
        const string archivo = @".\DATA\PedidoMaterial.xml";
        const string archivo2 = @".\DATA\PedidoMaterial_Producto.xml";
        const string archivo3 = @".\DATA\Almacen_Producto.xml";
        public bool Borrar(BEPedidoMaterial oBEPedidoMaterial)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("PedidoMaterial")
                            where int.Parse(e.Attribute("PedidoMaterialId").Value) == oBEPedidoMaterial.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int PedidoMaterialId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("PedidoMaterial")
                .Select(e => (int?)e.Attribute("PedidoMaterialId"))
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
        public bool Guardar(BEPedidoMaterial oBEPedidoMaterial)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);

                if (oBEPedidoMaterial.Id == 0)
                {
                    oBEPedidoMaterial.Id = PedidoMaterialId();
                    docXml.Element("PedidosMaterial").Add(new XElement("PedidoMaterial",
                        new XAttribute("PedidoMaterialId", oBEPedidoMaterial.Id),
                        new XElement("Fecha", oBEPedidoMaterial.Fecha.ToString())
                        ));

                    foreach (BEProducto p in oBEPedidoMaterial.Productos)
                    {
                        docXml2.Element("PedidoMateriales_Productos").Add(new XElement("PedidoMaterial_Producto",
                            new XElement("PedidoMaterialId", oBEPedidoMaterial.Id),
                            new XElement("ProductoId", p.Id),
                            new XElement("Cantidad", p.Cantidad)
                            ));
                    }

                    docXml.Save(archivo);
                    docXml2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("PedidoMaterial")
                                where e.Attribute("PedidoMaterialId").Value == oBEPedidoMaterial.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Fecha").Value = oBEPedidoMaterial.Fecha.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEPedidoMaterial> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);
                MPPProducto oMPPProducto = new MPPProducto();

                var query = from e in docXml.Descendants("PedidoMaterial")
                            select e;

                List<BEPedidoMaterial> listaPedidosMaterial = new List<BEPedidoMaterial>();
                foreach (XElement e in query)
                {
                    BEPedidoMaterial oBEPedidoMaterial = new BEPedidoMaterial();
                    oBEPedidoMaterial.Id = int.Parse(e.Attribute("PedidoMaterialId").Value);
                    oBEPedidoMaterial.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    var query2 = from p in docXml2.Descendants("PedidoMaterial_Producto")
                                 where p.Element("PedidoMaterialId").Value == oBEPedidoMaterial.Id.ToString()
                                 select p;

                    foreach(XElement e2 in query2)
                    {
                        BEProducto oBEProducto = new BEProducto();
                        oBEProducto = oMPPProducto.ListarTodo().Find(x => x.Id == int.Parse(e2.Element("ProductoId").Value));
                        oBEProducto.Cantidad = int.Parse(e2.Element("Cantidad").Value);
                        oBEPedidoMaterial.Productos.Add(oBEProducto);
                    }
                    
                    listaPedidosMaterial.Add(oBEPedidoMaterial);
                }

                return listaPedidosMaterial;
            }
            catch (Exception ex) { throw ex; }
        }
        public void FinalizarPedidoMaterial(BEPedidoMaterial oBEPedidoMaterial)
        {
            XDocument docXml = XDocument.Load(archivo);
            XDocument docXml2 = XDocument.Load(archivo2);
            XDocument docXml3 = XDocument.Load(archivo3);

            var query = from e in docXml.Descendants("PedidoMaterial")
                        where e.Attribute("PedidoMaterialId").Value == oBEPedidoMaterial.Id.ToString()
                        select e;

            query.Remove();

            foreach(BEProducto producto in oBEPedidoMaterial.Productos)
            {
                var query2 = from p in docXml2.Descendants("PedidoMaterial_Producto")
                             where p.Element("PedidoMaterialId").Value == oBEPedidoMaterial.Id.ToString()
                             where p.Element("ProductoId").Value == producto.Id.ToString()
                             select p;

                query2.Remove();
                docXml2.Save(archivo2);

                var query3 = from p in docXml3.Descendants("Almacen_Producto")
                             where p.Element("ProductoId").Value == producto.Id.ToString()
                             select p;
                foreach(XElement e in query3)
                {
                    e.Element("Cantidad").Value = producto.Cantidad.ToString();
                    e.Element("Lote").Value = DateTime.Now.ToString("yyMMdd");
                }
            }
            docXml.Save(archivo);
            docXml3.Save(archivo3);
        }
    }
}
