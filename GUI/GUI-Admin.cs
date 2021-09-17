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
    public partial class GUI_Admin : Form
    {
        public GUI_Admin()
        {
            InitializeComponent();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Materiales oGUI_Materiales = new GUI_Materiales();
            oGUI_Materiales.MdiParent = this;
            oGUI_Materiales.Show();
        }

        private void musculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Musculos oGUI_Musculos = new GUI_Musculos();
            oGUI_Musculos.MdiParent = this;
            oGUI_Musculos.Show();
        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Ejercicios oGUI_Ejercicios = new GUI_Ejercicios();
            oGUI_Ejercicios.MdiParent = this;
            oGUI_Ejercicios.Show();
        }
    }
}
