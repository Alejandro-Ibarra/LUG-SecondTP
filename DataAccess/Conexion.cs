using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinnesEntity;
using System.Collections;

namespace DataAccess
{
    public class Conexion
    {

        private SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString());
        string CadenaC = @ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString();
        private SqlTransaction Tranx;
        private SqlCommand Cmd;

        public DataTable LeerDataTable(string Consulta_SQL, Hashtable Hashdatos)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter Da;
            Cmd = new SqlCommand(Consulta_SQL, oConexion);
            Cmd.CommandType = CommandType.StoredProcedure;

            if (oConexion.State == ConnectionState.Closed)
            {
                oConexion.ConnectionString = CadenaC;
                oConexion.Open();
            }
            try
            {
                Da = new SqlDataAdapter(Cmd);
                if ((Hashdatos != null))
                {
                    foreach (string dato in Hashdatos.Keys)
                    {
                        Cmd.Parameters.AddWithValue(dato, Hashdatos[dato]);
                    }
                }

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { 
                oConexion.Close();
            }
            Da.Fill(tabla);
            return tabla;
        }

       /* public DataSet LeerDataSet(string Consulta_SQL)
        {
            DataSet oDataSet = new DataSet();
            try
            {
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(Consulta_SQL, oConexion);
                oDataAdapter.Fill(oDataSet);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                oConexion.Close();
            }
            return oDataSet;
        }*/

        public bool Escribir(string Consulta_SQL, Hashtable Hashdatos)
        {
            if (oConexion.State == ConnectionState.Closed)
            {
                oConexion.ConnectionString = CadenaC;
                oConexion.Open();
            }

            try
            {
                Tranx = oConexion.BeginTransaction();
                Cmd = new SqlCommand(Consulta_SQL, oConexion, Tranx);
                Cmd.CommandType = CommandType.StoredProcedure;

                if ((Hashdatos != null))
                {
                    foreach (string dato in Hashdatos.Keys)
                    {
                        Cmd.Parameters.AddWithValue(dato, Hashdatos[dato]);
                    }
                }

                int respuesta = Cmd.ExecuteNonQuery();
                Tranx.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                Tranx.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                Tranx.Rollback();
                return false;
                throw ex;
            }
            finally
            { 
                oConexion.Close(); 
            }
        }






        public bool LeerAsociacion(string Consulta_SQL, Hashtable Hdatos)
        {
            if (oConexion.State == ConnectionState.Closed)
            {
                oConexion.ConnectionString = CadenaC;
                oConexion.Open();
            }
            Cmd = new SqlCommand(Consulta_SQL, oConexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                if ((Hdatos != null))
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
                int Respuesta = Convert.ToInt32(Cmd.ExecuteScalar());
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
