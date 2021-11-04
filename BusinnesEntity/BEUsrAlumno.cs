using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesEntity
{
    public class BEUsrAlumno : BEUsuario
    {
        public int Satisfaccion { get; set; }
        public List<BEMaterial> Materiales { get; set; }
    }
}
