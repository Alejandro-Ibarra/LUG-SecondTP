using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Mapper
{
    public class MUsrProfesor : IGestor<BEUsrProfesor>
    {
        public MUsrProfesor()
        {
            oConexion = new Conexion();
            
        }

        Conexion oConexion;
        Hashtable Hashdatos;

        public bool Guardar(BEUsrProfesor oBEUsrProfesor)
        {
            Hashdatos = new Hashtable();
            string Consulta = "S_Guarda_Usuario";

            if (oBEUsrProfesor.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEUsrProfesor.Codigo);
                Consulta = "S_Modifica_Usuario";
            }
            else
            {
                Hashdatos.Add("@Activo", true);
                Hashdatos.Add("Pass", oBEUsrProfesor.Pass);
            }

            Hashdatos.Add("@Nombre", oBEUsrProfesor.Nombre);
            Hashdatos.Add("@Apellido", oBEUsrProfesor.Apellido);
            Hashdatos.Add("@DNI", oBEUsrProfesor.DNI);
            Hashdatos.Add("@Sexo", oBEUsrProfesor.Sexo);
            Hashdatos.Add("@NroContacto", oBEUsrProfesor.NumenorDeContacto);
            Hashdatos.Add("@Satisfaccion", DBNull.Value);
            

            if (VerificaUsrXDNI(oBEUsrProfesor) == false)

            { return oConexion.Escribir(Consulta, Hashdatos); }

            else
            { return false; }
        }

        private bool VerificaUsrXDNI(BEUsrProfesor oBEUsrProfesor)
        {
            Hashtable Hashdatos2 = new Hashtable();

            if (oBEUsrProfesor.Codigo == 0)
            {
                Hashdatos2.Add("@DNI", oBEUsrProfesor.DNI);

                return oConexion.LeerAsociacion("s_Usuario_Existe_DNI", Hashdatos2);
            }
            else
            { return false; }
        }

        public bool Baja(BEUsrProfesor oBEUsrProfesor)
        {
            Hashdatos = new Hashtable();
            string Consulta = "S_Eliminar_Usuario";
            Hashdatos.Add("@Codigo", oBEUsrProfesor.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);
        }

        public BEUsrProfesor ListarObjeto(BEUsrProfesor oBEUsrProfesor)
        {
            try
            {
                string ConsultaSql = "S_Listar_Un_Usuario";
                Hashdatos = new Hashtable();
                Hashdatos.Add("@DNI", oBEUsrProfesor.DNI);
                DataTable oDataTable = oConexion.LeerDataTable(ConsultaSql, Hashdatos);

                if (oDataTable.Rows.Count > 0)
                {
                    oBEUsrProfesor.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                    oBEUsrProfesor.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                    oBEUsrProfesor.Apellido = oDataTable.Rows[0].ItemArray[2].ToString();
                    oBEUsrProfesor.Sexo = oDataTable.Rows[0].ItemArray[3].ToString();

                }
            }
            catch (Exception ex)
            { throw ex; }
            return oBEUsrProfesor;
        }

        public List<BEUsrProfesor> ListarTodo()
        {

            List<BEUsrProfesor> ListaUsrProfesor = new List<BEUsrProfesor>();

            string Consulta = "S_Listar_Todos_Usuarios";

            DataTable Tabla = oConexion.LeerDataTable(Consulta, null);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    if (fila[6] is int)
                    {
                        BEUsrProfesor oBEUsrProf = new BEUsrProfesor();
                        oBEUsrProf.Codigo = Convert.ToInt32(fila[0]);
                        oBEUsrProf.Nombre = fila[1].ToString();
                        oBEUsrProf.Apellido = fila[2].ToString();
                        oBEUsrProf.DNI = Convert.ToInt32(fila[3]);
                        oBEUsrProf.Sexo = fila[4].ToString();
                        oBEUsrProf.Activo = true;
                        oBEUsrProf.NumenorDeContacto = Convert.ToInt32(fila[6]);
                        ListaUsrProfesor.Add(oBEUsrProf);

                    }
                }
            }
            return ListaUsrProfesor;
        }
    }
}
