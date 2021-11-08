using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinnesEntity;
using BusinessLogic;


namespace GUI
{
    public partial class GUI_GraficoHerramientas : Form
    {
        public GUI_GraficoHerramientas()
        {
            InitializeComponent();
            oBLEjercicio = new BLEjercicio();
            oBEEjercicio = new BEEjercicio();
            oBLMateriales = new BLMateriales();
            oBEMateriales = new BEMaterial();
            ListaInt = new List<int>();
        }
        BEEjercicio oBEEjercicio;
        BLEjercicio oBLEjercicio;
        BLMateriales oBLMateriales;
        BEMaterial oBEMateriales;
        
        List<int> ListaInt;

        private List<int> Can_Herramientas()
        {
            try
            {
                int aux = 0;
                List<BEEjercicio> ListaBEEjercicio = oBLEjercicio.ListarTodo();
                List<BEMaterial> ListaBEMateriales = oBLMateriales.ListarTodo();
                foreach (BEEjercicio Eje in ListaBEEjercicio)
                {
                    foreach (BEMaterial Mat in ListaBEMateriales)
                    {
                        if (Eje.Materiales.Codigo == Mat.Codigo)
                        {
                            aux++;
                        }
                    }
                    ListaInt.Add(aux);
                    aux = 0;                    
                }
                return ListaInt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

        void CargarGraficos()
        {   
            List<BEMaterial> ListaBEMateriales = oBLMateriales.ListarTodo();
            List<string> NombresMat = new List<string>();
            foreach (BEMaterial Mat in ListaBEMateriales)
            {
                NombresMat.Add(Mat.Nombre);
            }

            chart1.Series["Series1"].Points.DataBindXY(NombresMat, Can_Herramientas());
            chart1.Titles.Add("Estadisticas Herramientas");

            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chart1.Legends[0].Enabled = true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), comboBox1.SelectedItem.ToString());
        }
    }
}
