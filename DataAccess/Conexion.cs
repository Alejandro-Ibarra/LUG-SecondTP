using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Conexion
    {

        private SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString());


        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta, oConexion);
                Da.Fill(tabla);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { 
                oConexion.Close();
            }
            return tabla;
        }

        public bool Escribir(string Consulta_SQL)
        {

            oConexion.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = oConexion;
            command.CommandText = Consulta_SQL;
            try
            {
                int respuesta = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            { oConexion.Close(); }
        }
    }
}
