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
            oBEMusculo.Codigo = 0;
            oBEMusculo.Nombre = Interaction.InputBox("Ingrese el nombre del musculo");

            oBLMusculo.Guardar(oBEMusculo);
            BorrarTextbox();
            CargarGrilla();
        }

        private void Boton_Modificar_Musculo_Click(object sender, EventArgs e)
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

        void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLMusculo.ListarTodo();
        }

        void InstanciarObjeto()
        {
            oBEMusculo.Nombre = TextBox_Nombre.Text;
        }

        void BorrarTextbox()
        {
            TextBox_Nombre.Text = null;
            TextBox_ID.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBEMusculo = (BEMusculo)this.dataGridView1.CurrentRow.DataBoundItem;
            TextBox_Nombre.Text = oBEMusculo.Nombre;
            TextBox_ID.Text = oBEMusculo.Codigo.ToString();
            TextBox_Nombre.ReadOnly = false;
        }

        
    }
}
