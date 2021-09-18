
namespace GUI
{
    partial class GUI_Ejercicios
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
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Cerrar = new System.Windows.Forms.Button();
            this.Boton_Modificar_Ejercicio = new System.Windows.Forms.Button();
            this.Boton_Baja_Ejercicio = new System.Windows.Forms.Button();
            this.Boton_Alta_Ejercicio = new System.Windows.Forms.Button();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.ComboBox_Materiales = new System.Windows.Forms.ComboBox();
            this.ComboBox_Musculos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(878, 141);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Location = new System.Drawing.Point(732, 341);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cerrar.TabIndex = 28;
            this.Boton_Cerrar.Text = "Salir";
            this.Boton_Cerrar.UseVisualStyleBackColor = true;
            // 
            // Boton_Modificar_Ejercicio
            // 
            this.Boton_Modificar_Ejercicio.Location = new System.Drawing.Point(732, 312);
            this.Boton_Modificar_Ejercicio.Name = "Boton_Modificar_Ejercicio";
            this.Boton_Modificar_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar_Ejercicio.TabIndex = 27;
            this.Boton_Modificar_Ejercicio.Text = "Modificar";
            this.Boton_Modificar_Ejercicio.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Ejercicio.Click += new System.EventHandler(this.Boton_Modificar_Ejercicio_Click);
            // 
            // Boton_Baja_Ejercicio
            // 
            this.Boton_Baja_Ejercicio.Location = new System.Drawing.Point(731, 283);
            this.Boton_Baja_Ejercicio.Name = "Boton_Baja_Ejercicio";
            this.Boton_Baja_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja_Ejercicio.TabIndex = 26;
            this.Boton_Baja_Ejercicio.Text = "Baja";
            this.Boton_Baja_Ejercicio.UseVisualStyleBackColor = true;
            // 
            // Boton_Alta_Ejercicio
            // 
            this.Boton_Alta_Ejercicio.Location = new System.Drawing.Point(732, 254);
            this.Boton_Alta_Ejercicio.Name = "Boton_Alta_Ejercicio";
            this.Boton_Alta_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta_Ejercicio.TabIndex = 25;
            this.Boton_Alta_Ejercicio.Text = "Alta";
            this.Boton_Alta_Ejercicio.UseVisualStyleBackColor = true;
            this.Boton_Alta_Ejercicio.Click += new System.EventHandler(this.Boton_Alta_Ejercicio_Click);
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(732, 141);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 24;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(729, 125);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Label_Nombre.TabIndex = 23;
            this.Label_Nombre.Tag = "";
            this.Label_Nombre.Text = "Nombre";
            // 
            // ComboBox_Materiales
            // 
            this.ComboBox_Materiales.FormattingEnabled = true;
            this.ComboBox_Materiales.Location = new System.Drawing.Point(878, 80);
            this.ComboBox_Materiales.Name = "ComboBox_Materiales";
            this.ComboBox_Materiales.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Materiales.TabIndex = 31;
            // 
            // ComboBox_Musculos
            // 
            this.ComboBox_Musculos.FormattingEnabled = true;
            this.ComboBox_Musculos.Location = new System.Drawing.Point(732, 80);
            this.ComboBox_Musculos.Name = "ComboBox_Musculos";
            this.ComboBox_Musculos.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Musculos.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 339);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Musculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Materiales";
            // 
            // GUI_Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBox_Musculos);
            this.Controls.Add(this.ComboBox_Materiales);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Cerrar);
            this.Controls.Add(this.Boton_Modificar_Ejercicio);
            this.Controls.Add(this.Boton_Baja_Ejercicio);
            this.Controls.Add(this.Boton_Alta_Ejercicio);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Name = "GUI_Ejercicios";
            this.Text = "GUI_Ejercicios";
            this.Load += new System.EventHandler(this.GUI_Ejercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Cerrar;
        private System.Windows.Forms.Button Boton_Modificar_Ejercicio;
        private System.Windows.Forms.Button Boton_Baja_Ejercicio;
        private System.Windows.Forms.Button Boton_Alta_Ejercicio;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.ComboBox ComboBox_Materiales;
        private System.Windows.Forms.ComboBox ComboBox_Musculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}