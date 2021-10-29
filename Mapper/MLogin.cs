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

        public bool verificarUsuario(BELogin oBELogin)
        {

            Hashdatos = new Hashtable();

            Hashdatos.Add("@Usr", oBELogin.Usuario);
            Hashdatos.Add("@Pass", oBELogin.Password);
            string Consulta_SQL = "S_Verifica_Acceso";

            return oConexion.Escribir(Consulta_SQL, Hashdatos);
        }
    }
}
