using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesEntity
{
    public class BEEjercicio: BEEntity
    {
        string Nombre { get; set; }
        public string Descripcion{ get; set; }
        public int Peso { get; set; }
        public int Repeticiones { get; set; }
        public BEHerramientas Herramientas{ get; set; }
        public BEMusculo Musculo { get; set; }
    }
}
