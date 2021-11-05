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
    public class MUsrAlumno : IGestor<BEUsrAlumno>
    {
        public MUsrAlumno()
        {
            oConexion = new Conexion();
            Hashdatos = new Hashtable();
        }

        Conexion oConexion;
        Hashtable Hashdatos;

        public bool Guardar(BEUsrAlumno oBEUsrAlumno)
        {
            Hashdatos = new Hashtable();
            string Consulta = "S_Guarda_Usuario";

            if (oBEUsrAlumno.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEUsrAlumno.Codigo);
                Consulta = "S_Modifica_Usuario";
            }
            else
            {
                Hashdatos.Add("@Activo", true);
                Hashdatos.Add("Pass", oBEUsrAlumno.Pass);
            }

            Hashdatos.Add("@Nombre", oBEUsrAlumno.Nombre);
            Hashdatos.Add("@Apellido", oBEUsrAlumno.Apellido);
            Hashdatos.Add("@DNI", oBEUsrAlumno.DNI);
            Hashdatos.Add("@Sexo", oBEUsrAlumno.Sexo);
            Hashdatos.Add("@NroContacto", DBNull.Value);
            Hashdatos.Add("@Satisfaccion", oBEUsrAlumno.Satisfaccion);

            if (VerificaUsrXDNI(oBEUsrAlumno) == false)

            { return oConexion.Escribir(Consulta, Hashdatos); }

            else
            { return false; }
        }

        private bool VerificaUsrXDNI(BEUsrAlumno oBEUsrAlumno)
        {
            Hashtable Hashdatos2 = new Hashtable();

            if (oBEUsrAlumno.Codigo == 0)
            {
                Hashdatos2.Add("@DNI", oBEUsrAlumno.DNI);

                return oConexion.LeerAsociacion("s_Usuario_Existe_DNI", Hashdatos2);
            }
            else
            { return false; }
        }

        public bool Baja(BEUsrAlumno oBEUsrAlumno)
        {

            if (oBEUsrAlumno.Materiales != null)
            {
                foreach (BEMaterial Material in oBEUsrAlumno.Materiales)
                {
                    Hashtable Hash2 = new Hashtable();
                    Hash2.Add("@CodigoUsr", oBEUsrAlumno.Codigo);
                    Hash2.Add("@CodigoMat", Material.Codigo);

                    string Consulta2 = "S_Desasocia_Material_De_Usuario";

                    oConexion.Escribir(Consulta2, Hash2);
                }
            }
            string Consulta = "S_Eliminar_Usuario";
            Hashdatos.Add("@IdCliente", oBEUsrAlumno.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);
        }

        public BEUsrAlumno ListarObjeto(BEUsrAlumno oBEUsrAlumno)
        {
            try
            {
                string ConsultaSql = "S_Listar_Un_Usuario";
                Hashdatos = new Hashtable();
                Hashdatos.Add("@DNI", oBEUsrAlumno.DNI);
                DataTable oDataTable = oConexion.LeerDataTable(ConsultaSql, Hashdatos);

                if (oDataTable.Rows.Count > 0)
                {
                    oBEUsrAlumno.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                    oBEUsrAlumno.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                    oBEUsrAlumno.Apellido = oDataTable.Rows[0].ItemArray[2].ToString();
                    oBEUsrAlumno.Sexo = oDataTable.Rows[0].ItemArray[3].ToString();

                    string ConsultaSql2 = "S_Listar_Material_De_Usuario";
                    Hashtable Hashdatos2 = new Hashtable();
                    Hashdatos2.Add("@Codigo", oBEUsrAlumno.DNI);
                    DataTable oDataTable2 = oConexion.LeerDataTable(ConsultaSql2, Hashdatos2);

                    if (oDataTable2.Rows.Count > 0)
                    {
                        List<BEMaterial> ListaMateriales = new List<BEMaterial>();
                        foreach (DataRow fila in oDataTable2.Rows)
                        {
                            BEMaterial oBEMat = new BEMaterial();
                            oBEMat.Codigo = Convert.ToInt32(fila[0]);
                            oBEMat.Nombre = fila[1].ToString();
                            oBEMat.Peso = Convert.ToInt32(fila[2]);
                            ListaMateriales.Add(oBEMat);
                        }
                        oBEUsrAlumno.Materiales = ListaMateriales;
                    }
                    else
                    { oBEUsrAlumno.Materiales = null; }
                }
            }
            catch (Exception ex)
            { throw ex; }
            return oBEUsrAlumno;
        }

        public bool AgregarUsuarioMaterial(BEUsrAlumno oBEUsrAlumno, BEMaterial oBEMaterial)
        {

            Hashdatos = new Hashtable();

            string Consulta = "S_Guarda_Material_De_Usuario";
            Hashdatos.Add("@CodigoUsr", oBEUsrAlumno.Codigo);
            Hashdatos.Add("@CodigoMat", oBEMaterial.Codigo);
            Hashdatos.Add("@Activo", true);

            return oConexion.Escribir(Consulta, Hashdatos);

        }

        public bool EliminarMaterialAsociado(BEUsrAlumno oBEUsrAlumno, BEMaterial oBEMaterial)
        {
            Hashdatos = new Hashtable();

            string Consulta = "S_Desasocia_Material_De_Usuario";
            Hashdatos.Add("@CodigoUsr", oBEUsrAlumno.Codigo);
            Hashdatos.Add("@CodigoMat", oBEMaterial.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);

        }

        public List<BEUsrAlumno> ListarTodo()
        {
            List<BEUsrAlumno> ListaUsrAlumnos = new List<BEUsrAlumno>();

            string Consulta = "S_Listar_Todos_Usuarios";

            DataTable Tabla = oConexion.LeerDataTable(Consulta, null);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    if (fila[7] is int)
                    {
                        BEUsrAlumno oBEUsrAl = new BEUsrAlumno();
                        oBEUsrAl.Codigo = Convert.ToInt32(fila[0]);
                        oBEUsrAl.Nombre = fila[1].ToString();
                        oBEUsrAl.Apellido = fila[2].ToString();
                        oBEUsrAl.DNI = Convert.ToInt32(fila[3]);
                        oBEUsrAl.Sexo = fila[4].ToString();
                        oBEUsrAl.Activo = true;
                        oBEUsrAl.Satisfaccion = Convert.ToInt32(fila[7]);
                        ListaUsrAlumnos.Add(oBEUsrAl);

                    }
                }
            }
            return ListaUsrAlumnos;
        }
    }
}
