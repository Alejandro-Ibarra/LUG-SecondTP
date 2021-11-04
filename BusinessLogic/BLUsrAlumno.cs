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
    public class BLUsrAlumno : BLUsuario, IGestor<BEUsrAlumno>
    {
        public BLUsrAlumno()
        {
            oMUsrAlumno = new MUsrAlumno();
        }

        MUsrAlumno oMUsrAlumno;


        public bool Guardar(BEUsrAlumno oBEUsrAlumno)
        {
            return oMUsrAlumno.Guardar(oBEUsrAlumno);
        }

        public bool Baja(BEUsrAlumno oBEUsrAlumno)
        {
            return oMUsrAlumno.Baja(oBEUsrAlumno);
        }

        public BEUsrAlumno ListarObjeto(BEUsrAlumno oBEUsrAlumno)
        {
            return oMUsrAlumno.ListarObjeto(oBEUsrAlumno);
        }

        public List<BEUsrAlumno> ListarTodo()
        {
            return oMUsrAlumno.ListarTodo();
        }

        public bool AgregarUsuarioMaterial(BEUsrAlumno oBEUsrAlumno, BEMaterial oBEMaterial)
        {
            return oMUsrAlumno.AgregarUsuarioMaterial(oBEUsrAlumno, oBEMaterial);
        }

        public bool EliminarMaterialUsuario(BEUsrAlumno oBEUsrAlumno, BEMaterial oBEMaterial)
        {
            return oMUsrAlumno.EliminarMaterialAsociado(oBEUsrAlumno, oBEMaterial);
        }

        public override int CalcularCuota(BEUsuario oBEUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
