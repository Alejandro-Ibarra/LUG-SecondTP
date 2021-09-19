using System;
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
    public class MMusculo : IGestor<BEMusculo>
    {
        Conexion oConexion;

        public bool Baja(BEMusculo oBEMusculo)
        {
            if (ExisteEjercicioAsociado(oBEMusculo) == false)
            {
                string Consulta_SQL;
                Consulta_SQL = "DELETE FROM Musculo where Codigo = " + oBEMusculo.Codigo + "";
                oConexion = new Conexion();
                return oConexion.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }

        private bool ExisteEjercicioAsociado(BEMusculo oBEMusculo)
        {
            oConexion = new Conexion();
            return oConexion.LeerAsociacion("select count(CodMusculo) from Ejercicio where CodMusculo =" + oBEMusculo.Codigo + "");
        }

        public bool Guardar(BEMusculo oBEMusculo)
        {
            string Consulta_SQL;
            if (oBEMusculo.Codigo == 0)
            {
                Consulta_SQL = "Insert into Musculo (Nombre)values('" + oBEMusculo.Nombre + "' )";
            }
            else
            {
                Consulta_SQL = "update Musculo SET Nombre = '" + oBEMusculo.Nombre + "'where Codigo = " + oBEMusculo.Codigo + "";
            }

            oConexion = new Conexion();
            return oConexion.Escribir(Consulta_SQL);
        }

        public BEMusculo ListarObjeto(BEMusculo oBEMusculo)
        {
            throw new NotImplementedException();
        }

        public List<BEMusculo> ListarTodo()
        {
            DataTable oDAtaTable;
            oConexion = new Conexion();
            oDAtaTable = oConexion.LeerDataTable("Select Codigo, Nombre From Musculo");

            List<BEMusculo> ListaMusculo = new List<BEMusculo>();

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
            return ListaMusculo;
        }
    }
}
