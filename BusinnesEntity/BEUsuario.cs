using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesEntity 
{
    public abstract class BEUsuario : BEEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Sexo { get; set; }
        public bool Activo { get; set; }
        public string Pass { get; set; }
    }
}
