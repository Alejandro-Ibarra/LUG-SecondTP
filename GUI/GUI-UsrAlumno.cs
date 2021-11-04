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
    public partial class GUI_UsrAlumno : Form
    {
        public GUI_UsrAlumno(int DNI)
        {
            InitializeComponent();
            oBEUsrAlumno = new BEUsrAlumno();
            oBLUsrAlumno = new BLUsrAlumno();
            oBEMateriales = new BEMaterial();
            oBLMateriales = new BLMateriales();
            oBLEjercicio = new BLEjercicio();
            Grilla_Materiales_Disponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Materiales_Seleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Rutina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatosDeAlumno(DNI);
        }
        BEUsrAlumno oBEUsrAlumno;
        BEMaterial oBEMateriales;
        BLUsrAlumno oBLUsrAlumno;
        BLMateriales oBLMateriales;
        BLEjercicio oBLEjercicio;

        private void GUI_User_Load(object sender, EventArgs e)
        {
        }
        #region Botones ABM
        private void CargarDatosDeAlumno(int DNI)
        {
            try
            {
                oBEUsrAlumno = RecuperarUsuarioPorDNI(DNI);
                AsignarAControles(oBEUsrAlumno);
                LimpiarGrillas();
                CargarGrillaMaterialesDisponibles();
                ListarMatUsuario(oBEUsrAlumno);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Boton_Modificar_Datos_Personales_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAAlumno();
                oBLUsrAlumno.Guardar(oBEUsrAlumno);
                AsignarAControles(oBEUsrAlumno);
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
                AsignarAAlumno();
                oBEMateriales = (BEMaterial)this.Grilla_Materiales_Disponibles.CurrentRow.DataBoundItem;
                int ValAux = 0;
                if (oBEUsrAlumno.Materiales != null)
                {
                    foreach (BEMaterial Material in oBEUsrAlumno.Materiales)
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
                    { oBLUsrAlumno.AgregarUsuarioMaterial(oBEUsrAlumno, oBEMateriales); }
                }
                else
                { oBLUsrAlumno.AgregarUsuarioMaterial(oBEUsrAlumno, oBEMateriales); }
                ListarMatUsuario(oBEUsrAlumno);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void ListarMatUsuario(BEUsrAlumno oBEUsrAlumno)
        {
            try
            {
                BEUsrAlumno oBEUsrAux;
                AsignarAAlumno();
                oBEUsrAux = oBLUsrAlumno.ListarObjeto(oBEUsrAlumno);
                Grilla_Materiales_Seleccionados.DataSource = null;
                Grilla_Materiales_Seleccionados.DataSource = oBEUsrAux.Materiales;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void EliminarMaterialUsuario(BEUsrAlumno oBEUsrAlumno)
        {
            try
            {
                oBEMateriales = (BEMaterial)this.Grilla_Materiales_Seleccionados.CurrentRow.DataBoundItem;
                oBLUsrAlumno.EliminarMaterialUsuario(oBEUsrAlumno, oBEMateriales);
                ListarMatUsuario(oBEUsrAlumno);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Eliminar_Materiales_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarAAlumno();
                EliminarMaterialUsuario(oBEUsrAlumno);
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
                    List<BEEjercicio> ListaBEEjercicio2 = oBLAero.ListaEjercicio(oBEUsrAlumno.Materiales, ListaBEEjercicio);

                    foreach (BEEjercicio Ejer in ListaBEEjercicio2)
                    {
                        Grilla_Rutina.ColumnCount = 3;
                        Grilla_Rutina.Rows.Add(Ejer.Nombre, Ejer.Materiales.Nombre, Ejer.Materiales.Peso);
                    }
                }
                else if (RadioButton_Hipertrofia.Checked == true)
                {
                    BLRutHipertrofia oBLHiper = new BLRutHipertrofia();
                    List<BEEjercicio> ListaBEEjercicio2 = oBLHiper.ListaEjercicio(oBEUsrAlumno.Materiales, ListaBEEjercicio);

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
                oBLUsrAlumno.Guardar(oBEUsrAlumno);
                LimpiarGrillas();
                CargarGrillaMaterialesDisponibles();
                oBEUsrAlumno = RecuperarUsuarioPorDNI(oBEUsrAlumno.DNI);
                AsignarAControles(oBEUsrAlumno);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }

        private BEUsrAlumno RecuperarUsuarioPorDNI(int oDNI)
        {
            try
            {
                BEUsrAlumno oBEUsrAux;
                oBEUsrAlumno.DNI = oDNI;
                oBEUsrAux = oBLUsrAlumno.ListarObjeto(oBEUsrAlumno);
                oBEUsrAux.DNI = oDNI;
                return oBEUsrAux;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
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

       void AsignarAAlumno()
        {
            try
            {
                oBEUsrAlumno.Nombre = TextBox_Nombre.Text;
                oBEUsrAlumno.Apellido = TextBox_Apellido.Text;
                oBEUsrAlumno.Codigo = int.Parse(TextBox_Codigo.Text);
                oBEUsrAlumno.Sexo = TextBox_Sexo.Text;
                if (radioButton_Mod_Fem.Checked == true)
                {
                    oBEUsrAlumno.Sexo = "Femenino";
                }
                else if (radioButton_Mod_Masc.Checked == true)
                {
                    oBEUsrAlumno.Sexo = "Masculino";
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
                this.Grilla_Materiales_Disponibles.DataSource = null;
                this.Grilla_Materiales_Seleccionados.DataSource = null;
                this.Grilla_Rutina.DataSource = null;
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
