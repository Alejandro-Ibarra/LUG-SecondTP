using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinnesEntity;
using System.Collections;

namespace Mapper
{
    public class MLogin
    {
        public MLogin()
        {
            oConexion = new Conexion();
            Hashdatos = new Hashtable();
        }

        Hashtable Hashdatos;
        Conexion oConexion;

        public bool verificarUsuarioProfe(BELogin oBELogin)
        {
            Hashdatos = new Hashtable();

            Hashdatos.Add("@DNI", oBELogin.DNI);
            Hashdatos.Add("@Pass", oBELogin.Password);
            string Consulta_SQL = "S_Verifica_Acceso_Profe";

            return oConexion.LeerAsociacion(Consulta_SQL, Hashdatos);
        }

        public bool verificarUsuarioAdmin(BELogin oBELogin)
        {
            Hashdatos = new Hashtable();

            Hashdatos.Add("@DNI", oBELogin.DNI);
            Hashdatos.Add("@Pass", oBELogin.Password);
            string Consulta_SQL = "S_Verifica_Acceso_Admin";

            return oConexion.LeerAsociacion(Consulta_SQL, Hashdatos);
        }

        public bool verificarUsuarioAlumno(BELogin oBELogin)
        {
            Hashdatos = new Hashtable();

            Hashdatos.Add("@DNI", oBELogin.DNI);
            Hashdatos.Add("@Pass", oBELogin.Password);
            string Consulta_SQL = "S_Verifica_Acceso_Alumno";

            return oConexion.LeerAsociacion(Consulta_SQL, Hashdatos);
        }
    }
}
