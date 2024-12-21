using ABS;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPEntrega : IGestor<BEEntrega>
    {
        const string archivo = @".\DATA\Entrega.xml";
        const string archivo2 = @".\DATA\Entrega_Producto.xml";
        public bool Borrar(BEEntrega oBEEntrega)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Entrega")
                            where int.Parse(e.Attribute("EntregaId").Value) == oBEEntrega.Id
                            select e;

                query.Remove();
                docXml.Save(archivo);

                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public int EntregaId()
        {
            XDocument docXml = XDocument.Load(archivo);

            int ultimoId = docXml.Descendants("Entrega")
                .Select(e => (int?)e.Attribute("EntregaId"))
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
        public bool Guardar(BEEntrega oBEEntrega)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                XDocument docXml2 = XDocument.Load(archivo2);

                if (oBEEntrega.Id == 0)
                {
                    oBEEntrega.Id = EntregaId();
                    docXml.Element("Entregas").Add(new XElement("Entrega",
                        new XAttribute("EntregaId", oBEEntrega.Id.ToString()),
                        new XElement("Fecha", oBEEntrega.Fecha.ToString()),
                        new XElement("Codigo", oBEEntrega.Codigo),
                        new XElement("Estado", "En transito"),
                        new XElement("PedidoId", oBEEntrega.Pedido.Id.ToString())
                        ));
                    foreach (BEProducto p in oBEEntrega.Pedido.listaProductos)
                    {
                        docXml2.Element("Entregas_Productos").Add(new XElement("Entrega_Producto",
                            new XElement("EntregaId", oBEEntrega.Id.ToString()),
                            new XElement("ProductoId", p.Id.ToString()),
                            new XElement("Cantidad", p.Cantidad.ToString())
                            ));
                    }
                    docXml.Save(archivo);
                    docXml2.Save(archivo2);
                    return true;
                }
                else
                {
                    var query = from e in docXml.Descendants("Entrega")
                                where e.Attribute("EntregaId").Value == oBEEntrega.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        e.Element("Fecha").Value = oBEEntrega.Fecha.ToString();
                    }
                    docXml.Save(archivo);
                    return true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<BEEntrega> ListarTodo()
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);

                var query = from e in docXml.Descendants("Entrega")
                            select e;

                List<BEEntrega> listaEntregas = new List<BEEntrega>();
                foreach (XElement e in query)
                {
                    BEEntrega oBEEntrega = new BEEntrega();
                    oBEEntrega.Id = int.Parse(e.Attribute("EntregaId").Value);
                    oBEEntrega.Fecha = DateTime.Parse(e.Element("Fecha").ToString());
                    oBEEntrega.Estado = e.Element("Estado").Value;

                    listaEntregas.Add(oBEEntrega);
                }

                return listaEntregas;
            }
            catch (Exception ex) { throw ex; }
        }

        public BEEntrega BuscarOrdenEntregaPorCodigo(string codigo)
        {
            try
            {
                XDocument docXml = XDocument.Load(archivo);
                MPPPedido oMPPPedido = new MPPPedido();

                var query = from e in docXml.Descendants("Entrega")
                            where e.Element("Codigo").Value == codigo
                            where e.Element("Estado").Value == "En transito"
                            select new BEEntrega()
                            {
                                Id = int.Parse(e.Attribute("EntregaId").Value),
                                Fecha = DateTime.Parse(e.Element("Fecha").Value),
                                Codigo = e.Element("Codigo").Value,
                                Estado = e.Element("Estado").Value,
                                Pedido = oMPPPedido.ListarTodo().Find(x => x.Id == int.Parse(e.Element("PedidoId").Value))
                            };
                return query.FirstOrDefault();
            }
            catch (Exception ex) { throw ex; }
        }
        public void CumplirOrdenEntrega(BEEntrega oBEEntrega)
        {
            try
            {
                if (oBEEntrega.Id != 0)
                {
                    XDocument docXml = XDocument.Load(archivo);
                    var query = from e in docXml.Descendants("Entrega")
                                where e.Attribute("EntregaId").Value == oBEEntrega.Id.ToString().Trim()
                                select e;
                    foreach (XElement e in query)
                    {
                        // le cambiamos el estado
                        e.Element("Estado").Value = "Finalizado";
                    }
                    docXml.Save(archivo);
                }
            }
            catch (Exception) { throw; }
        }
    }
}
