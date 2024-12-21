using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;
using Abstraccion;

namespace MPP
{
    public class MPPCliente : IGestor<BECliente>
    {
        Acceso objDatos;
        public MPPCliente()
        {
            objDatos = new Acceso();
        }
        public bool Borrar(BECliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BECliente obj)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> ListarTodo()
        {
            List<BECliente> ListaCliente = new List<BECliente>();
            string query = "Select ID_Cliente, Nombre, Apellido, DNI from Cliente";
            DataTable dt = objDatos.Leer(query);

            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                BECliente objCliente = new BECliente();

                    objCliente.Codigo = Convert.ToInt32(row[0]);
                    objCliente.Nombre = Convert.ToString(row[1]);
                    objCliente.Apellido = Convert.ToString(row[2]);
                    objCliente.DNI = Convert.ToInt32(row[3]);


                    Acceso objDatos2 = new Acceso();
                    DataTable dt2 = objDatos.Leer("Select * from Producto_Cliente, Cliente as C, Item as P where Producto_Cliente.ID_Cliente = C.ID_Cliente and Producto_Cliente.ID_Producto = P.ID_Producto and C.ID_Cliente = '" + objCliente.Codigo + "'");
                    List<BEProducto> ListaProductos = new List<BEProducto>();
                    if(dt2.Rows.Count > 0)
                    {
                        foreach(DataRow row2 in dt2.Rows)
                        {
                            if (row2["Capacidad"] is DBNull)
                            {
                                BECalzado objBECalzado = new BECalzado();
                                objBECalzado.Codigo = Convert.ToInt32(row2[0]);
                                objBECalzado.Descripcion = Convert.ToString(row2["Descripción"]);
                                objBECalzado.Marca = Convert.ToString(row2["Marca"]);
                                objBECalzado.Precio = Convert.ToInt32(row2["Precio"]);
                                objBECalzado.Cantidad = Convert.ToInt32(row2["Cantidad"]);
                                objBECalzado.Material = Convert.ToString(row2["Material"]);
                                objBECalzado.Talle = Convert.ToInt32(row2["Talle"]);
                                ListaProductos.Add(objBECalzado);
                            }
                            else
                            {
                                BEBolso objBEBolso = new BEBolso();

                                objBEBolso.Codigo = Convert.ToInt32(row2["Código"]);
                                objBEBolso.Descripcion = Convert.ToString(row2["Descripción"]);
                                objBEBolso.Marca = Convert.ToString(row2["Marca"]);
                                objBEBolso.Precio = Convert.ToInt32(row2["Precio"]);
                                objBEBolso.Cantidad = Convert.ToInt32(row2["Cantidad"]);
                                objBEBolso.Capacidad = Convert.ToInt32(row2["Capacidad"]);
                                ListaProductos.Add(objBEBolso);
                            }
                        }

                        objCliente.ListaProductos = ListaProductos;
                    }
                    ListaCliente.Add(objCliente);
                }


            }

            return ListaCliente;
        }
    }
}
