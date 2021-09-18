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
    class BLMateriales : IGestor<BEMateriales>
    {
        public BLMateriales()
        {
            oMMAteriales = new MMateriales();
        }

        MMateriales oMMAteriales;
        
        public bool Baja(BEMateriales oBEMateriales)
        {
            return oMMAteriales.Baja(oBEMateriales);
        }

        public bool Guardar(BEMateriales oBEMateriales)
        {
            return oMMAteriales.Guardar(oBEMateriales);
            
        }

        public BEMateriales ListarObjeto(BEMateriales oBEMateriales)
        {
            throw new NotImplementedException();
        }

        public List<BEMateriales> ListarTodo()
        {
            return oMMAteriales.ListarTodo();
        }
    }
}
