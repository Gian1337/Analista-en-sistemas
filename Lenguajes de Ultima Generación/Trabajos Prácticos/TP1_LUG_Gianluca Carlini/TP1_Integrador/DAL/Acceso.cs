using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SQL 
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection objConn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = TP1_Integrador; Integrated Security = True");

        public string TestConnection()
        {
            objConn.Open();
           
            if (objConn.State == ConnectionState.Open)
            {
                return "Conexion a la BD OK";
            }
            else
            {
                return "No se pudo conectar a la BD";
            }
        }
        public DataTable Leer(string Consulta)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(Consulta, objConn);
                DA.Fill(dt);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally
            {
                objConn.Close();
            }
            return dt;
        }


        public bool Escribir(string Consulta)
        {
            objConn.Open();
            SqlCommand comando = new SqlCommand(Consulta, objConn);
            comando.CommandType = CommandType.Text;
            try
            {
                int valor = comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally
            {
                objConn.Close();
            }
        }


        public bool LeerScalar(string Consulta)
        {
            objConn.Open();
            SqlCommand comando = new SqlCommand(Consulta, objConn);
            comando.CommandType = CommandType.Text;
            try
            {
                int valor = Convert.ToInt32(comando.ExecuteScalar());
                if (valor > 0) return true;
                else return false;

            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally
            {
                objConn.Close();
            }
        }
    }
}
