﻿using System;
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
    public partial class GUI_Ejercicios : Form
    {
        public GUI_Ejercicios()
        {
            InitializeComponent();
            oBEMusculo = new BEMusculo();
            oBEMateriales = new BEMaterial();
            oBEEjercicio= new BEEjercicio();
            oBLMusculo = new BLMusculo();
            oBLMateriales = new BLMateriales();
            oBLEjercicio= new BLEjercicio();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        BEMusculo oBEMusculo;
        BEMaterial oBEMateriales;
        BEEjercicio oBEEjercicio;
        BLMusculo oBLMusculo;
        BLMateriales oBLMateriales;
        BLEjercicio oBLEjercicio;

        private void GUI_Ejercicios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Cargar_ComboBox_Materiales();
            Cargar_ComboBox_Musculos();
        }
        #region Btones ABM
        private void Boton_Baja_Ejercicio_Click(object sender, EventArgs e)
        {
            if (TextBox_ID_Ejercicio.Text != null)
            {
                AsignarAUsuario();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Quiere continuar con la baja?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    oBLEjercicio.Baja(oBEEjercicio);
                    LimpiarTextBox();
                }
            }
            else
            {
                Interaction.MsgBox("Selecciones el Ejercicio a borrar");
            }
            CargarGrilla();
        }

        private void Boton_Alta_Ejercicio_Click(object sender, EventArgs e)
        {
            oBEEjercicio.Codigo = 0;
            oBEEjercicio.Nombre = Interaction.InputBox("Ingrese el nombre del ejercicio");
            oBEEjercicio.Musculo = (BEMusculo)ComboBox_Musculos.SelectedItem;
            oBEEjercicio.Materiales = (BEMaterial)ComboBox_Materiales.SelectedItem;
            oBLEjercicio.Guardar(oBEEjercicio);
            BorrarTextbox();
            CargarGrilla();
        }

        private void Boton_Modificar_Ejercicio_Click(object sender, EventArgs e)
        {
            oBEEjercicio.Codigo = int.Parse(TextBox_ID_Ejercicio.Text);
            oBEEjercicio.Nombre = TextBox_Nombre_Ejercicio.Text;
            oBEEjercicio.Musculo = (BEMusculo)ComboBox_Musculos.SelectedItem;
            oBEEjercicio.Materiales = (BEMaterial)ComboBox_Materiales.SelectedItem;
            oBLEjercicio.Guardar(oBEEjercicio);
            BorrarTextbox();
            CargarGrilla();
        }
        #endregion
        #region Cargar controladores
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            oBEEjercicio.Codigo = codigo;

            BEEjercicio oBEEjAux;
            oBEEjAux = oBLEjercicio.ListarObjeto(oBEEjercicio);
            AsignarAControles(oBEEjAux);

        }

        void Cargar_ComboBox_Materiales()
        {
            ComboBox_Materiales.DataSource = null;
            ComboBox_Materiales.DataSource = oBLMateriales.ListarTodo();
            ComboBox_Materiales.ValueMember = "Codigo";
            ComboBox_Materiales.DisplayMember = "Nombre";
            ComboBox_Materiales.Refresh();
        }

        void Cargar_ComboBox_Musculos()
        {
            ComboBox_Musculos.DataSource = null;
            ComboBox_Musculos.DataSource = oBLMusculo.ListarTodo();
            ComboBox_Musculos.ValueMember = "Codigo";
            ComboBox_Musculos.DisplayMember = "Nombre";
            ComboBox_Musculos.Refresh();
        }

        void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            List<BEEjercicio> ListaBEEjercicio = oBLEjercicio.ListarTodo();
            foreach (BEEjercicio ejer in ListaBEEjercicio)
            {
                if (ejer.Materiales.Codigo != 0)
                {
                    dataGridView1.ColumnCount = 4;
                    dataGridView1.Rows.Add(ejer.Codigo, ejer.Nombre, ejer.Musculo.Nombre, ejer.Materiales.Nombre);
                }
                else
                {
                    dataGridView1.ColumnCount = 4;
                    dataGridView1.Rows.Add(ejer.Codigo, ejer.Nombre, ejer.Musculo.Nombre, "El ejercicio no posee material");
                }
            }
        }

        void BorrarTextbox()
        {
            TextBox_Nombre_Ejercicio.Text = null;
            TextBox_ID_Ejercicio.Text = null;
        }

        private void LimpiarTextBox()
        {
            foreach (TextBox oTextbox in this.Controls.OfType<TextBox>())
            {
                oTextbox.Text = null;
            }
        }
        #endregion
        #region Asignaciones
        void AsignarAUsuario()
        {

            oBEEjercicio.Codigo = int.Parse(TextBox_ID_Ejercicio.Text);
            oBEEjercicio.Nombre = TextBox_Nombre_Ejercicio.Text;
            oBEMusculo.Codigo= int.Parse(TextBox_ID_Musculo.Text);
            oBEMusculo.Nombre = TextBox_Nombre_Musculo.Text;
            oBEEjercicio.Musculo = oBEMusculo;
            oBEMateriales.Codigo = int.Parse(TextBox_ID_Material.Text);
            oBEMateriales.Nombre = TextBox_Nombre_Material.Text;
            oBEMateriales.Peso = int.Parse(TextBox_Peso_Material.Text);
            oBEEjercicio.Materiales = oBEMateriales;
        }

        void AsignarAControles(BEEjercicio oBEEjercicio)
        {
            TextBox_ID_Ejercicio.Text = oBEEjercicio.Codigo.ToString();
            TextBox_Nombre_Ejercicio.Text = oBEEjercicio.Nombre;
            TextBox_ID_Musculo.Text = oBEEjercicio.Musculo.Codigo.ToString();
            TextBox_Nombre_Musculo.Text = oBEEjercicio.Musculo.Nombre;
            TextBox_ID_Material.Text = oBEEjercicio.Materiales.Codigo.ToString();
            TextBox_Nombre_Material.Text = oBEEjercicio.Materiales.Nombre;
            TextBox_Peso_Material.Text = oBEEjercicio.Materiales.Peso.ToString();
        }
        #endregion 
    }
}
