using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;
using System.Data;
using BusinnesEntity;

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
        /*
        public void Guardar_Musculo_Material(BEEjercicio oBEEjercicio)
        {
            Guardar_Musculo(oBEEjercicio);
            if (oBEEjercicio.Materiales != null)
            {
                Guardar_Material(oBEEjercicio);
            }
        }

        public bool Guardar_Material(BEEjercicio oBEEjercicio)
        {
            string Consulta_SQL = " Insert into Ejercicio (CodMateriales) values(" + oBEEjercicio.Materiales.Codigo + ")";
            return oConexion.Escribir(Consulta_SQL);
        }

        public bool Guardar_Musculo(BEEjercicio oBEEjercicio)
        {
            string Consulta_SQL = " Insert into Ejercicio (CodMusculo) values(" + oBEEjercicio.Musculo.Codigo + ")";
            return oConexion.Escribir(Consulta_SQL);
        }
        */
        public BEEjercicio ListarObjeto(BEEjercicio oBEEjercicio)
        {
            throw new NotImplementedException();
        }

        public List<BEEjercicio> ListarTodo()
        {
            DataTable oDataTable;
            Conexion oConexion = new Conexion();
            oDataTable = oConexion.LeerTabla("Select Ejercicio.Codigo, Ejercicio.Nombre, Musculo.Codigo as CodMusculo, Musculo.Nombre as NombreMusculo from Ejercicio," +
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
                        oDataTable2 = oConexion.LeerTabla("Select Materiales.Codigo as CodMateriales, Materiales.Nombre as MatNombres, Materiales.Peso as MatPeso from Ejercicio, Materiales " +
                                                            "where Ejercicio.CodMateriales = Materiales.Codigo");
                        if (oDataTable2.Rows.Count > 0)
                        {
                            foreach (DataRow fila2 in oDataTable2.Rows)
                            {
                                BEMateriales oBEMat = new BEMateriales();
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
