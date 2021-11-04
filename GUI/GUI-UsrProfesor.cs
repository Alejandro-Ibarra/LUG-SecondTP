using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_UsrProfesor : Form
    {
        public GUI_UsrProfesor()
        {
            InitializeComponent();
        }

        private void MaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Materiales oGUI_Materiales = new GUI_Materiales();
            oGUI_Materiales.MdiParent = this;
            oGUI_Materiales.Show();
        }

        private void MusculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Musculos oGUI_Musculo = new GUI_Musculos();
            oGUI_Musculo.MdiParent = this;
            oGUI_Musculo.Show();
        }

        private void EjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Ejercicios oGUI_Ejercicios = new GUI_Ejercicios();
            oGUI_Ejercicios.MdiParent = this;
            oGUI_Ejercicios.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
