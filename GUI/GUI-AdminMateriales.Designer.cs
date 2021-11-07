
namespace GUI
{
    partial class GUI_AdminMateriales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Clean_TXB = new System.Windows.Forms.Button();
            this.Button_Mod_Mat = new System.Windows.Forms.Button();
            this.Button_Borrar_Mat = new System.Windows.Forms.Button();
            this.Button_Agregar_Mat = new System.Windows.Forms.Button();
            this.Button_Show_XML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Peso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Clean_TXB
            // 
            this.Button_Clean_TXB.Location = new System.Drawing.Point(138, 49);
            this.Button_Clean_TXB.Name = "Button_Clean_TXB";
            this.Button_Clean_TXB.Size = new System.Drawing.Size(103, 21);
            this.Button_Clean_TXB.TabIndex = 63;
            this.Button_Clean_TXB.Text = "Limpiar";
            this.Button_Clean_TXB.UseVisualStyleBackColor = true;
            this.Button_Clean_TXB.Click += new System.EventHandler(this.Button_Clean_TXB_Click);
            // 
            // Button_Mod_Mat
            // 
            this.Button_Mod_Mat.Location = new System.Drawing.Point(12, 46);
            this.Button_Mod_Mat.Name = "Button_Mod_Mat";
            this.Button_Mod_Mat.Size = new System.Drawing.Size(103, 28);
            this.Button_Mod_Mat.TabIndex = 62;
            this.Button_Mod_Mat.Text = "Modificar Material";
            this.Button_Mod_Mat.UseVisualStyleBackColor = true;
            this.Button_Mod_Mat.Click += new System.EventHandler(this.Button_Mod_Mat_Click);
            // 
            // Button_Borrar_Mat
            // 
            this.Button_Borrar_Mat.Location = new System.Drawing.Point(12, 81);
            this.Button_Borrar_Mat.Name = "Button_Borrar_Mat";
            this.Button_Borrar_Mat.Size = new System.Drawing.Size(103, 28);
            this.Button_Borrar_Mat.TabIndex = 61;
            this.Button_Borrar_Mat.Text = "Borrar Material";
            this.Button_Borrar_Mat.UseVisualStyleBackColor = true;
            this.Button_Borrar_Mat.Click += new System.EventHandler(this.Button_Borrar_Mat_Click);
            // 
            // Button_Agregar_Mat
            // 
            this.Button_Agregar_Mat.Location = new System.Drawing.Point(12, 12);
            this.Button_Agregar_Mat.Name = "Button_Agregar_Mat";
            this.Button_Agregar_Mat.Size = new System.Drawing.Size(103, 28);
            this.Button_Agregar_Mat.TabIndex = 60;
            this.Button_Agregar_Mat.Text = "Agregar Material";
            this.Button_Agregar_Mat.UseVisualStyleBackColor = true;
            this.Button_Agregar_Mat.Click += new System.EventHandler(this.Button_Agregar_Mat_Click);
            // 
            // Button_Show_XML
            // 
            this.Button_Show_XML.Location = new System.Drawing.Point(138, 12);
            this.Button_Show_XML.Name = "Button_Show_XML";
            this.Button_Show_XML.Size = new System.Drawing.Size(103, 21);
            this.Button_Show_XML.TabIndex = 59;
            this.Button_Show_XML.Text = "Mostrar XML";
            this.Button_Show_XML.UseVisualStyleBackColor = true;
            this.Button_Show_XML.Click += new System.EventHandler(this.Button_Show_XML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 223);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Material Id";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(352, 12);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID.TabIndex = 71;
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(352, 38);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 72;
            // 
            // TextBox_Peso
            // 
            this.TextBox_Peso.Location = new System.Drawing.Point(352, 64);
            this.TextBox_Peso.Name = "TextBox_Peso";
            this.TextBox_Peso.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Peso.TabIndex = 73;
            // 
            // GUI_AdminMAteriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 364);
            this.Controls.Add(this.TextBox_Peso);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Clean_TXB);
            this.Controls.Add(this.Button_Mod_Mat);
            this.Controls.Add(this.Button_Borrar_Mat);
            this.Controls.Add(this.Button_Agregar_Mat);
            this.Controls.Add(this.Button_Show_XML);
            this.Name = "GUI_AdminMAteriales";
            this.Text = "GUI_AdminMAteriales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Clean_TXB;
        private System.Windows.Forms.Button Button_Mod_Mat;
        private System.Windows.Forms.Button Button_Borrar_Mat;
        private System.Windows.Forms.Button Button_Agregar_Mat;
        private System.Windows.Forms.Button Button_Show_XML;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Peso;
    }
}