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
    public class MMateriales : IGestor<BEMateriales>
    {
        Conexion oConexion;

        public bool Baja(BEMateriales oBEMaterial)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEMateriales oBEMaterial)
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

        public BEMateriales ListarObjeto(BEMateriales oBEMaterial)
        {
            throw new NotImplementedException();
        }

        public List<BEMateriales> ListarTodo()
        {
            DataTable oDAtaTable;
            oConexion = new Conexion();
            oDAtaTable = oConexion.LeerTabla("Select Codigo, Nombre, Peso From Materiales");

            List<BEMateriales> ListaMateriales = new List<BEMateriales>();

            if (oDAtaTable.Rows.Count > 0)
            {
                foreach (DataRow item in oDAtaTable.Rows)
                {
                    BEMateriales oBEMateriales = new BEMateriales();
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
