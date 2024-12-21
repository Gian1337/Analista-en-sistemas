using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPPedido : IGestor<BEPedido>
    {
        const string archivo = @".\DATA\Pedido.xml";
        const string archivo2 = @".\DATA\Pedido_Producto.xml";

        public bool Borrar(BEPedido oBEPedido)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Pedido")
                            where int.Parse(e.Attribute("PedidoId").Value) == oBEPedido.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int PedidoId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Pedido")
                .Select(e => (int?)e.Attribute("PedidoId"))
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
        public bool Guardar(BEPedido oBEPedido)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);

                if (oBEPedido.Id == 0)
                {
                    oBEPedido.Id = PedidoId();
                    docXml.Element("Pedidos").Add(new XElement("Pedido",
                        new XAttribute("PedidoId", oBEPedido.Id.ToString()),
                        new XElement("NumeroPedido", "P" + oBEPedido.Id.ToString()),
                        new XElement("ClienteId", oBEPedido.Cliente.Id.ToString()),
                        new XElement("Fecha", oBEPedido.Fecha.ToString()),
                        new XElement("ImporteTotal", oBEPedido.ImporteTotal.ToString()),
                        new XElement("EstadoId", oBEPedido.Estado.Id.ToString()),
                        new XElement("FacturaId", oBEPedido.FacturaCompra.Id.ToString())
                        ));

                    // cargamos todos los productos del pedido
                    foreach (BEProducto p in oBEPedido.listaProductos)
                    {
                        docXml2.Element("Pedidos_Productos").Add(new XElement("Pedido_Producto",
                            new XElement("PedidoId", oBEPedido.Id.ToString()),
                            new XElement("ProductoId", p.Id.ToString()),
                            new XElement("Cantidad", p.Cantidad.ToString()),
                            new XElement("Precio", p.Precio)
                            ));
                    }

                    docXml.Save(archivo);
                    docXml2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Pedido")
                                where e.Attribute("PedidoId").Value == oBEPedido.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("NumeroPedido").Value = oBEPedido.Numero.ToString();
                        e.Element("ClienteId").Value = oBEPedido.Cliente.Id.ToString();
                        e.Element("Fecha").Value = oBEPedido.Fecha.ToString();
                        e.Element("ImporteTotal").Value = oBEPedido.ImporteTotal.ToString();
                        e.Element("EstadoId").Value = oBEPedido.Estado.Id.ToString();
                        e.Element("FacturaId").Value = oBEPedido.FacturaCompra.Id.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEPedido> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                MPPCliente oMPPCliente = new MPPCliente(); // para listar los clientes y traerlos de manera simple
                MPPEstado oMPPEstado = new MPPEstado();
                MPPFacturaCompra oMPPFacturaCompra = new MPPFacturaCompra();

                var query = from e in docXml.Descendants("Pedido")
                            select e;

                List<BEPedido> listaPedidos = new List<BEPedido>();
                foreach (XElement e in query)
                {
                    BEPedido oBEPedido = new BEPedido();
                    oBEPedido.Id = int.Parse(e.Attribute("PedidoId").Value);
                    oBEPedido.Numero = e.Element("NumeroPedido").Value.ToString();
                    oBEPedido.Cliente = oMPPCliente.ListarTodo().Find(x => x.Id == int.Parse(e.Element("ClienteId").Value));
                    oBEPedido.Fecha = DateTime.Parse(e.Element("Fecha").Value);
                    oBEPedido.ImporteTotal = double.Parse(e.Element("ImporteTotal").Value);
                    oBEPedido.Estado = oMPPEstado.ListarTodo().Find(x => x.Id == int.Parse(e.Element("EstadoId").Value));
                    oBEPedido.FacturaCompra = oMPPFacturaCompra.ListarTodo().Find(x => x.Id == int.Parse(e.Element("FacturaId").Value));
                    if (oBEPedido.FacturaCompra == null)
                    {
                        oBEPedido.FacturaCompra = new BEFacturaCompra();
                    }
                    oBEPedido.listaProductos = ListarProductosPedido(oBEPedido);
                    listaPedidos.Add(oBEPedido);
                }

                return listaPedidos;
            }
            catch (Exception ex) { throw ex; }
        }
        public List<BEProducto> ListarProductosPedido(BEPedido oBEPedido)
        {
            try
            {
                List<BEProducto> ListaProductosPedido = new List<BEProducto>();
                List<BEProducto> ListaProductos = new List<BEProducto>();
                XDocument docXml = XDocument.Load(archivo2);
                MPPProducto oMPPProducto = new MPPProducto();

                var query = from p in docXml.Descendants("Pedido_Producto")
                            where p.Element("PedidoId").Value == oBEPedido.Id.ToString()
                            select p;

                ListaProductos = oMPPProducto.ListarTodo();
                foreach (XElement p in query)
                {
                    BEProducto oBEProducto = ListaProductos.Find(x => x.Id == int.Parse(p.Element("ProductoId").Value));
                    oBEProducto.Cantidad = int.Parse(p.Element("Cantidad").Value);
                    ListaProductosPedido.Add(oBEProducto);
                }
                return ListaProductosPedido;
            }
            catch (Exception) { throw; }
        }
    }
}
