using Abstraction;
using BusinnesEntity;
using DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mapper
{
    public class MEjercicio : IGestor<BEEjercicio>
    {
        public MEjercicio()
        {
            oConexion = new Conexion();
            Hashdatos = new Hashtable();
        }

        Conexion oConexion;
        Hashtable Hashdatos;

        #region ABM
        public bool Baja(BEEjercicio oBEEjercicio)
        {
            string Consulta = "S_Eliminar_Ejercicio";
            Hashdatos.Add("@@Codigo", oBEEjercicio.Codigo);

            return oConexion.Escribir(Consulta, Hashdatos);
        }

        public bool Guardar(BEEjercicio oBEEjercicio)
        {
            Hashdatos = new Hashtable();
            string Consulta = "S_Guardar_Ejercicio";

            if (oBEEjercicio.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEEjercicio.Codigo);
                Consulta = "S_Modificar_Ejercicio";
            }

            Hashdatos.Add("@Nombre", oBEEjercicio.Nombre);
            Hashdatos.Add("@CodMaterial", oBEEjercicio.Materiales.Codigo);
            Hashdatos.Add("@CodMusculo", oBEEjercicio.Musculo.Codigo);
            Hashdatos.Add("@Activo", true);

            return oConexion.Escribir(Consulta, Hashdatos);
        }
        #endregion

        public BEEjercicio ListarObjeto(BEEjercicio oBEEjercicio)
        {
            try
            {
                string ConsultaSql = "S_Ejercicio_Con_Musculo";
                Hashdatos = new Hashtable();
                Hashdatos.Add("@Codigo", oBEEjercicio.Codigo);
                DataTable oDataTable = oConexion.LeerDataTable(ConsultaSql, Hashdatos);

                BEEjercicio oBEEj = new BEEjercicio();

                if (oDataTable.Rows.Count > 0)
                {
                    BEMusculo oBEMusc = new BEMusculo();

                    oBEEj.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                    oBEEj.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                    oBEMusc.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[2]);
                    oBEMusc.Nombre = oDataTable.Rows[0].ItemArray[3].ToString();
                    oBEEj.Musculo = oBEMusc;

                    string ConsultaSql2 = "S_Material_Del_Ejercicio";
                    Hashtable Hashdatos2 = new Hashtable();
                    Hashdatos2.Add("@Codigo", oBEEjercicio.Codigo);
                    DataTable oDataTable2 = oConexion.LeerDataTable(ConsultaSql2, Hashdatos2);

                    if (oDataTable2.Rows.Count > 0)
                    {
                        List<BEMaterial> ListaMateriales = new List<BEMaterial>();
                        foreach (DataRow fila in oDataTable2.Rows)
                        {
                            BEMaterial oBEMat = new BEMaterial();
                            oBEMat.Codigo = Convert.ToInt32(oDataTable2.Rows[0].ItemArray[0]);
                            oBEMat.Nombre = oDataTable2.Rows[0].ItemArray[1].ToString();
                            oBEMat.Peso = Convert.ToInt32(oDataTable2.Rows[0].ItemArray[2]);
                            oBEEj.Materiales = oBEMat;
                        }
                    }
                }
                else
                {
                    oBEEj = null;
                }
                return oBEEj;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<BEEjercicio> ListarTodo()
        {

            List<BEEjercicio> ListaEjercicio = new List<BEEjercicio>();
            DataTable oDAtaTable = oConexion.LeerDataTable("S_Listar_Todos_Ejer_Completo", null);
            try
            {
                if (oDAtaTable.Rows.Count > 0)
                {
                    foreach (DataRow fila in oDAtaTable.Rows)
                    {
                        BEEjercicio oBEEj = new BEEjercicio();
                        BEMusculo oBEMusc = new BEMusculo();
                        BEMaterial oBEMat = new BEMaterial();
                        oBEEj.Codigo = Convert.ToInt32(fila[0]);
                        oBEEj.Nombre = fila[1].ToString();
                        oBEMusc.Codigo = Convert.ToInt32(fila[2]);
                        oBEMusc.Nombre = fila[3].ToString();
                        oBEEj.Musculo = oBEMusc;
                        oBEMat.Codigo = Convert.ToInt32(fila[4]);
                        oBEMat.Nombre = fila[5].ToString();
                        oBEMat.Peso = Convert.ToInt32(fila[6]);
                        oBEEj.Materiales = oBEMat;
                        ListaEjercicio.Add(oBEEj);
                    }
                }
                else
                { ListaEjercicio = null; }
            }
            catch (Exception ex)
            { throw ex; }


            return ListaEjercicio;

        }
    }
}
