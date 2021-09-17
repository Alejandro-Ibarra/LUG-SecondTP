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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_User oGUI_User = new GUI_User();
            oGUI_User.MdiParent = this;
            oGUI_User.Show();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Admin oGUI_Admin = new GUI_Admin();
            oGUI_Admin.MdiParent = this;
            oGUI_Admin.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
