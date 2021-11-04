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
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class GUI_Admin : Form
    {
        public GUI_Admin()
        {
            InitializeComponent();
            oBEUsrAlumno = new BEUsrAlumno();
            oBLUsrAlumno = new BLUsrAlumno();
            oBEUsrProfesor = new BEUsrProfesor();
            oBLUsrProfesor = new BLUsrProfesor();
            Grilla_Alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grilla_Profesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarGrillaAlumno();
            CargarGrillaProfesor();
            CargarComboboxSexo();
        }

        BEUsrAlumno oBEUsrAlumno;
        BLUsrAlumno oBLUsrAlumno;
        BEUsrProfesor oBEUsrProfesor;
        BLUsrProfesor oBLUsrProfesor;

        

        private void Boton_Baja_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    if (RadioButton_Profesor.Checked)
                    {
                        oBLUsrProfesor.Baja(oBEUsrProfesor);
                        LimpiarControles();
                        CargarGrillaProfesor();
                    }
                    else
                    {
                        oBLUsrAlumno.Baja(oBEUsrAlumno);
                        LimpiarControles();
                        CargarGrillaAlumno();
                    }
                    
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Alta_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarRadioButton() == true)
                {

                    if (RadioButton_Alumno.Checked)
                    {
                        AsignarAlumno();
                        oBLUsrAlumno.Guardar(oBEUsrAlumno);
                        AsignarAlumnoAControles(oBEUsrAlumno);
                        CargarGrillaAlumno();
                    }
                    else
                    {
                        AsignarProfesor();
                        oBLUsrProfesor.Guardar(oBEUsrProfesor);
                        AsignarProfesorAControles(oBEUsrProfesor);
                        CargarGrillaProfesor();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar sexo y tipo de usuario");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton_Alumno.Checked)
                {
                    AsignarAlumno();
                    oBLUsrAlumno.Guardar(oBEUsrAlumno);
                    AsignarAlumnoAControles(oBEUsrAlumno);
                    CargarGrillaAlumno();
                }
                else
                {
                    AsignarProfesor();
                    oBLUsrProfesor.Guardar(oBEUsrProfesor);
                    AsignarProfesorAControles(oBEUsrProfesor);
                    CargarGrillaProfesor();
                }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AsignarProfesor()
        {
            try
            {
                oBEUsrProfesor.Nombre = TextBox_Nombre.Text;
                oBEUsrProfesor.Apellido = TextBox_Apellido.Text;
                if (TextBox_Codigo.Text != "")
                {
                    oBEUsrProfesor.Codigo = int.Parse(TextBox_Codigo.Text);
                }
                oBEUsrProfesor.Sexo = ComboBox_Sexo.Text;
                oBEUsrProfesor.NumenorDeContacto = int.Parse(TextBox_Num_Contacto.Text);
                oBEUsrProfesor.Sexo = ComboBox_Sexo.Text;
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AsignarAlumno()
        {
            try
            {
                oBEUsrAlumno.Nombre = TextBox_Nombre.Text;
                oBEUsrAlumno.Apellido = TextBox_Apellido.Text;
                if (TextBox_Codigo.Text != "")
                {
                    oBEUsrAlumno.Codigo = int.Parse(TextBox_Codigo.Text);
                }
                else
                {
                    oBEUsrAlumno.Satisfaccion = 0;
                }
                oBEUsrAlumno.Sexo = ComboBox_Sexo.Text;
                

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void AsignarAlumnoAControles(BEUsrAlumno oBEUsrAlumno)
        {
            try
            {
                TextBox_Apellido.Text = oBEUsrAlumno.Apellido;
                TextBox_Codigo.Text = oBEUsrAlumno.Codigo.ToString();
                TextBox_Nombre.Text = oBEUsrAlumno.Nombre;
                ComboBox_Sexo.Text = oBEUsrAlumno.Sexo;
                TextBox_DNI.Text = oBEUsrAlumno.DNI.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AsignarProfesorAControles(BEUsrProfesor oBEUsrProfesor)
        {
            try
            {
                TextBox_Apellido.Text = oBEUsrProfesor.Apellido;
                TextBox_Codigo.Text = oBEUsrProfesor.Codigo.ToString();
                TextBox_Nombre.Text = oBEUsrProfesor.Nombre;
                ComboBox_Sexo.Text = oBEUsrProfesor.Sexo;
                TextBox_DNI.Text = oBEUsrProfesor.DNI.ToString();
                TextBox_Num_Contacto.Text = oBEUsrProfesor.NumenorDeContacto.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarGrillaAlumno()
        {
            try
            {
                Grilla_Alumnos.DataSource = null;
                Grilla_Alumnos.DataSource = oBLUsrAlumno.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        void CargarGrillaProfesor()
        {
            try
            {
                Grilla_Profesores.DataSource = null;
                Grilla_Profesores.DataSource = oBLUsrProfesor.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

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

        private bool VerificarRadioButton()
        {
            if (RadioButton_Profesor.Checked || RadioButton_Alumno.Checked)
            {
                return true;
            }
            else { return false; }
        }

        private void RadioButton_Profesor_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Num_Contacto.ReadOnly = false;
        }

        private void RadioButton_Usuario_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Num_Contacto.ReadOnly = true;
        }

        private void CargarComboboxSexo()
        {
            List<string> listSexos = new List<string>();
            listSexos.Add("Masculino");
            listSexos.Add("Femenino");
            ComboBox_Sexo.DataSource = null;
            ComboBox_Sexo.DataSource = listSexos;

        }


        private void Grilla_Profesores_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_Profesores.DataSource != null)
            {
                oBEUsrProfesor = (BEUsrProfesor)Grilla_Profesores.CurrentRow.DataBoundItem;
                AsignarProfesorAControles(oBEUsrProfesor);
            }
        }

        private void Grilla_Alumnos_MouseClick(object sender, MouseEventArgs e)
        {
            if (Grilla_Alumnos.DataSource != null)
            {
                oBEUsrAlumno = (BEUsrAlumno)Grilla_Alumnos.CurrentRow.DataBoundItem;
                AsignarAlumnoAControles(oBEUsrAlumno);
            }
        }
    }
}
