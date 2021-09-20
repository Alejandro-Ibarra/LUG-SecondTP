using BusinnesEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;
using DataAccess;
using System.Windows.Forms;

namespace Mapper
{
    public class MRutAerobico : MRutina
    {
        public override BEEjercicio Caluclo(BEEjercicio oBEEjercicio)
        {
            try
            {
                int peso = oBEEjercicio.Materiales.Peso;
                double peso2 = (double)peso * 0.5;
                oBEEjercicio.Materiales.Peso = (int)peso2;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return oBEEjercicio;
        }

        public override List<BEEjercicio> ListaEjercicio(List<BEMaterial> oListMat, List<BEEjercicio> oListEj)
        {
            List<BEEjercicio> ListEjerciciosFin = new List<BEEjercicio>();
            try
            {
                List<BEEjercicio> ListEjercicios = new List<BEEjercicio>();
                List<BEEjercicio> ListEjerciciosTemp = new List<BEEjercicio>();
                foreach (BEEjercicio EjAux in oListEj)
                {
                    foreach (BEMaterial matAux2 in oListMat)
                    {
                        if (EjAux.Materiales.Codigo == matAux2.Codigo || EjAux.Materiales.Codigo == 0)
                        {
                            BEEjercicio EjAux2 = Caluclo(EjAux);
                            ListEjerciciosTemp.Add(EjAux);
                        }
                    }
                }
                var rnd = new Random();
                ListEjerciciosTemp.OrderBy(item => rnd.Next());

                foreach (BEEjercicio EjAux in ListEjerciciosTemp)
                {
                    if (ListEjercicios.Count() == 0)
                    {
                        ListEjerciciosFin.Add(EjAux);
                    }
                    else
                    {
                        foreach (BEEjercicio EjAux2 in ListEjercicios)
                        {
                            if (EjAux.Musculo.Codigo != EjAux2.Musculo.Codigo)
                            {
                                ListEjerciciosFin.Add(EjAux);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return ListEjerciciosFin;
        }
    }
}
