using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BusinnesEntity;
using BusinessLogic;

namespace GUI
{
    public partial class GUI_User : Form
    {
        public GUI_User()
        {
            InitializeComponent();
            oBEusuario = new BEUsuario();
        }

        BEUsuario oBEusuario;

        private void Ingreso_Materiales_Click(object sender, EventArgs e)
        {

        }

        private void Alta_usuario_Click(object sender, EventArgs e)
        {
            oBEusuario.no = Interaction.InputBox("Ingrese el nombre")
        }
    }
}
