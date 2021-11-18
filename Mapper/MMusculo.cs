using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;

namespace Mapper
{
    public class MMusculo
    {

        Conexion oConexion;
        Hashtable Hashdatos;

        public MMusculo()
        {
            oConexion = new Conexion();
            
        }

        public bool Baja(BEMusculo oBEMusculo)
        {

            if (ExisteEjercicioAsociado(oBEMusculo) == false)
            {
                Hashdatos = new Hashtable();
                string Consulta = "S_Eliminar_Musculo";
                Hashdatos.Add("@Codigo", oBEMusculo.Codigo);

                return oConexion.Escribir(Consulta, Hashdatos);
            }
            else { return false; }

        }

        private bool ExisteEjercicioAsociado(BEMusculo oBEMusculo)
        {

            Hashtable Hashdatos2 = new Hashtable();

            if (oBEMusculo.Codigo != 0)
            {
                Hashdatos2.Add("@Codigo", oBEMusculo.Codigo);

                return oConexion.LeerAsociacion("S_verifia_Musculo_En_Uso", Hashdatos2);
            }
            else
            { return false; }
        }

        public bool Guardar(BEMusculo oBEMusculo)
        {
            Hashdatos = new Hashtable();
            string Consulta_SQL = "S_Guarda_Musculo";


            if (oBEMusculo.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEMusculo.Codigo);
                Consulta_SQL = "S_Modifica_Musculo";
            }
            Hashdatos.Add("@Nombre", oBEMusculo.Nombre);
            Hashdatos.Add("@Activo", true);

            return oConexion.Escribir(Consulta_SQL, Hashdatos); 

        }

        public BEMusculo ListarObjeto(BEMusculo oBEMusculo)
        {
            throw new NotImplementedException();
        }

        public List<BEMusculo> ListarTodo()
        {
            List<BEMusculo> ListaMusculo = new List<BEMusculo>();
            DataTable oDAtaTable = oConexion.LeerDataTable("S_Lista_Todos_Musculos", null);
            try
            {
                if (oDAtaTable.Rows.Count > 0)
                {
                    foreach (DataRow item in oDAtaTable.Rows)
                    {
                        BEMusculo oBEMusculo = new BEMusculo();
                        oBEMusculo.Codigo = Convert.ToInt32(item[0]);
                        oBEMusculo.Nombre = item[1].ToString();
                        ListaMusculo.Add(oBEMusculo);
                    }
                }
                else
                {
                    ListaMusculo = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
            return ListaMusculo;
        }
    }
}
