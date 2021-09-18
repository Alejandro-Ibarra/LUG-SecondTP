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
    public class BLMusculo : IGestor<BEMusculo>
    {
        public BLMusculo()
        {
            oMMusculo = new MMusculo();
        }

        MMusculo oMMusculo;

        public bool Baja(BEMusculo oBEMusculo)
        {
            return oMMusculo.Baja(oBEMusculo);
        }

        public bool Guardar(BEMusculo oBEMusculo)
        {
            return oMMusculo.Guardar(oBEMusculo);
        }

        public BEMusculo ListarObjeto(BEMusculo oBEMusculo)
        {
            throw new NotImplementedException();
        }

        public List<BEMusculo> ListarTodo()
        {
            return oMMusculo.ListarTodo();
        }
    }
}
