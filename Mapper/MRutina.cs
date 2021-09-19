﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using BusinnesEntity;
using DataAccess;

namespace Mapper
{
    public abstract class MRutina
    {
        public abstract BEEjercicio Caluclo(BEEjercicio oBEEjercicio);

        public abstract List<BEEjercicio> ListaEjercicio(List<BEMaterial> oListMat, List<BEEjercicio> oListEj);
    }
}
