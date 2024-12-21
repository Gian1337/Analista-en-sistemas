using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using Abstraccion;
using DAL;

namespace MPP
{
    public class MPPBolso : IGestor<BEBolso>
    {

        public MPPBolso()
        {
            objDatos = new Acceso();
        }

        Acceso objDatos;

        public bool Borrar(BEBolso objBEBolso)
        {
            string query = "Delete from Item where ID_Producto '" + objBEBolso.Codigo + "'";
            return objDatos.Escribir(query);
        }

        public bool Guardar(BEBolso objBEBolso)
        {
            string query = string.Empty;

            if(objBEBolso.Codigo == 0)
            {
                query = "Insert into Item(Descripcion, Marca, Precio, Cantidad, Capacidad, ID_Proveedor) Values('"+ objBEBolso.Descripcion+ "','"+ objBEBolso.Marca + "','" +objBEBolso.Precio + "','" +objBEBolso.Cantidad + "','" + objBEBolso.Capacidad + "','" + objBEBolso.Proveedor.Codigo+ "')";
            }
            else
            {
                query = "Update Item Set Descripcion = '" + objBEBolso.Descripcion + "', Marca = '" + objBEBolso.Marca + "', Precio = '" + objBEBolso.Precio + "', Cantidad = '" + objBEBolso.Cantidad + "', Capacidad  = '" + objBEBolso.Capacidad + "', ID_Proveedor = '" + objBEBolso.Proveedor.Codigo + "' where ID_Producto = '" + objBEBolso.Codigo + "'";
            }
            return objDatos.Escribir(query);
        }

        public List<BEBolso> ListarTodo()
        {
            List<BEBolso> ListaBolso = new List<BEBolso>();
            string query = "Select * from Item, Proveedor where Item.Material is NULL and Item.Talle is NULL and Proveedor.ID_Proveedor = Item.ID_Proveedor";
            DataTable dt = objDatos.Leer(query);

            if(dt.Rows.Count >= 1)
            {
                foreach(DataRow row in dt.Rows)
                {
                    BEBolso objBEBolso = new BEBolso();

                    objBEBolso.Codigo = Convert.ToInt32(row[0]);
                    objBEBolso.Descripcion = Convert.ToString(row[1]);
                    objBEBolso.Marca = Convert.ToString(row["Marca"]);
                    objBEBolso.Precio = Convert.ToInt32(row["Precio"]);
                    objBEBolso.Cantidad = Convert.ToInt32(row["Cantidad"]);
                    objBEBolso.Capacidad = Convert.ToInt32(row["Capacidad"]);


                    BEProveedor objBEProveedor = new BEProveedor();

                    objBEProveedor.Codigo = Convert.ToInt32(row[0]);
                    objBEProveedor.RazonSocial = Convert.ToString(row["Razon_Social"]);
                    objBEProveedor.CUIT = Convert.ToString(row["CUIT"]);

                    objBEBolso.Proveedor = objBEProveedor;
                    ListaBolso.Add(objBEBolso);
                }
            }
            return ListaBolso;
        }

        public bool GuardarProducto_Cliente(BECliente objBECliente, BEBolso objBEBolso)
        {
            if (objBECliente.Codigo != 0 && objBEBolso.Codigo != 0)
            {
                string query = "Insert into Producto_Cliente(ID_Producto, ID_Cliente, CantidadComprada) Values('" + objBEBolso.Codigo + "','" + objBECliente.Codigo + "','" + objBEBolso.Cantidad + "')";
                return objDatos.Escribir(query);
            }
            else return false;
        }
    }
}
