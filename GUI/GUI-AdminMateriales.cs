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
using System.Xml.Linq;

namespace GUI
{
    public partial class GUI_AdminMateriales : Form
    {
        public GUI_AdminMateriales()
        {
            InitializeComponent();
        }

        public List<BEMaterial> LeerXML()
        {
            var consulta =
                from material in XElement.Load("Materiales.XML").Elements("material")
                select new BEMaterial
                {
                    Codigo = Convert.ToInt32(Convert.ToString(material.Attribute("id").Value).Trim()),
                    Nombre = Convert.ToString(material.Element("nombre").Value).Trim(),
                    Peso = Convert.ToInt32(material.Element("peso").Value.Trim()),
                };
            List<BEMaterial> ListaMateriales = consulta.ToList<BEMaterial>();
            return ListaMateriales;
        }

        private void AgregarXML()
        {
            XDocument xmlDocMat = XDocument.Load("Materiales.XML");
            xmlDocMat.Element("materiales").Add(new XElement("material",
                                        new XAttribute("id", this.TextBox_ID.Text.Trim()),
                                        new XElement("nombre", TextBox_Nombre.Text.Trim()),
                                        new XElement("peso", TextBox_Peso.Text.Trim())));

            xmlDocMat.Save("Juegos.XML");
            LeerXML();
        }

        public void BorrarMaterial(string ID)
        {

            XDocument doc = XDocument.Load("Materiales.XML");

            var consulta = from Material in doc.Descendants("material")
                           where Material.Attribute("id").Value == ID
                           select Material;

            consulta.Remove();
            doc.Save("Materiales.XML");
        }

        public void ModificarMaterial(string ID)
        {

            XDocument doc = XDocument.Load("Materiales.XML");
            var consulta = from material in doc.Descendants("material")
                           where material.Attribute("id").Value == ID
                           select material;

            foreach (XElement EModifcar in consulta)
            {
                EModifcar.Element("nombre").Value = TextBox_Nombre.Text.Trim();
                EModifcar.Element("peso").Value = TextBox_Peso.Text.Trim();
            }
            doc.Save("Materiales.XML");
        }

        private void Limpiar()
        {
            TextBox_ID.Text = string.Empty;
            TextBox_Nombre.Text = string.Empty;
            TextBox_Peso.Text = string.Empty;
        }

        private void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LeerXML();
        }

        private void Button_Agregar_Mat_Click(object sender, EventArgs e)
        {
            AgregarXML();
            CargarGrilla();
        }

        private void Button_Mod_Mat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ModificarMaterial(TextBox_ID.Text);
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione el material a modificar");
            }
        }

        private void Button_Borrar_Mat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BorrarMaterial(TextBox_ID.Text);
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione el material a borrar");
            }
        }

        private void Button_Clean_TXB_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Button_Show_XML_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            BEMaterial oMaterial = new BEMaterial();
            oMaterial = (BEMaterial)dataGridView1.CurrentRow.DataBoundItem;
            TextBox_ID.Text = oMaterial.Codigo.ToString().Trim();
            TextBox_Nombre.Text = oMaterial.Nombre.Trim();
            TextBox_Peso.Text = oMaterial.Peso.ToString().Trim();
        }
    }
}
