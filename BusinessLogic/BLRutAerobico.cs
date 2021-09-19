using BusinnesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using Mapper;

namespace BusinessLogic
{
    public class BLRutAerobico : BLRutina
    {
        public BLRutAerobico()
        {
            oMAero = new MRutAerobico();
        }
        MRutAerobico oMAero;

        public override BEEjercicio Caluclo(BEEjercicio oBEEjercicio)
        {
            return oMAero.Caluclo(oBEEjercicio);
        }

        public override List<BEEjercicio> ListaEjercicio(List<BEMaterial> oListMat, List<BEEjercicio> oListEj)
        {
            return oMAero.ListaEjercicio(oListMat , oListEj);
        }
    }
}
