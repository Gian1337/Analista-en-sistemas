using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPProducto : IGestor<BEProducto>
    {
        const string archivo = @".\DATA\Producto.xml";
        const string archivo2 = @".\DATA\Almacen_Producto.xml";
        const string archivo3 = @".\DATA\Pedido_Producto.xml";
        public bool Borrar(BEProducto oBEProducto)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Producto")
                            where int.Parse(e.Attribute("ProductoId").Value) == oBEProducto.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int ProductoId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Producto")
                .Select(e => (int?)e.Attribute("ProductoId"))
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
        public bool Guardar(BEProducto oBEProducto)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEProducto.Id == 0)
                {
                    docXml.Element("Productos").Add(new XElement("Producto",
                        new XAttribute("AlmacenId", ProductoId()),
                        new XElement("Codigo", oBEProducto.Codigo.ToString()),
                        new XElement("Descripcion", oBEProducto.Descripcion),
                        new XElement("Material", oBEProducto.Material),
                        new XElement("Nombre", oBEProducto.Nombre),
                        new XElement("Precio", oBEProducto.Precio.ToString()),
                        new XElement("Tipo", oBEProducto.Tipo)
                        ));

                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Producto")
                                where e.Attribute("ProductoId").Value == oBEProducto.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Descripcion").Value = oBEProducto.Descripcion.Trim();
                        e.Element("Material").Value = oBEProducto.Material.Trim();
                        e.Element("Nombre").Value = oBEProducto.Nombre.Trim();
                        e.Element("Precio").Value = oBEProducto.Precio.ToString();
                        e.Element("Tipo").Value = oBEProducto.Tipo.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEProducto> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);

                var query = from e in docXml.Descendants("Producto")
                            select e;


                List<BEProducto> listaProductos = new List<BEProducto>();
                foreach (XElement e in query)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Id = int.Parse(e.Attribute("ProductoId").Value);
                    oBEProducto.Descripcion = e.Element("Descripcion").Value;
                    oBEProducto.Codigo = e.Element("Codigo").Value;
                    oBEProducto.Nombre = e.Element("Nombre").Value;
                    oBEProducto.Material = e.Element("Material").Value;
                    oBEProducto.Precio = double.Parse(e.Element("Precio").Value);
                    oBEProducto.Tipo = e.Element("Tipo").Value;

                    var queryStock = from elem in docXml2.Descendants("Almacen_Producto")
                                     where elem.Element("ProductoId").Value == oBEProducto.Id.ToString()
                                     select elem;
                    foreach (XElement cant in queryStock)
                    {
                        if (int.Parse(cant.Element("Cantidad").Value) == 0)
                        {
                            oBEProducto.Cantidad += 0;
                        }
                        else
                        {
                            oBEProducto.Cantidad += int.Parse(cant.Element("Cantidad").Value);
                        }
                    }

                    listaProductos.Add(oBEProducto);
                }

                return listaProductos;
            }
            catch (Exception ex) { throw ex; }
        }
        public List<BEProducto> ListaProductosPorCantidadVendida()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo3);
                var productosOrdenados = docXml.Descendants("Pedido_Producto")
                    .GroupBy(pedidoProducto => (int)pedidoProducto.Element("ProductoId"))
                    .OrderByDescending(grupo => grupo.Sum(x => int.Parse(x.Element("Cantidad").Value)))
                    .Select(grupo => new
                    {
                        ProductoId = grupo.Key,
                        CantidadVendido = grupo.Sum(x => int.Parse(x.Element("Cantidad").Value))
                    });

                List<BEProducto> ListaProductos = new List<BEProducto>();
                foreach (var producto in productosOrdenados)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto = ListarTodo().Find(x => x.Id == producto.ProductoId);
                    oBEProducto.Cantidad = producto.CantidadVendido;
                    ListaProductos.Add(oBEProducto);
                }
                return ListaProductos;
            }
            catch (Exception) { throw; }
        }
    }
}
