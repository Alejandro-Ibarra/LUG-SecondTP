using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinnesEntity;


namespace Mapper
{
    public class MLogin
    {
        public bool verificarUsuario(BELogin oBELogin)
        {
            Conexion oConexion = new Conexion();
            string consulta = "select  count (Usuario) from Login where Usuario = '" + oBELogin.Usuario +"' and Password = '" + oBELogin.Password +"'";
            return oConexion.LeerAsociacion(consulta);
        }
    }
}
