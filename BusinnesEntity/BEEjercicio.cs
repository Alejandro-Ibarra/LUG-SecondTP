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
        public BEMateriales Materiales{ get; set; }
        public BEMusculo Musculo { get; set; }
    }
}
