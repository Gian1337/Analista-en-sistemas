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
    public class MPPProveedor : IGestor<BEProveedor>
    {

        Acceso objDatos;
        public MPPProveedor()
        {
            objDatos = new Acceso();
        }


        public bool Borrar(BEProveedor obj)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEProveedor objBEProveedor)
        {
            string query = "insert into Proveedor(Razon_Social, CUIT) values ('" + objBEProveedor.RazonSocial + "', '" + objBEProveedor.CUIT + "')";

            return objDatos.Escribir(query);
        }

        public List<BEProveedor> ListarTodo()
        {
            List<BEProveedor> ListaProveedores = new List<BEProveedor>();
            string query = "SELECT ID_Proveedor, Razon_Social, CUIT FROM Proveedor";
            DataTable Dtable = objDatos.Leer(query);
            if(Dtable.Rows.Count >= 0)
            {
                foreach(DataRow row in Dtable.Rows)
                {
                    BEProveedor objBEProveedor = new BEProveedor();
                    objBEProveedor.Codigo = Convert.ToInt32(row["ID_Proveedor"]);
                    objBEProveedor.RazonSocial = Convert.ToString(row["Razon_Social"]);
                    objBEProveedor.CUIT = Convert.ToString(row["CUIT"]);
                    ListaProveedores.Add(objBEProveedor);
                }
            }

            return ListaProveedores;
        }
    }
}
