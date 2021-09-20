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
    public partial class GUI_Musculos : Form
    {
        public GUI_Musculos()
        {
            InitializeComponent();
            oBLMusculo = new BLMusculo();
            oBEMusculo = new BEMusculo();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        BLMusculo oBLMusculo;
        BEMusculo oBEMusculo;

        private void GUI_Musculos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Boton_Alta_Musculo_Click(object sender, EventArgs e)
        {
            try
            {
                oBEMusculo.Codigo = 0;
                oBEMusculo.Nombre = Interaction.InputBox("Ingrese el nombre del musculo");
                oBLMusculo.Guardar(oBEMusculo);
                BorrarTextbox();
                CargarGrilla();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Baja_Musculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text != null)
                {
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Eliminar Musculo?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (oBLMusculo.Baja(oBEMusculo) == false)
                        { MessageBox.Show("Para dar de baja el musculo no debe estar asociado a nigun Ejercicio"); }
                        else
                        {
                            CargarGrilla();
                            LimpiarTextBox();
                        }

                    }
                }
                else
                { Interaction.MsgBox("Seleccione un Musculo para dar de baja"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Musculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Nombre.Text == null)
                {
                    Interaction.MsgBox("Seleccione el musculo a modificar");
                }
                else
                {
                    InstanciarObjeto();
                    oBLMusculo.Guardar(oBEMusculo);
                    TextBox_Nombre.ReadOnly = true;
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        void CargarGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = oBLMusculo.ListarTodo();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }

        void InstanciarObjeto()
        {
            try
            {
                oBEMusculo.Nombre = TextBox_Nombre.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void BorrarTextbox()
        {
            try
            {
                foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
                {
                    oTextbox.Text = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEMusculo = (BEMusculo)this.dataGridView1.CurrentRow.DataBoundItem;
                TextBox_Nombre.Text = oBEMusculo.Nombre;
                TextBox_ID.Text = oBEMusculo.Codigo.ToString();
                TextBox_Nombre.ReadOnly = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void AsignarAMusculo()
        {  
            try
            {
                oBEMusculo.Codigo = int.Parse(TextBox_ID.Text);
                oBEMusculo.Nombre = TextBox_Nombre.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void LimpiarTextBox()
        {
            try
            {
                TextBox_ID.Text = null;
                TextBox_Nombre.Text = null;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Boton_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
