using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinnesEntity;
using BusinessLogic;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            oBelogin = new BELogin();
            oBLogin = new BLLogin();
        }
        BELogin oBelogin;
        BLLogin oBLogin;

        private void Aceptar_Click(object sender, EventArgs e)
        {
            oBelogin.Usuario = textBox1.Text;
            oBelogin.Password = textBox2.Text;

            if (oBLogin.verificarUsuario(oBelogin))
            {
                Menu frm = new Menu();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o password incorrectos");
            }

        }

    }
}
