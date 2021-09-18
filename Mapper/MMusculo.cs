using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;

namespace Mapper
{
    public class MMusculo : IGestor<BEMusculo>
    {
        bool IGestor<BEMusculo>.Baja(BEMusculo Objeto)
        {
            throw new NotImplementedException();
        }

        bool IGestor<BEMusculo>.Guardar(BEMusculo Objeto)
        {
            throw new NotImplementedException();
        }

        BEMusculo IGestor<BEMusculo>.ListarObjeto(BEMusculo Objeto)
        {
            throw new NotImplementedException();
        }

        List<BEMusculo> IGestor<BEMusculo>.ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
