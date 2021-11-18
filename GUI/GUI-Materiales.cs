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
using System.Xml.Linq;

namespace GUI
{
    public partial class GUI_Materiales : Form
    {
        public GUI_Materiales()
        {
            InitializeComponent();
            oBLMateriales = new BLMateriales();
            oBEMateriales = new BEMaterial();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarMaterialesSugeridos();
        }

        BLMateriales oBLMateriales;
        BEMaterial oBEMateriales;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEMateriales = (BEMaterial)this.dataGridView1.CurrentRow.DataBoundItem;
                TextBox_Nombre.Text = oBEMateriales.Nombre;
                TextBox_Peso.Text = oBEMateriales.Peso.ToString();
                TextBox_ID.Text = oBEMateriales.Codigo.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Boton_Alta_Materiales_Click(object sender, EventArgs e)
        {
            try
            {
                oBEMateriales.Codigo = 0;
                oBEMateriales.Nombre = TextBox_Nombre.Text;

                if (TextBox_Peso.Text != null)
                {
                    oBEMateriales.Peso = int.Parse(TextBox_Peso.Text);
                }
                else
                {
                    oBEMateriales.Peso = 0;
                }
                oBLMateriales.Guardar(oBEMateriales);
                BorrarTextbox();
                CargarGrilla();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Boton_Modificar_Materiales_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Nombre.Text == null)
                {
                    Interaction.MsgBox("Seleccione el material a modificar");
                }
                else
                {
                    InstanciarObjeto();
                    oBLMateriales.Guardar(oBEMateriales);
                    CargarGrilla();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarGrilla()
        {
            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = oBLMateriales.ListarTodo();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void InstanciarObjeto()
        {
            try
            {
                oBEMateriales.Nombre = TextBox_Nombre.Text;
                oBEMateriales.Peso = int.Parse(TextBox_Peso.Text);
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

        private void GUI_Materiales_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Boton_Baja_Materiales_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text != null)
                {
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Eliminar material?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (oBLMateriales.Baja(oBEMateriales) == false)
                        { MessageBox.Show("Para dar de baja el material no debe estar asociado a ningun Ejercicio"); }
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
        
        public List<BEMaterial> LeerXML()
        {
            List<BEMaterial> ListaMateriales = oBLMateriales.LeerXml();
            return ListaMateriales;
        }

        private void CargarMaterialesSugeridos()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = LeerXML();
        }
    }
}
