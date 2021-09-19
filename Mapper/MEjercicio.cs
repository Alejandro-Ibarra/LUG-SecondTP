using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;
using System.Data;

namespace Mapper
{
    public class MEjercicio : IGestor<BEEjercicio>
    {
        Conexion oConexion;

        public bool Baja(BEEjercicio oBEEjercicio)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEEjercicio oBEEjercicio)
        {
            string Consulta_SQL;
            if (oBEEjercicio.Codigo == 0)
            {
                Consulta_SQL = "Insert into Ejercicio (Nombre, CodMateriales, CodMusculo)values('" + oBEEjercicio.Nombre + "','" + oBEEjercicio.Materiales.Codigo + "','" + oBEEjercicio.Musculo.Codigo + "' )";
            }
            else
            {
                Consulta_SQL = "update Ejercicio SET Nombre = '" + oBEEjercicio.Nombre + "', CodMateriales = '" + oBEEjercicio.Materiales.Codigo + "', CodMusculo = '" + oBEEjercicio.Musculo.Codigo + "'    where Codigo = " + oBEEjercicio.Codigo + "";
            }

            oConexion = new Conexion();
            return oConexion.Escribir(Consulta_SQL);
            
            
        }
       
        public BEEjercicio ListarObjeto(BEEjercicio oBEEjercicio)
        {
            string Consulta_Sql = " Select Ejercicio.Codigo, Ejercicio.Nombre, Musculo.Codigo as CodMusculo, Musculo.Nombre as NombreMusculo from Ejercicio, Musculo " +
                                        "where Ejercicio.Codigo = " + oBEEjercicio.Codigo + " and Ejercicio.CodMusculo = Musculo.Codigo";
            DataTable oDataTable;
            Conexion oConexion = new Conexion();
            oDataTable = oConexion.LeerDataTable(Consulta_Sql);
            BEEjercicio oBEEj = new BEEjercicio();

            if (oDataTable.Rows.Count > 0)
            {
                BEMusculo oBEMusc = new BEMusculo();

                oBEEj.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[0]);
                oBEEj.Nombre = oDataTable.Rows[0].ItemArray[1].ToString();
                oBEMusc.Codigo = Convert.ToInt32(oDataTable.Rows[0].ItemArray[2]);
                oBEMusc.Nombre = oDataTable.Rows[0].ItemArray[3].ToString();
                oBEEj.Musculo = oBEMusc;
                DataTable oDataTable2;
                oDataTable2 = oConexion.LeerDataTable("Select Materiales.Codigo as CodMateriales, Materiales.Nombre as MatNombres, Materiales.Peso as MatPeso from Ejercicio, Materiales where Ejercicio.Codigo = " + oBEEjercicio.Codigo + " and Ejercicio.CodMateriales = Materiales.Codigo");
                if (oDataTable2.Rows.Count > 0)
                {
                    BEMaterial oBEMat = new BEMaterial();
                    oBEMat.Codigo = Convert.ToInt32(oDataTable2.Rows[0].ItemArray[0]);
                    oBEMat.Nombre = oDataTable2.Rows[0].ItemArray[1].ToString();
                    oBEMat.Peso = Convert.ToInt32(oDataTable2.Rows[0].ItemArray[2]);
                    oBEEj.Materiales = oBEMat;
                }
            }
            else
            {
                oBEEj = null;
            }

            return oBEEj;

        }

        public List<BEEjercicio> ListarTodo()
        {
            DataTable oDataTable;
            Conexion oConexion = new Conexion();
            oDataTable = oConexion.LeerDataTable("Select Ejercicio.Codigo, Ejercicio.Nombre, Musculo.Codigo as CodMusculo, Musculo.Nombre as NombreMusculo from Ejercicio," +
                                                 " Musculo where Ejercicio.CodMusculo = Musculo.Codigo");
            List<BEEjercicio> ListaEjercicio = new List<BEEjercicio>();
            try
            {
                if (oDataTable.Rows.Count > 0)
                {
                    foreach (DataRow fila in oDataTable.Rows)
                    {
                        BEEjercicio oBEEj = new BEEjercicio();
                        BEMusculo oBEMusc = new BEMusculo();
                        oBEEj.Codigo = Convert.ToInt32(fila[0]);
                        oBEEj.Nombre = fila[1].ToString();
                        oBEMusc.Codigo = Convert.ToInt32(fila[2]);
                        oBEMusc.Nombre = fila[3].ToString();
                        oBEEj.Musculo = oBEMusc;
                        DataTable oDataTable2;
                        oDataTable2 = oConexion.LeerDataTable("Select Materiales.Codigo as CodMateriales, Materiales.Nombre as MatNombres, Materiales.Peso as MatPeso from Ejercicio, Materiales " +
                                                            "where Ejercicio.CodMateriales = Materiales.Codigo");
                        if (oDataTable2.Rows.Count > 0)
                        {
                            foreach (DataRow fila2 in oDataTable2.Rows)
                            {
                                BEMaterial oBEMat = new BEMaterial();
                                oBEMat.Codigo = Convert.ToInt32(fila2[0]);
                                oBEMat.Nombre = fila2[1].ToString();
                                oBEMat.Peso = Convert.ToInt32(fila2[2]);
                                oBEEj.Materiales = oBEMat;
                            }
                        }
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
