using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IEntidad
    {
        int Codigo { get; set; }
        string Nombre { get; set; }
    }
}
