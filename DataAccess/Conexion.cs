using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinnesEntity;

namespace DataAccess
{
    public class Conexion
    {

        private SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString());


        public DataTable LeerTabla(string Consulta_SQL)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(Consulta_SQL, oConexion);
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

        public BEUsuario LeerUsuario(string Consulta_SQL)
        {
            oConexion.Open();
            BEUsuario oBEUsuario = new BEUsuario();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = Consulta_SQL;
            command.Connection = oConexion;
            try 
            {
                SqlDataReader usuarioRecuperado = command.ExecuteReader();

                usuarioRecuperado.Read();
                oBEUsuario.Codigo = Convert.ToInt32(usuarioRecuperado[0]);
                oBEUsuario.Nombre = usuarioRecuperado[1].ToString();
                oBEUsuario.Apellido = usuarioRecuperado[2].ToString();
                oBEUsuario.Sexo = usuarioRecuperado[3].ToString();

            }
            catch (SqlException ex)
            {throw ex;}
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
            return oBEUsuario;
        }

        public bool Escribir(string Consulta_SQL)
        {
            oConexion.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = Consulta_SQL;
            command.Connection = oConexion;
            try
            {
                int respuesta = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {throw ex;}
            catch (Exception ex)
            { throw ex; }
            finally
            { 
                oConexion.Close(); 
            }
        }

        public bool LeerAsociacion(string Consulta_SQL)
        {
            oConexion.Open();
            SqlCommand command = new SqlCommand(Consulta_SQL, oConexion);
            command.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(command.ExecuteScalar());
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
        }
    }
}
