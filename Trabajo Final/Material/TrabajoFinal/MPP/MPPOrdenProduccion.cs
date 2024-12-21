using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPOrdenProduccion : IGestor<BEOrdenProduccion>
    {
        const string archivo = @".\DATA\OrdenProduccion.xml";
        const string archivo2 = @".\DATA\OrdenProduccion_Producto.xml";
        const string archivo3 = @".\DATA\Almacen_Producto.xml";

        public bool Borrar(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("OrdenProduccion")
                            where int.Parse(e.Attribute("OrdenProduccionId").Value) == oBEOrdenProduccion.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int OrdenProduccionId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("OrdenProduccion")
                .Select(e => (int?)e.Attribute("OrdenProduccionId"))
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
        public int OrdenProduccion_ProductosId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("OrdenProduccion_Productos")
                .Select(e => (int?)e.Attribute("OrdenProduccion_ProductosId"))
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
        public bool Guardar(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                if (oBEOrdenProduccion.Id == 0)
                {
                    oBEOrdenProduccion.Id = OrdenProduccionId();
                    docXml.Element("OrdenesProduccion").Add(new XElement("OrdenProduccion",
                        new XAttribute("OrdenProduccionId", oBEOrdenProduccion.Id),
                        new XElement("Numero", oBEOrdenProduccion.Id),
                        new XElement("Fecha", oBEOrdenProduccion.Fecha.ToString()),
                        new XElement("Cantidad", oBEOrdenProduccion.Cantidad.ToString()),
                        new XElement("Lote", oBEOrdenProduccion.Lote),
                        new XElement("Tareas", oBEOrdenProduccion.Tareas),
                        new XElement("PedidoMaterialId", oBEOrdenProduccion.PedidoMaterial.Id.ToString()),
                        new XElement("EmpleadoId", oBEOrdenProduccion.Empleado.Id.ToString())
                        ));

                    // OrdenProduccion_Producto
                    XDocument docXml2 = XDocument.Load(archivo2);
                    docXml2.Element("OrdenesProduccion_Productos").Add(new XElement("OrdenProduccion_Producto",
                        new XAttribute("OrdenProduccion_ProductosId", OrdenProduccion_ProductosId()),
                        new XElement("OrdenProduccionId", OrdenProduccionId()),
                        new XElement("ProductoId", oBEOrdenProduccion.Producto.Id),
                        new XElement("Cantidad", oBEOrdenProduccion.Cantidad)
                        ));

                    docXml2.Save(archivo2);
                    docXml.Save(archivo);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("OrdenProduccion")
                                where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.Id.ToString()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Numero").Value = oBEOrdenProduccion.Numero.ToString();
                        e.Element("Fecha").Value = oBEOrdenProduccion.Fecha.ToString();
                        e.Element("Cantidad").Value = oBEOrdenProduccion.Cantidad.ToString();
                        e.Element("Lote").Value = oBEOrdenProduccion.Lote;
                        e.Element("PedidoMaterialId").Value = (oBEOrdenProduccion.PedidoMaterial != null) ? oBEOrdenProduccion.PedidoMaterial.Id.ToString() : "0";
                        e.Element("EmpleadoId").Value = (oBEOrdenProduccion.Empleado != null) ? oBEOrdenProduccion.Empleado.Id.ToString() : "0";
                        e.Element("Tareas").Value = String.Empty;
                        foreach(string tarea in oBEOrdenProduccion.Tareas)
                        {
                            e.Element("Tareas").Value += $"{tarea}-";
                        }
                        
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEOrdenProduccion> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);
                MPPProducto oMPPProducto = new MPPProducto();
                MPPPedidoMaterial oMPPPedidoMaterial = new MPPPedidoMaterial();
                MPPEmpleado oMPPEmpleado = new MPPEmpleado();

                var query = from e in docXml.Descendants("OrdenProduccion")
                            select e;

                List<BEOrdenProduccion> listaBEOrdenProducciones = new List<BEOrdenProduccion>();
                foreach (XElement e in query)
                {
                    BEOrdenProduccion oBEOrdenProduccion = new BEOrdenProduccion();
                    oBEOrdenProduccion.Id = int.Parse(e.Attribute("OrdenProduccionId").Value);
                    oBEOrdenProduccion.Numero = int.Parse(e.Element("Numero").Value);
                    oBEOrdenProduccion.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEOrdenProduccion.Cantidad = int.Parse(e.Element("Cantidad").Value);
                    oBEOrdenProduccion.Lote = e.Element("Lote").Value;
                    BEPedidoMaterial oBEPedidoMaterial = oMPPPedidoMaterial.ListarTodo().FirstOrDefault(x => x.Id == int.Parse(e.Element("PedidoMaterialId").Value));
                    oBEOrdenProduccion.PedidoMaterial = oBEPedidoMaterial;

                    BEEmpleado oBEEmpleado = oMPPEmpleado.ListarTodo().FirstOrDefault(x => x.Id == int.Parse(e.Element("EmpleadoId").Value));
                    oBEOrdenProduccion.Empleado = oBEEmpleado;
                    string[] tareas = e.Element("Tareas").Value.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(string t in tareas)
                    {
                        oBEOrdenProduccion.Tareas.Add(t);
                    }
                    var query2 = from e2 in docXml2.Descendants("OrdenProduccion_Producto")
                                 where e2.Element("OrdenProduccionId").Value == oBEOrdenProduccion.Id.ToString()
                                 select e2;
                    foreach (XElement e2 in query2)
                    {
                        oBEOrdenProduccion.Producto = oMPPProducto.ListarTodo().Find(x => x.Id == int.Parse(e2.Element("ProductoId").Value));
                    }

                    listaBEOrdenProducciones.Add(oBEOrdenProduccion);
                }

                return listaBEOrdenProducciones;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool CalcularMateriaPrima(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(@".\DATA\Producto.xml");
                XDocument docXml2 = XDocument.Load(@".\DATA\Almacen_Producto.xml");

                // buscamos el material del cual esta hecho el producto
                var query = from p in docXml.Descendants("Producto")
                            where p.Element("Nombre").Value == oBEOrdenProduccion.Producto.Material
                            select p;

                foreach (XElement e in query)
                {
                    var query2 = from a in docXml2.Descendants("Almacen_Producto")
                                 where int.Parse(a.Element("ProductoId").Value) == int.Parse(e.Attribute("ProductoId").Value)
                                 select a;
                    foreach (XElement e2 in query2)
                    {
                        if (int.Parse(e2.Element("Cantidad").Value) >= oBEOrdenProduccion.Cantidad)
                        {
                            return true;
                        }
                    }
                }
                return false;

            }
            catch (Exception) { throw; }
        }

        public void AsignarEmpleadoOrdenProduccion(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("OrdenProduccion")
                            where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.Id.ToString()
                            select e;

                foreach (XElement e in query)
                {
                    e.Element("EmpleadoId").Value = oBEOrdenProduccion.Empleado.Id.ToString();
                }

                docXml.Save(archivo);
            }
            catch (Exception) { throw; }
        }
        public void FinalizarOrdenProduccion(BEOrdenProduccion oBEOrdenProduccion)
        {
            try
            {
                // removemos la orden ya finalizada
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("OrdenProduccion")
                            where e.Attribute("OrdenProduccionId").Value == oBEOrdenProduccion.Id.ToString()
                            select e;

                query.Remove();
                docXml.Save(archivo);

                XDocument docXml2 = XDocument.Load(archivo2);

                var query2 = from e in docXml2.Descendants("OrdenProduccion_Producto")
                             where e.Element("OrdenProduccionId").Value == oBEOrdenProduccion.Id.ToString()
                             select e;
                query2.Remove();
                docXml2.Save(archivo2);

                XDocument docXmlAlmacen = XDocument.Load(archivo3);
                var query3 = from e in docXmlAlmacen.Descendants("Almacen_Producto")
                             where e.Element("ProductoId").Value == oBEOrdenProduccion.Producto.Id.ToString()
                             select e;
                foreach(XElement e in query3)
                {
                    e.Element("Cantidad").Value = oBEOrdenProduccion.Cantidad.ToString();
                    e.Element("Lote").Value = oBEOrdenProduccion.Lote.ToString();
                }
                

                MPPProducto oMPPProducto = new MPPProducto();
                BEProducto material = oMPPProducto.ListarTodo().Find(x => x.Nombre == oBEOrdenProduccion.Producto.Material);

                var query4 = from e in docXmlAlmacen.Descendants("Almacen_Producto")
                             where e.Element("ProductoId").Value == material.Id.ToString()
                             select e;
                foreach(XElement e in query4)
                {
                    int cantidad = int.Parse(e.Element("Cantidad").Value) - oBEOrdenProduccion.Cantidad;
                    e.Element("Cantidad").Value = cantidad.ToString();
                }
                docXmlAlmacen.Save(archivo3);
            }
            catch (Exception) { throw; }
        }


    }
}
