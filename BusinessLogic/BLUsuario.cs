using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using Mapper;

namespace BusinessLogic
{
    public class BLUsuario : IGestor<BEUsuario>
    {
        public BLUsuario()
        {
            oMUsuario = new MUsuario();
        }

        MUsuario oMUsuario;

        public bool Guardar(BEUsuario oBEUsuario)
        {
            return oMUsuario.Guardar(oBEUsuario);
        }

        public bool Baja(BEUsuario oBEUsuario)
        {
            return oMUsuario.Baja(oBEUsuario);
        }

        public BEUsuario ListarObjeto(BEUsuario oBEUsuario)
        {
            return oMUsuario.ListarObjeto(oBEUsuario);
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool AgregarUsuarioMaterial(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {
            return oMUsuario.AgregarUsuarioMaterial(oBEusuario, oBEMaterial);
        }

        public bool EliminarMaterialUsuario(BEUsuario oBEusuario, BEMaterial oBEMaterial)
        {
            return oMUsuario.EliminarMaterialAsociado (oBEusuario, oBEMaterial);
        }
    }
    
}
