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
            oBLEjercicio = new BLEjercicio();
            Grilla_Materiales_Disponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Materiales_Seleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Rutina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        BEUsuario oBEUsuario;
        BEMaterial oBEMateriales;
        BLUsuario oBLUsuario;
        BLMateriales oBLMateriales;
        BLEjercicio oBLEjercicio;

        private void GUI_User_Load(object sender, EventArgs e)
        {
        }
        #region Botones ABM
        private void Boton_Seleccionar_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                int DNI = int.Parse(Interaction.InputBox("Ingrese su DNI"));
                oBEUsuario = RecuperarUsuarioPorDNI(DNI);
                AsignarAControles(oBEUsuario);
                ControlesUPDownAltaUsuario();
                LimpiarGrillas();
                CargarGrillaMaterialesDisponibles();
                ListarMatUsuario(oBEUsuario);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Boton_Alta_usuario_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Boton_Baja_Usuario_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void Modificar_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                ControlesUPDownInsertarCambios();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Boton_Aceptar_Cambios_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAUsuario();
                oBLUsuario.Guardar(oBEUsuario);
                AsignarAControles(oBEUsuario);
                ControlesUPDownAceptarCambios();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        #endregion
        #region Materiales
        private void Ingreso_Materiales_Click(object sender, EventArgs e)
        {
            try
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
                    { oBLUsuario.AgregarUsuarioMaterial(oBEUsuario, oBEMateriales); }
                }
                else
                { oBLUsuario.AgregarUsuarioMaterial(oBEUsuario, oBEMateriales); }
                ListarMatUsuario(oBEUsuario);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void ListarMatUsuario(BEUsuario oBEUsuario)
        {
            try
            {
                BEUsuario oBEUsrAux;
                AsignarAUsuario();
                oBEUsrAux = oBLUsuario.ListarObjeto(oBEUsuario);
                Grilla_Materiales_Seleccionados.DataSource = null;
                Grilla_Materiales_Seleccionados.DataSource = oBEUsrAux.Materiales;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void EliminarMaterialUsuario(BEUsuario oBEUsuario)
        {
            try
            {
                oBEMateriales = (BEMaterial)this.Grilla_Materiales_Seleccionados.CurrentRow.DataBoundItem;
                oBLUsuario.EliminarMaterialUsuario(oBEUsuario, oBEMateriales);
                ListarMatUsuario(oBEUsuario);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Eliminar_Materiales_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAUsuario();
                EliminarMaterialUsuario(oBEUsuario);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion
        #region rutina
        private void Generar_Rutina_Click(object sender, EventArgs e)
        {
            try
            {
                this.Grilla_Rutina.DataSource = null;
                this.Grilla_Rutina.Rows.Clear();
                List<BEEjercicio> ListaBEEjercicio = oBLEjercicio.ListarTodo();
                if (RadioButton_Aerobico.Checked == true)
                {
                    BLRutAerobico oBLAero = new BLRutAerobico();
                    List<BEEjercicio> ListaBEEjercicio2 = oBLAero.ListaEjercicio(oBEUsuario.Materiales, ListaBEEjercicio);

                    foreach (BEEjercicio Ejer in ListaBEEjercicio2)
                    {
                        Grilla_Rutina.ColumnCount = 3;
                        Grilla_Rutina.Rows.Add(Ejer.Nombre, Ejer.Materiales.Nombre, Ejer.Materiales.Peso);
                    }
                }
                else if (RadioButton_Hipertrofia.Checked == true)
                {
                    BLRutHipertrofia oBLHiper = new BLRutHipertrofia();
                    List<BEEjercicio> ListaBEEjercicio2 = oBLHiper.ListaEjercicio(oBEUsuario.Materiales, ListaBEEjercicio);

                    foreach (BEEjercicio Ejer in ListaBEEjercicio2)
                    {
                        Grilla_Rutina.ColumnCount = 3;
                        Grilla_Rutina.Rows.Add(Ejer.Nombre, Ejer.Materiales.Nombre, Ejer.Materiales.Peso);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        #endregion
        #region Manejo de controladores
        void CargarGrillaMaterialesDisponibles()
        {
            try
            {
                Grilla_Materiales_Disponibles.DataSource = null;
                Grilla_Materiales_Disponibles.DataSource = oBLMateriales.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void ActualizacionAlta()
        {
            try
            {
                CargaDatos();
                oBLUsuario.Guardar(oBEUsuario);
                LimpiarGrillas();
                CargarGrillaMaterialesDisponibles();
                oBEUsuario = RecuperarUsuarioPorDNI(oBEUsuario.DNI);
                AsignarAControles(oBEUsuario);
                ControlesUPDownAltaUsuario();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }

        private void CargaDatos()
        {
            try
            {
                oBEUsuario.Nombre = Interaction.InputBox("Ingrese el nombre");
                oBEUsuario.Apellido = Interaction.InputBox("Ingrese el apellido");
                oBEUsuario.DNI = int.Parse(Interaction.InputBox("Ingrese DNI"));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private BEUsuario RecuperarUsuarioPorDNI(int oDNI)
        {
            try
            {
                BEUsuario oBEUsrAux;
                oBEUsuario.DNI = oDNI;
                oBEUsrAux = oBLUsuario.ListarObjeto(oBEUsuario);
                oBEUsrAux.DNI = oDNI;
                return oBEUsrAux;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }

        void LimpiarControles()
        {
            try
            {
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarAControles(BEUsuario oBEUsuario)
        {
            try
            {
                TextBox_Apellido.Text = oBEUsuario.Apellido;
                TextBox_Codigo.Text = oBEUsuario.Codigo.ToString();
                TextBox_Nombre.Text = oBEUsuario.Nombre;
                TextBox_Sexo.Text = oBEUsuario.Sexo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarAUsuario()
        {
            try
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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        #endregion
        #region Visualizacion de formulario

        void LimpiarGrillas()
        {
            try
            {
                Grilla_Materiales_Disponibles.DataSource = null;
                Grilla_Materiales_Seleccionados.DataSource = null;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        void ControlesUPDownAceptarCambios()
        {
            try
            {
                TextBox_Nombre.Enabled = false;
                TextBox_Apellido.Enabled = false;
                TextBox_Sexo.Enabled = false;
                radioButton_Mod_Fem.Visible = false;
                radioButton_Mod_Masc.Visible = false;
                Boton_Aceptar_Cambios.Enabled = false;
                Boton_Modificar_Datos.Enabled = true;
                GroupBox_Mod_Sexo.Visible = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        void ControlesUPDownInsertarCambios()
        {
            try
            {
                TextBox_Nombre.Enabled = true;
                TextBox_Apellido.Enabled = true;
                TextBox_Sexo.Enabled = true;
                radioButton_Mod_Fem.Visible = true;
                radioButton_Mod_Masc.Visible = true;
                Boton_Aceptar_Cambios.Enabled = true;
                Boton_Modificar_Datos.Enabled = false;
                GroupBox_Mod_Sexo.Visible = false;
                GroupBox_Tipo_Rutina.Visible = true;
                RadioButton_Aerobico.Visible = true;
                RadioButton_Hipertrofia.Visible = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        void ControlesUPDownBajaUsuario()
        {
            try
            {
                Boton_Alta_usuario.Visible = true;
                radioButton_Alta_Fem.Visible = true;
                radioButton_Alta_Masc.Visible = true;
                GroupBox_Alta_Sexo.Visible = true;
                Boton_Baja_Usuario.Visible = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        void ControlesUPDownAltaUsuario()
        {
            try
            {
                Boton_Alta_usuario.Visible = false;
                radioButton_Alta_Fem.Visible = false;
                radioButton_Alta_Masc.Visible = false;
                GroupBox_Alta_Sexo.Visible = false;
                Boton_Baja_Usuario.Visible = true;
                GroupBox_Mod_Sexo.Visible = false;
                GroupBox_Tipo_Rutina.Visible = true;
                RadioButton_Aerobico.Visible = true;
                RadioButton_Hipertrofia.Visible = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            

        }
        #endregion

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }    
}
