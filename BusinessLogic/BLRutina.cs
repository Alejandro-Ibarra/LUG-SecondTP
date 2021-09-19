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
    public abstract class BLRutina
    {
        public abstract BEEjercicio Caluclo(BEEjercicio oBEEjercicio);

        public abstract List<BEEjercicio> ListaEjercicio(List<BEMaterial> oListMat, List<BEEjercicio> oListEj);
    }
}
