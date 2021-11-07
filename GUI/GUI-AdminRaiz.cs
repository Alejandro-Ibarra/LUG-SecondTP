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
    public partial class GUI_AdminRaiz : Form
    {
        public GUI_AdminRaiz()
        {
            InitializeComponent();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_AdminABM oGUI_Admin = new GUI_AdminABM();
            this.Hide();
            oGUI_Admin.Show();
        }

        private void materialesSugeridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_AdminMateriales oGUI_Adm_Mat = new GUI_AdminMateriales();
            this.Hide();
            oGUI_Adm_Mat.Show();
        }
    }
}
