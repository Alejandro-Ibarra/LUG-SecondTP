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
    public partial class GUI_Materiales : Form
    {
        public GUI_Materiales()
        {
            InitializeComponent();
            oBLMateriales = new BLMateriales();
            oBEMateriales = new BEMateriales();
        }

        BLMateriales oBLMateriales;
        BEMateriales oBEMateriales;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEMateriales = (BEMateriales)this.dataGridView1.CurrentRow.DataBoundItem;
            TextBox_Nombre.Text = oBEMateriales.Nombre;
            TextBox_Peso.Text = oBEMateriales.Peso.ToString();
            TextBox_ID.Text = oBEMateriales.Codigo.ToString();
            TextBox_Nombre.ReadOnly = false;
            TextBox_Peso.ReadOnly = false;
        }

        private void Boton_Alta_Materiales_Click(object sender, EventArgs e)
        {
            oBEMateriales.Codigo = 0;
            oBEMateriales.Nombre = Interaction.InputBox("Ingrese el nombre del material");
            DialogResult oRespuesta;
            oRespuesta = MessageBox.Show("¿Posee peso el material?", "Peso", MessageBoxButtons.YesNo);
            if (oRespuesta == DialogResult.Yes)
            {
                oBEMateriales.Peso = int.Parse(Interaction.InputBox("Ingrese el peso del material"));
            }
            else
            {
                oBEMateriales.Peso = 0;
            }
            oBLMateriales.Guardar(oBEMateriales);
            BorrarTextbox();
            CargarGrilla();
        }

        private void Boton_Modificar_Materiales_Click(object sender, EventArgs e)
        {
            if (TextBox_Nombre.Text == null)
            {
                Interaction.MsgBox("Seleccione el material a modificar");
            }
            else
            {
                InstanciarObjeto();
                oBLMateriales.Guardar(oBEMateriales);
                TextBox_Nombre.ReadOnly = true;
                TextBox_Peso.ReadOnly = true;
                CargarGrilla();
            }
            
        }

        void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLMateriales.ListarTodo();
        }

        void InstanciarObjeto()
        {
            oBEMateriales.Nombre = TextBox_Nombre.Text;
            oBEMateriales.Peso = int.Parse(TextBox_Peso.Text);
        }

        void BorrarTextbox()
        {
            TextBox_Nombre.Text = null;
            TextBox_Peso.Text = null;
            TextBox_ID.Text = null;
        }

        private void GUI_Materiales_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
