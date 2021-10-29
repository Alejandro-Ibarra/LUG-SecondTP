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
    public class MUsuario : IGestor<BEUsuario>
    {
        public MUsuario()
        {
            oConexion = new Conexion();
            Hashdatos = new Hashtable();
        }

        Conexion oConexion;
        Hashtable Hashdatos;

        public bool Guardar(BEUsuario oBEUsuario)
        {
            Hashdatos = new Hashtable();
            string Consulta = "S_Guarda_Usuario";

            if (oBEUsuario.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEUsuario.Codigo);
                Consulta = "S_Modifica_Usuario";
            }

            Hashdatos.Add("@Nombre", oBEUsuario.Nombre);
            Hashdatos.Add("@Apellido", oBEUsuario.Apellido);
            Hashdatos.Add("@DNI", oBEUsuario.DNI);
            Hashdatos.Add("@Sexo", oBEUsuario.Sexo);
            Hashdatos.Add("@Activo", true);

            if (VerificaUsrXDNI(oBEUsuario) == false)

            { return oConexion.Escribir(Consulta, Hashdatos); }

            else
            { return false; }
        }

        private bool VerificaUsrXDNI(BEUsuario oBEUsuario)
        {
            Hashtable Hashdatos2 = new Hashtable();

            if (oBEUsuario.Codigo == 0)
            {
                Hashdatos2.Add("@DNI", oBEUsuario.DNI);

                return oConexion.LeerAsociacion("s_Usuario_Existe_DNI", Hashdatos2);
            }
            else
            { return false; }
        }

        public bool Baja(BEUsuario oBEUsuario)
        {
            
            if (oBEUsuario.Materiales != null)
            {
                foreach (BEMaterial Material in oBEUsuario.Materiales)
                {
                    Hashtable Hash2 = new Hashtable();
                    Hash2.Add("@CodigoUsr", oBEUsuario.Codigo);
                    Hash2.Add("@CodigoMat", Material.Codigo);

                    string Consulta2 = "S_Desasocia_Material_De_Usuario";
                    
                    oConexion.Escribir(Consulta2, Hash2);
                }
            }
            string Consulta = "S_Eliminar_Usuario";
            Hashdatos.Add("@IdCliente", oBEUsuario.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);
        }
    
        public BEUsuario ListarObjeto(BEUsuario oBEUsuario)
        {
            try
            {
                string ConsultaSql = "S_Listar_Un_Usuario";
                Hashdatos = new Hashtable();
                Hashdatos.Add("@DNI", oBEUsuario.DNI);
                DataTable oDataTable = oConexion.LeerDataTable(ConsultaSql, Hashdatos);

                if (oDataTable.Rows.Count > 0)
                {
                    oBEUsuario.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                    oBEUsuario.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                    oBEUsuario.Apellido = oDataTable.Rows[0].ItemArray[2].ToString();
                    oBEUsuario.Sexo = oDataTable.Rows[0].ItemArray[3].ToString();

                    string ConsultaSql2 = "S_Listar_Material_De_Usuario";
                    Hashtable Hashdatos2 = new Hashtable();
                    Hashdatos2.Add("@Codigo", oBEUsuario.DNI);
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
                        oBEUsuario.Materiales = ListaMateriales;
                    }
                    else
                    { oBEUsuario.Materiales = null; }
                }
            }
            catch (Exception ex)
            { throw ex; }
            return oBEUsuario;
        }

        public bool AgregarUsuarioMaterial(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {

            Hashdatos = new Hashtable();

            string Consulta = "S_Guarda_Material_De_Usuario";
            Hashdatos.Add("@CodigoUsr", oBEusuario.Codigo);
            Hashdatos.Add("@CodigoMat", oBEMaterial.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);

        }

        public bool EliminarMaterialAsociado(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {
            Hashdatos = new Hashtable();

            string Consulta = "S_Desasocia_Material_De_Usuario";
            Hashdatos.Add("@CodigoUsr", oBEusuario.Codigo);
            Hashdatos.Add("@CodigoMat", oBEMaterial.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);

        }
        
        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }


    }
}
