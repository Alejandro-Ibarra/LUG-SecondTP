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
using Seguridad;

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
            if (RadioButton_Alumno.Checked || RadioButton_Profe.Checked || RadioButton_Admin.Checked)
            {
                if (val_DNI_RGX1.validar())
                {
                    oBelogin.DNI = Convert.ToInt32(val_DNI_RGX1.Text);
                    oBelogin.Password = Encriptar.GenerarMD5(textBox2.Text);
                    if (RadioButton_Profe.Checked)
                    {
                        if (oBLogin.verificarUsuarioProfe(oBelogin))
                        {
                            GUI_UsrProfesor oGUI_Profesor = new GUI_UsrProfesor();
                            this.Hide();
                            oGUI_Profesor.Show();
                        }
                        else
                        {
                            MessageBox.Show("No existe un profesor con los parametros ingresados");
                        }
                    }
                    else if (RadioButton_Alumno.Checked)
                    {
                        if (oBLogin.verificarUsuarioAlumno(oBelogin))
                        {
                            GUI_UsrAlumno oGUI_User = new GUI_UsrAlumno(oBelogin.DNI);
                            this.Hide();
                            oGUI_User.Show();
                        }
                        else
                        {
                            MessageBox.Show("No existe un alumno con los parametros ingresados");
                        }
                    }
                    else if (RadioButton_Admin.Checked)
                    {
                        if (oBLogin.verificarUsuarioAdmin(oBelogin))
                        {
                            GUI_AdminRaiz oGUI_AdminRaiz = new GUI_AdminRaiz();
                            this.Hide();
                            oGUI_AdminRaiz.Show();

                        }
                        else
                        {
                            MessageBox.Show("No existe un administrador con los parametros ingresados");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el tipo de usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cuenta");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_LogIn1_Load(object sender, EventArgs e)
        {

        }
    }
}
