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
            oBEMateriales = new BEMaterial();
            oBLMateriales = new BLMateriales();
            
        }

        BEUsuario oBEUsuario;
        BEMaterial oBEMateriales;
        BLUsuario oBLUsuario;
        BLMateriales oBLMateriales;


        private void Seleccionar_Usuario_Click(object sender, EventArgs e)
        {
            BEUsuario oBEUsrAux;
            int DNI = int.Parse(Interaction.InputBox("Ingrese su DNI"));
            oBEUsuario.DNI = DNI;
            oBEUsrAux = oBLUsuario.ListarObjeto(oBEUsuario);
            oBEUsrAux.DNI = DNI;

            AsignarAControles(oBEUsrAux);

            Boton_Alta_usuario.Visible = false;
            radioButton_Alta_Fem.Visible = false;
            radioButton_Alta_Masc.Visible = false;
            groupBox1.Visible = false;
            CargarGrillaMaterialesDisponibles();
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
            AsignarAControles(oBEUsuario);
            CargarGrillaMaterialesDisponibles();
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

            AsignarAUsuario();
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
        #endregion

        void AsignarAControles(BEUsuario oBEUsuario)
        {
            TextBox_Apellido.Text = oBEUsuario.Apellido;
            TextBox_Codigo.Text = oBEUsuario.Codigo.ToString();
            TextBox_Nombre.Text = oBEUsuario.Nombre;
            TextBox_Sexo.Text = oBEUsuario.Sexo;
        }

        void AsignarAUsuario()
        {
            oBEUsuario.Nombre = TextBox_Nombre.Text;
            oBEUsuario.Apellido = TextBox_Apellido.Text;
            oBEUsuario.Codigo = int.Parse(TextBox_Codigo.Text);
            oBEUsuario.Sexo = TextBox_Sexo.Text;
            if (radioButton_Mod_Fem.Checked == true)
            {
                oBEUsuario.Sexo = "Femenino";
            }
            else if (radioButton_Mod_Masc.Checked == true)
            {
                oBEUsuario.Sexo = "Masculino";
            }
        }

        void CargarGrillaMaterialesDisponibles()
        {
            Grilla_Materiales_Disponibles.DataSource = null;
            Grilla_Materiales_Disponibles.DataSource = oBLMateriales.ListarTodo();
        }

        
        private void Ingreso_Materiales_Click(object sender, EventArgs e)
        {
            oBEMateriales = (BEMaterial)this.Grilla_Materiales_Disponibles.CurrentRow.DataBoundItem;

            if (oBEUsuario.Materiales != null)
            {
                foreach (BEMaterial Material in oBEUsuario.Materiales)
                {
                    if (Material.Codigo == oBEMateriales.Codigo)
                    {
                        MessageBox.Show("El Material " +oBEMateriales.Nombre+" ya esta ingresado");
                        break;
                    }
                    else
                    {
                        oBLUsuario.AgregarUsuarioMaterial(oBEUsuario,oBEMateriales)
                    }
                }
            }
            else
            {
                oBLUsuario.AgregarUsuarioMaterial(oBEUsuario, oBEMateriales);
            }
        }
    }
}
