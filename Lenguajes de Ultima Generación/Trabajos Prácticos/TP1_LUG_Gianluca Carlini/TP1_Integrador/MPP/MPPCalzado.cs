using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Abstraccion;
using System.Data;

namespace MPP
{
    public class MPPCalzado : IGestor<BECalzado>
    {

        public MPPCalzado()
        {
            objDatos = new Acceso();
        }

        Acceso objDatos;
        public bool Borrar(BECalzado objBECalzado)
        {
            string query = "Delete from Item where ID_Producto= '" + objBECalzado + "'";
            return objDatos.Escribir(query);
        }

        public bool Guardar(BECalzado objBECalzado)
        {
            string query = string.Empty;

            if(objBECalzado.Codigo == 0)
            {
                query = "Insert into Item(Descripcion, Marca, Precio, Cantidad, Material, ID_Proveedor) Values('" + objBECalzado.Descripcion + "', '" + objBECalzado.Marca + "', '" + objBECalzado.Precio + "', '" + objBECalzado.Cantidad + "', '" + objBECalzado.Material + "', '" + objBECalzado.Talle + "', '" + objBECalzado.Proveedor.Codigo + "')";
            }
            else
            {
                query = "Update Item Set Descripcion = '" + objBECalzado.Descripcion + "', Marca = '" + objBECalzado.Marca + "', Precio = '" + objBECalzado.Precio + "', Marca = '" + objBECalzado.Cantidad + "', Material = '" + objBECalzado.Material + "', Proveedor = '" + objBECalzado.Proveedor.Codigo + "' where ID_Producto '" + objBECalzado.Codigo+"'";
            }
            return objDatos.Escribir(query);
        }

        public List<BECalzado> ListarTodo()
        {
            List<BECalzado> ListaCalzado = new List<BECalzado>();

            string query = "Select * from Item, Proveedor where Item.Capacidad is NULL and Proveedor.ID_Proveedor = Item.ID_Proveedor";
            DataTable dt = objDatos.Leer(query);

            if(dt.Rows.Count >= 1)
            {
                foreach(DataRow row in dt.Rows)
                {
                    BECalzado objBECalzado = new BECalzado();
                    objBECalzado.Codigo = Convert.ToInt32(row[0]);
                    objBECalzado.Descripcion = Convert.ToString(row[1]);
                    objBECalzado.Marca = Convert.ToString(row["Marca"]);
                    objBECalzado.Precio = Convert.ToInt32(row["Precio"]);
                    objBECalzado.Cantidad = Convert.ToInt32(row["Cantidad"]);
                    objBECalzado.Material = Convert.ToString(row["Material"]);
                    objBECalzado.Talle = Convert.ToInt32(row["Talle"]);

                    BEProveedor objBEProveedor = new BEProveedor();
                    objBEProveedor.Codigo = Convert.ToInt32(row[0]);
                    objBEProveedor.RazonSocial = Convert.ToString(row[1]);
                    objBEProveedor.CUIT = Convert.ToString(row["CUIT"]);
                    objBECalzado.Proveedor = objBEProveedor;
                    ListaCalzado.Add(objBECalzado);
                }
            }

            return ListaCalzado;
        }

        public bool GuardarProducto_Cliente(BECliente objBECliente, BECalzado objBECalzado)
        {
            if (objBECalzado.Codigo != 0 && objBECliente.Codigo != 0)
            {
                string query = "Insert into Producto_Cliente(ID_Producto, ID_Cliente, CantidadComprada) Values('" + objBECalzado.Codigo + "','" + objBECliente.Codigo + "','" + objBECalzado.Cantidad + "')";
                return objDatos.Escribir(query);
            }
            else return false;
        }
    }
}
