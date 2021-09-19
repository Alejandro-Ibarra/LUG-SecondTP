using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Abstraction;
using BusinnesEntity;
using DataAccess;

namespace Mapper
{
    public class MMateriales : IGestor<BEMaterial>
    {
        Conexion oConexion;

        public bool Baja(BEMaterial oBEMaterial)
        {
            if (ExisteMaterialAsociado(oBEMaterial) == false)
            {
                string Consulta_SQL;
                Consulta_SQL = "DELETE FROM Materiales where Codigo = " + oBEMaterial.Codigo + "";
                oConexion = new Conexion();
                return oConexion.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }

        private bool ExisteMaterialAsociado(BEMaterial oBEMaterial)
        {
            oConexion = new Conexion();
            return oConexion.LeerAsociacion("select count(CodMateriales) from Ejercicio where CodMateriales =" + oBEMaterial.Codigo + "");
        }

        public bool Guardar(BEMaterial oBEMaterial)
        {
            string Consulta_SQL;
            if (oBEMaterial.Codigo == 0)
            {
                Consulta_SQL = "Insert into Materiales (Nombre, Peso)values('" + oBEMaterial.Nombre + "' , '" + oBEMaterial.Peso + "' )";
            }
            else
            {
                Consulta_SQL = "update Materiales SET Nombre = '" + oBEMaterial.Nombre + "',  Peso = '" + oBEMaterial.Peso + "'where Codigo = " + oBEMaterial.Codigo + "";
            }

            oConexion = new Conexion();
            return oConexion.Escribir(Consulta_SQL);
        }

        public BEMaterial ListarObjeto(BEMaterial oBEMaterial)
        {
            throw new NotImplementedException();
        }

        public List<BEMaterial> ListarTodo()
        {
            DataTable oDAtaTable;
            oConexion = new Conexion();
            oDAtaTable = oConexion.LeerDataTable("Select Codigo, Nombre, Peso From Materiales");

            List<BEMaterial> ListaMateriales = new List<BEMaterial>();

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
            return ListaMateriales;
        }
    }
}
