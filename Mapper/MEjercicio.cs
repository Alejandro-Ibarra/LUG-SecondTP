using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;

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
                Consulta_SQL = "Insert into Ejercicio (Nombre)values('" + oBEEjercicio.Nombre + "' )";
            }
            else
            {
                Consulta_SQL = "update Ejercicio SET Nombre = '" + oBEEjercicio.Nombre + "'where Codigo = " + oBEEjercicio.Codigo + "";
            }

            oConexion = new Conexion();
            return oConexion.Escribir(Consulta_SQL);
        }

        public BEEjercicio ListarObjeto(BEEjercicio oBEEjercicio)
        {
            throw new NotImplementedException();
        }

        public List<BEEjercicio> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
