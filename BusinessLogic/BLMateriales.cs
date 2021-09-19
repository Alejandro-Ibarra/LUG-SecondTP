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
    public class BLMateriales : IGestor<BEMaterial>
    {
        public BLMateriales()
        {
            oMMAteriales = new MMateriales();
        }

        MMateriales oMMAteriales;
        
        public bool Baja(BEMaterial oBEMateriales)
        {
            return oMMAteriales.Baja(oBEMateriales);
        }

        public bool Guardar(BEMaterial oBEMateriales)
        {
            return oMMAteriales.Guardar(oBEMateriales);
            
        }

        public BEMaterial ListarObjeto(BEMaterial oBEMateriales)
        {
            throw new NotImplementedException();
        }

        public List<BEMaterial> ListarTodo()
        {
            return oMMAteriales.ListarTodo();
        }
    }
}
