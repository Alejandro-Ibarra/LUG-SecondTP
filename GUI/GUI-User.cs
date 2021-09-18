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
            oBEUsuario = new BEUsuario();
            oBLUsuario = new BLUsuario();
        }

        BEUsuario oBEUsuario;
        BLUsuario oBLUsuario;

        private void Ingreso_Materiales_Click(object sender, EventArgs e)
        {

        }
        #region ABM Usuario

        private void Alta_usuario_Click(object sender, EventArgs e)
        {

            if (radioButton_Alta_Masc.Checked == false && radioButton_Alta_Fem.Checked == false)
            {
                Interaction.MsgBox("Seleccione el sexo antes de continuar");
            }
            else if (radioButton_Alta_Fem.Checked == true)
            {
                oBEUsuario.Sexo = "Femenino";
                CargaDatos();
                oBLUsuario.Guardar(oBEUsuario);
            }
            else if (radioButton_Alta_Masc.Checked == true)
            {
                oBEUsuario.Sexo = "Masculino";
                CargaDatos();
                oBLUsuario.Guardar(oBEUsuario);
            }
        }

        private void CargaDatos()
        {
            oBEUsuario.Nombre = Interaction.InputBox("Ingrese el nombre");
            oBEUsuario.Apellido = Interaction.InputBox("Ingrese el apellido");
            oBEUsuario.DNI = int.Parse(Interaction.InputBox("Ingrese DNI"));
        }

        private void Modificar_Datos_Click(object sender, EventArgs e)
        {
            TextBox_Nombre.Enabled = true;
            TextBox_Apellido.Enabled = true;
            TextBox_Sexo.Enabled = true;
            radioButton_Mod_Fem.Visible = true;
            radioButton_Mod_Masc.Visible = true;
            Boton_Aceptar_Cambios.Enabled = true;
            Boton_Modificar_Datos.Enabled = false;
        }

        private void Boton_Aceptar_Cambios_Click(object sender, EventArgs e)
        {

            Asignar();
            oBLUsuario.Guardar(oBEUsuario);

            TextBox_Nombre.Enabled = false;
            TextBox_Apellido.Enabled = false;
            TextBox_Codigo.Enabled = false;
            TextBox_Sexo.Enabled = false;
            radioButton_Mod_Fem.Visible = false;
            radioButton_Mod_Masc.Visible = false;
            Boton_Aceptar_Cambios.Enabled = false;
            Boton_Modificar_Datos.Enabled = true;
        }

        private void Seleccionar_Usuario_Click(object sender, EventArgs e)
        {
            BEUsuario oBEusrAux = new BEUsuario();
            int DNI = int.Parse(Interaction.InputBox("Ingrese su DNI"));
            oBEUsuario.DNI = DNI;
            oBEusrAux = oBLUsuario.ListarObjeto(oBEUsuario);
            oBEusrAux.DNI = DNI;

            TextBox_Apellido.Text = oBEusrAux.Apellido;
            TextBox_Codigo.Text = oBEusrAux.Codigo.ToString();
            TextBox_Nombre.Text = oBEusrAux.Nombre;
            TextBox_Sexo.Text = oBEusrAux.Sexo;

            Boton_Alta_usuario.Visible = false;
            radioButton_Alta_Fem.Visible = false;
            radioButton_Alta_Masc.Visible = false;
        }

        void Asignar()
        {

            oBEUsuario.Nombre = TextBox_Nombre.Text;
            oBEUsuario.Apellido = TextBox_Apellido.Text;
            oBEUsuario.Codigo = int.Parse(TextBox_Codigo.Text);
            oBEUsuario.Sexo = TextBox_Sexo.Text;
            if (radioButton_Mod_Fem.Checked == true)
            {
                oBEUsuario.Sexo = "Femenino";
            }
            else if(radioButton_Mod_Masc.Checked == true)
            {
                oBEUsuario.Sexo = "Masculino";
            }

            /*else
            {
                oBEUsuario.Sexo = TextBox_Sexo.Text;
            }*/

        }
        #endregion

        private void GUI_User_Load(object sender, EventArgs e)
        {

        }
    }
}
