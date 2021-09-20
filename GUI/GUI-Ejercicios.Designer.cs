
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
            this.TextBox_ID_Ejercicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boton_Cerrar = new System.Windows.Forms.Button();
            this.Boton_Modificar_Ejercicio = new System.Windows.Forms.Button();
            this.Boton_Baja_Ejercicio = new System.Windows.Forms.Button();
            this.Boton_Alta_Ejercicio = new System.Windows.Forms.Button();
            this.TextBox_Nombre_Ejercicio = new System.Windows.Forms.TextBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.ComboBox_Materiales = new System.Windows.Forms.ComboBox();
            this.ComboBox_Musculos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_ID_Musculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Nombre_Musculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_ID_Material = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Nombre_Material = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_Peso_Material = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Calcular_Cant_Herramientas = new System.Windows.Forms.Button();
            this.TextBox_Herramienta_utilizada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID_Ejercicio
            // 
            this.TextBox_ID_Ejercicio.Location = new System.Drawing.Point(159, 397);
            this.TextBox_ID_Ejercicio.Name = "TextBox_ID_Ejercicio";
            this.TextBox_ID_Ejercicio.ReadOnly = true;
            this.TextBox_ID_Ejercicio.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID_Ejercicio.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID del ejercicio";
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Location = new System.Drawing.Point(736, 484);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cerrar.TabIndex = 28;
            this.Boton_Cerrar.Text = "Salir";
            this.Boton_Cerrar.UseVisualStyleBackColor = true;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // Boton_Modificar_Ejercicio
            // 
            this.Boton_Modificar_Ejercicio.Location = new System.Drawing.Point(736, 455);
            this.Boton_Modificar_Ejercicio.Name = "Boton_Modificar_Ejercicio";
            this.Boton_Modificar_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar_Ejercicio.TabIndex = 27;
            this.Boton_Modificar_Ejercicio.Text = "Modificar";
            this.Boton_Modificar_Ejercicio.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Ejercicio.Click += new System.EventHandler(this.Boton_Modificar_Ejercicio_Click);
            // 
            // Boton_Baja_Ejercicio
            // 
            this.Boton_Baja_Ejercicio.Location = new System.Drawing.Point(735, 426);
            this.Boton_Baja_Ejercicio.Name = "Boton_Baja_Ejercicio";
            this.Boton_Baja_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja_Ejercicio.TabIndex = 26;
            this.Boton_Baja_Ejercicio.Text = "Baja";
            this.Boton_Baja_Ejercicio.UseVisualStyleBackColor = true;
            this.Boton_Baja_Ejercicio.Click += new System.EventHandler(this.Boton_Baja_Ejercicio_Click);
            // 
            // Boton_Alta_Ejercicio
            // 
            this.Boton_Alta_Ejercicio.Location = new System.Drawing.Point(736, 397);
            this.Boton_Alta_Ejercicio.Name = "Boton_Alta_Ejercicio";
            this.Boton_Alta_Ejercicio.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta_Ejercicio.TabIndex = 25;
            this.Boton_Alta_Ejercicio.Text = "Alta";
            this.Boton_Alta_Ejercicio.UseVisualStyleBackColor = true;
            this.Boton_Alta_Ejercicio.Click += new System.EventHandler(this.Boton_Alta_Ejercicio_Click);
            // 
            // TextBox_Nombre_Ejercicio
            // 
            this.TextBox_Nombre_Ejercicio.Location = new System.Drawing.Point(13, 397);
            this.TextBox_Nombre_Ejercicio.Name = "TextBox_Nombre_Ejercicio";
            this.TextBox_Nombre_Ejercicio.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre_Ejercicio.TabIndex = 24;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(10, 381);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(103, 13);
            this.Label_Nombre.TabIndex = 23;
            this.Label_Nombre.Tag = "";
            this.Label_Nombre.Text = "Nombre del ejercicio";
            // 
            // ComboBox_Materiales
            // 
            this.ComboBox_Materiales.FormattingEnabled = true;
            this.ComboBox_Materiales.Location = new System.Drawing.Point(581, 397);
            this.ComboBox_Materiales.Name = "ComboBox_Materiales";
            this.ComboBox_Materiales.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Materiales.TabIndex = 31;
            // 
            // ComboBox_Musculos
            // 
            this.ComboBox_Musculos.FormattingEnabled = true;
            this.ComboBox_Musculos.Location = new System.Drawing.Point(435, 397);
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
            this.label2.Location = new System.Drawing.Point(435, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Musculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Materiales";
            // 
            // TextBox_ID_Musculo
            // 
            this.TextBox_ID_Musculo.Location = new System.Drawing.Point(159, 448);
            this.TextBox_ID_Musculo.Name = "TextBox_ID_Musculo";
            this.TextBox_ID_Musculo.ReadOnly = true;
            this.TextBox_ID_Musculo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID_Musculo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID del musculo";
            // 
            // TextBox_Nombre_Musculo
            // 
            this.TextBox_Nombre_Musculo.Location = new System.Drawing.Point(13, 448);
            this.TextBox_Nombre_Musculo.Name = "TextBox_Nombre_Musculo";
            this.TextBox_Nombre_Musculo.ReadOnly = true;
            this.TextBox_Nombre_Musculo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre_Musculo.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 36;
            this.label5.Tag = "";
            this.label5.Text = "Nombre del musculo";
            // 
            // TextBox_ID_Material
            // 
            this.TextBox_ID_Material.Location = new System.Drawing.Point(159, 502);
            this.TextBox_ID_Material.Name = "TextBox_ID_Material";
            this.TextBox_ID_Material.ReadOnly = true;
            this.TextBox_ID_Material.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID_Material.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID del material";
            // 
            // TextBox_Nombre_Material
            // 
            this.TextBox_Nombre_Material.Location = new System.Drawing.Point(13, 502);
            this.TextBox_Nombre_Material.Name = "TextBox_Nombre_Material";
            this.TextBox_Nombre_Material.ReadOnly = true;
            this.TextBox_Nombre_Material.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre_Material.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 40;
            this.label7.Tag = "";
            this.label7.Text = "Nombre del material";
            // 
            // TextBox_Peso_Material
            // 
            this.TextBox_Peso_Material.Location = new System.Drawing.Point(312, 502);
            this.TextBox_Peso_Material.Name = "TextBox_Peso_Material";
            this.TextBox_Peso_Material.ReadOnly = true;
            this.TextBox_Peso_Material.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Peso_Material.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Peso del material";
            // 
            // Calcular_Cant_Herramientas
            // 
            this.Calcular_Cant_Herramientas.Location = new System.Drawing.Point(709, 57);
            this.Calcular_Cant_Herramientas.Name = "Calcular_Cant_Herramientas";
            this.Calcular_Cant_Herramientas.Size = new System.Drawing.Size(147, 36);
            this.Calcular_Cant_Herramientas.TabIndex = 46;
            this.Calcular_Cant_Herramientas.Text = "Calcular la hjerramienta mas utilizada";
            this.Calcular_Cant_Herramientas.UseVisualStyleBackColor = true;
            this.Calcular_Cant_Herramientas.Click += new System.EventHandler(this.Calcular_Cant_Herramientas_Click);
            // 
            // TextBox_Herramienta_utilizada
            // 
            this.TextBox_Herramienta_utilizada.Location = new System.Drawing.Point(709, 99);
            this.TextBox_Herramienta_utilizada.Multiline = true;
            this.TextBox_Herramienta_utilizada.Name = "TextBox_Herramienta_utilizada";
            this.TextBox_Herramienta_utilizada.Size = new System.Drawing.Size(147, 78);
            this.TextBox_Herramienta_utilizada.TabIndex = 47;
            // 
            // GUI_Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 534);
            this.Controls.Add(this.TextBox_Herramienta_utilizada);
            this.Controls.Add(this.Calcular_Cant_Herramientas);
            this.Controls.Add(this.TextBox_Peso_Material);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox_ID_Material);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_Nombre_Material);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBox_ID_Musculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Nombre_Musculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBox_Musculos);
            this.Controls.Add(this.ComboBox_Materiales);
            this.Controls.Add(this.TextBox_ID_Ejercicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Cerrar);
            this.Controls.Add(this.Boton_Modificar_Ejercicio);
            this.Controls.Add(this.Boton_Baja_Ejercicio);
            this.Controls.Add(this.Boton_Alta_Ejercicio);
            this.Controls.Add(this.TextBox_Nombre_Ejercicio);
            this.Controls.Add(this.Label_Nombre);
            this.Name = "GUI_Ejercicios";
            this.Text = "GUI_Ejercicios";
            this.Load += new System.EventHandler(this.GUI_Ejercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID_Ejercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Cerrar;
        private System.Windows.Forms.Button Boton_Modificar_Ejercicio;
        private System.Windows.Forms.Button Boton_Baja_Ejercicio;
        private System.Windows.Forms.Button Boton_Alta_Ejercicio;
        private System.Windows.Forms.TextBox TextBox_Nombre_Ejercicio;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.ComboBox ComboBox_Materiales;
        private System.Windows.Forms.ComboBox ComboBox_Musculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_ID_Musculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Nombre_Musculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_ID_Material;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Nombre_Material;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_Peso_Material;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Calcular_Cant_Herramientas;
        private System.Windows.Forms.TextBox TextBox_Herramienta_utilizada;
    }
}