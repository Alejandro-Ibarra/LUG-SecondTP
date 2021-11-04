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
    public class BLUsrProfesor : BLUsuario, IGestor<BEUsrProfesor>
    {
        public BLUsrProfesor()
        {
            oMUsrProfesor = new MUsrProfesor();
        }

        MUsrProfesor oMUsrProfesor;


        public bool Guardar(BEUsrProfesor oBEUsrProf)
        {
            return oMUsrProfesor.Guardar(oBEUsrProf);
        }

        public bool Baja(BEUsrProfesor oBEUsrProf)
        {
            return oMUsrProfesor.Baja(oBEUsrProf);
        }

        public BEUsrProfesor ListarObjeto(BEUsrProfesor oBEUsrProf)
        {
            return oMUsrProfesor.ListarObjeto(oBEUsrProf);
        }

        public List<BEUsrProfesor> ListarTodo()
        {
            return oMUsrProfesor.ListarTodo();
        }

        public override int CalcularCuota(BEUsuario oBEUsuario)
        {
            int cuota = 500;
            return cuota;
        }
    }
}
