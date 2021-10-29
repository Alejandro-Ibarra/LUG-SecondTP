using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesEntity
{
    public class BEEjercicio: BEEntity
    {
        public string Nombre { get; set; }
        public BEMaterial Materiales{ get; set; }
        public BEMusculo Musculo { get; set; }
        public bool Activo { get; set; }
    }
}
