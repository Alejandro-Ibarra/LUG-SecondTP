using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Abstraction;
using BusinnesEntity;
using DataAccess;
using System.Collections;

namespace Mapper
{
    public class MMateriales : IGestor<BEMaterial>
    {
        Conexion oConexion;
        Hashtable Hashdatos;

        public MMateriales()
        {
            oConexion = new Conexion();
            Hashdatos = new Hashtable();
        }

        public bool Baja(BEMaterial oBEMaterial)
        {
            if (ExisteMaterialAsociado(oBEMaterial) == false)
            {
                string Consulta = "S_Eliminar_Material";
                Hashdatos.Add("@Codigo", oBEMaterial.Codigo);

                return oConexion.Escribir(Consulta, Hashdatos);
            }
            else { return false; }
        }

        private bool ExisteMaterialAsociado(BEMaterial oBEMaterial)
        {

            Hashtable Hashdatos2 = new Hashtable();

            if (oBEMaterial.Codigo == 0)
            {
                Hashdatos2.Add("@DNI", oBEMaterial.Codigo);

                return oConexion.LeerAsociacion("S_Verifia_Material_En_Uso", Hashdatos2);
            }
            else
            { return false; }

        }

        public bool Guardar(BEMaterial oBEMaterial)
        {

            Hashdatos = new Hashtable();
            string Consulta_SQL = "S_Guarda_Material";

            if (oBEMaterial.Codigo != 0)
            {
                Hashdatos.Add("@Codigo", oBEMaterial.Codigo);
                Consulta_SQL = "S_Modifica_Material";
            }

            Hashdatos.Add("@Peso", oBEMaterial.Peso);
            Hashdatos.Add("@Nombre", oBEMaterial.Nombre);
            Hashdatos.Add("@Activo", true);

            return oConexion.Escribir(Consulta_SQL, Hashdatos);

        }

        public BEMaterial ListarObjeto(BEMaterial oBEMaterial)
        {
            throw new NotImplementedException();
        }

        public List<BEMaterial> ListarTodo()
        {

            List<BEMaterial> ListaMateriales = new List<BEMaterial>();
            DataTable oDAtaTable = oConexion.LeerDataTable("S_Lista_Todos_Materiales", null);
            try
            {
                if (oDAtaTable.Rows.Count > 0)
                {
                    foreach (DataRow item in oDAtaTable.Rows)
                    {
                        BEMaterial oBEMateriales = new BEMaterial();
                        oBEMateriales.Codigo = Convert.ToInt32(item[0]);
                        oBEMateriales.Nombre = item[1].ToString();
                        oBEMateriales.Peso = Convert.ToInt32(item[2]);
                        ListaMateriales.Add(oBEMateriales);
                    }
                }
                else
                {
                    ListaMateriales = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
            return ListaMateriales;
        }
    }
}
