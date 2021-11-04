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
    public abstract class BLUsuario 
    {
        public abstract int CalcularCuota(BEUsuario oBEUsuario);
    }
    
}
