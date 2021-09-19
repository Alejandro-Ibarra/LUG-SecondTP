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
            Grilla_Materiales_Disponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Materiales_Seleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_rutina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        BEUsuario oBEUsuario;
        BEMaterial oBEMateriales;
        BLUsuario oBLUsuario;
        BLMateriales oBLMateriales;



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
                ActualizacionAlta();
            }
            else if (radioButton_Alta_Masc.Checked == true)
            {
                oBEUsuario.Sexo = "Masculino";
                ActualizacionAlta();
            }

        }

        private void ActualizacionAlta()
        {
            CargaDatos();
            oBLUsuario.Guardar(oBEUsuario);
            LimpiarGrillas();
            CargarGrillaMaterialesDisponibles();
            oBEUsuario = RecuperarUsuarioPorDNI(oBEUsuario.DNI);
            AsignarAControles(oBEUsuario);
            ControlesUPDownAltaUsuario();
        }

        private void CargaDatos()
        {
            oBEUsuario.Nombre = Interaction.InputBox("Ingrese el nombre");
            oBEUsuario.Apellido = Interaction.InputBox("Ingrese el apellido");
            oBEUsuario.DNI = int.Parse(Interaction.InputBox("Ingrese DNI"));
        }

        private BEUsuario RecuperarUsuarioPorDNI(int oDNI)
        {
            BEUsuario oBEUsrAux;
            oBEUsuario.DNI = oDNI;
            oBEUsrAux = oBLUsuario.ListarObjeto(oBEUsuario);
            oBEUsrAux.DNI = oDNI;
            return oBEUsrAux;
        }

        private void Boton_Seleccionar_Usuario_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(Interaction.InputBox("Ingrese su DNI"));
            oBEUsuario = RecuperarUsuarioPorDNI(DNI);
            AsignarAControles(oBEUsuario);
            ControlesUPDownAltaUsuario();
            LimpiarGrillas();
            CargarGrillaMaterialesDisponibles();
            ListarMatUsuario(oBEUsuario);
        }

        private void Boton_Baja_Usuario_Click(object sender, EventArgs e)
        {
            AsignarAUsuario();
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Respuesta == DialogResult.Yes)
            {
                oBLUsuario.Baja(oBEUsuario);
                ControlesUPDownBajaUsuario();
                LimpiarControles();
                LimpiarGrillas();
            }
        }

        private void Modificar_Datos_Click(object sender, EventArgs e)
        {
            ControlesUPDownInsertarCambios();
        }

        private void Boton_Aceptar_Cambios_Click(object sender, EventArgs e)
        {
            AsignarAUsuario();
            oBLUsuario.Guardar(oBEUsuario);
            AsignarAControles(oBEUsuario);
            ControlesUPDownAceptarCambios();
        }
        #endregion

        void LimpiarControles()
        {
            TextBox_Apellido.Text = null;
            TextBox_Codigo.Text = null;
            TextBox_Nombre.Text = null;
            TextBox_Sexo.Text = null;
        }

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
            AsignarAUsuario();
            oBEMateriales = (BEMaterial)this.Grilla_Materiales_Disponibles.CurrentRow.DataBoundItem;
            int ValAux = 0;
            if (oBEUsuario.Materiales != null)
            {
                foreach (BEMaterial Material in oBEUsuario.Materiales)
                {
                    if (Material.Codigo == oBEMateriales.Codigo)
                    {
                        ValAux += 1;
                    }
                }
                if (ValAux != 0)
                {
                    MessageBox.Show("El Material ya esta ingresado");
                }
                else
                {
                    oBLUsuario.AgregarUsuarioMaterial(oBEUsuario, oBEMateriales);
                }
            }
            else
            {
                oBLUsuario.AgregarUsuarioMaterial(oBEUsuario, oBEMateriales);
            }
            ListarMatUsuario(oBEUsuario);
        }

        private void ListarMatUsuario(BEUsuario oBEUsuario)
        {
            BEUsuario oBEUsrAux;
            AsignarAUsuario();
            oBEUsrAux = oBLUsuario.ListarObjeto(oBEUsuario);
            Grilla_Materiales_Seleccionados.DataSource = null;
            Grilla_Materiales_Seleccionados.DataSource = oBEUsrAux.Materiales;

        }

        private void EliminarMaterialUsuario(BEUsuario oBEUsuario)
        {
            oBEMateriales = (BEMaterial)this.Grilla_Materiales_Seleccionados.CurrentRow.DataBoundItem;
            oBLUsuario.EliminarMaterialUsuario(oBEUsuario, oBEMateriales);
            ListarMatUsuario(oBEUsuario);
        }

        private void Eliminar_Materiales_Click(object sender, EventArgs e)
        {
            AsignarAUsuario();
            EliminarMaterialUsuario(oBEUsuario);
        }

        void LimpiarGrillas()
        {
            Grilla_Materiales_Disponibles.DataSource = null;
            Grilla_Materiales_Seleccionados.DataSource = null;
        }
        void ControlesUPDownAceptarCambios()
        {
            TextBox_Nombre.Enabled = false;
            TextBox_Apellido.Enabled = false;
            TextBox_Sexo.Enabled = false;
            radioButton_Mod_Fem.Visible = false;
            radioButton_Mod_Masc.Visible = false;
            Boton_Aceptar_Cambios.Enabled = false;
            Boton_Modificar_Datos.Enabled = true;
            groupBox1.Visible = false;
        }
        void ControlesUPDownInsertarCambios()
        {
            TextBox_Nombre.Enabled = true;
            TextBox_Apellido.Enabled = true;
            TextBox_Sexo.Enabled = true;
            radioButton_Mod_Fem.Visible = true;
            radioButton_Mod_Masc.Visible = true;
            Boton_Aceptar_Cambios.Enabled = true;
            Boton_Modificar_Datos.Enabled = false;
            groupBox1.Visible = false;
        }
        void ControlesUPDownBajaUsuario()
        {
            Boton_Alta_usuario.Visible = true;
            radioButton_Alta_Fem.Visible = true;
            radioButton_Alta_Masc.Visible = true;
            groupBox2.Visible = true;
            Boton_Baja_Usuario.Visible = false;
        }
        void ControlesUPDownAltaUsuario()
        {
            Boton_Alta_usuario.Visible = false;
            radioButton_Alta_Fem.Visible = false;
            radioButton_Alta_Masc.Visible = false;
            groupBox2.Visible = false;
            Boton_Baja_Usuario.Visible = true;
            groupBox1.Visible = false;
        }
    }
}
