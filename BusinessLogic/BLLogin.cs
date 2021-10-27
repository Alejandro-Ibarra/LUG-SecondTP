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
        public bool verificarUsuario(BELogin oBELogin) 
        {
            MLogin oMLogin = new MLogin();

            return oMLogin.verificarUsuario(oBELogin);

        }
    }
}
