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
    public class BLEjercicio : IGestor<BEEjercicio>
    {
        public BLEjercicio()
        {
            oMEjercicio = new MEjercicio();
        }

        MEjercicio oMEjercicio;

        public bool Baja(BEEjercicio oBEjercicio)
        {
            return oMEjercicio.Baja(oBEjercicio);
        }

        public bool Guardar(BEEjercicio oBEjercicio)
        {
            return oMEjercicio.Guardar(oBEjercicio);
        }

        public BEEjercicio ListarObjeto(BEEjercicio oBEjercicio)
        {
            return oMEjercicio.ListarObjeto(oBEjercicio);
        }

        public List<BEEjercicio> ListarTodo()
        {
            return oMEjercicio.ListarTodo();
        }

        public void AgregarMaterial_ejercicio()
        {
            throw new NotImplementedException();
        }
    }
}
