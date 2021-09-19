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
    public class BLRutHipertrofia : BLRutina
    {

        public BLRutHipertrofia()
        {
            oMHiper = new MRutHipertrofia();
        }
        MRutHipertrofia oMHiper;

        public override BEEjercicio Caluclo(BEEjercicio oBEEjercicio)
        {
            return oMHiper.Caluclo(oBEEjercicio);
        }
        
        public override List<BEEjercicio> ListaEjercicio(List<BEMaterial> oListMat, List<BEEjercicio> oListEj) 
        {
            return oMHiper.ListaEjercicio(oListMat, oListEj);
        }
    }
}
