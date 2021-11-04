using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesEntity;
using Mapper;

namespace BusinessLogic
{
    public class BLLogin
    {
        public BLLogin()
        {
            oMLogin = new MLogin();
        }
        MLogin oMLogin;

        public bool verificarUsuarioProfe(BELogin oBELogin)
        {
            return oMLogin.verificarUsuarioProfe(oBELogin);
        }

        public bool verificarUsuarioAlumno(BELogin oBELogin)
        {
            return oMLogin.verificarUsuarioAlumno(oBELogin);
        }

        public bool verificarUsuarioAdmin(BELogin oBELogin)
        {
            return oMLogin.verificarUsuarioAdmin(oBELogin);
        }
    }
}
