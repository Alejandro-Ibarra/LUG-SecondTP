
namespace GUI
{
    partial class GUI_UsrAlumno
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
            this.Grilla_Rutina = new System.Windows.Forms.DataGridView();
            this.Generar_Rutina = new System.Windows.Forms.Button();
            this.Ingreso_Materiales = new System.Windows.Forms.Button();
            this.Grilla_Materiales_Disponibles = new System.Windows.Forms.DataGridView();
            this.Grilla_Materiales_Seleccionados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Codigo = new System.Windows.Forms.TextBox();
            this.Eliminar_Materiales = new System.Windows.Forms.Button();
            this.RadioButton_Aerobico = new System.Windows.Forms.RadioButton();
            this.RadioButton_Hipertrofia = new System.Windows.Forms.RadioButton();
            this.GroupBox_Tipo_Rutina = new System.Windows.Forms.GroupBox();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_Sexo = new System.Windows.Forms.ComboBox();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Apellido = new System.Windows.Forms.TextBox();
            this.Boton_Modificar_Datos_Personales = new System.Windows.Forms.Button();
            this.ComboBox_Valoracion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Rutina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).BeginInit();
            this.GroupBox_Tipo_Rutina.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grilla_Rutina
            // 
            this.Grilla_Rutina.AllowUserToAddRows = false;
            this.Grilla_Rutina.AllowUserToDeleteRows = false;
            this.Grilla_Rutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Rutina.Location = new System.Drawing.Point(12, 71);
            this.Grilla_Rutina.Name = "Grilla_Rutina";
            this.Grilla_Rutina.ReadOnly = true;
            this.Grilla_Rutina.Size = new System.Drawing.Size(469, 377);
            this.Grilla_Rutina.TabIndex = 0;
            // 
            // Generar_Rutina
            // 
            this.Generar_Rutina.Location = new System.Drawing.Point(13, 16);
            this.Generar_Rutina.Name = "Generar_Rutina";
            this.Generar_Rutina.Size = new System.Drawing.Size(217, 35);
            this.Generar_Rutina.TabIndex = 2;
            this.Generar_Rutina.Text = "Genere su rutina";
            this.Generar_Rutina.UseVisualStyleBackColor = true;
            this.Generar_Rutina.Click += new System.EventHandler(this.Generar_Rutina_Click);
            // 
            // Ingreso_Materiales
            // 
            this.Ingreso_Materiales.Location = new System.Drawing.Point(402, 547);
            this.Ingreso_Materiales.Name = "Ingreso_Materiales";
            this.Ingreso_Materiales.Size = new System.Drawing.Size(91, 37);
            this.Ingreso_Materiales.TabIndex = 5;
            this.Ingreso_Materiales.Text = "Agregar Materiales";
            this.Ingreso_Materiales.UseVisualStyleBackColor = true;
            this.Ingreso_Materiales.Click += new System.EventHandler(this.Ingreso_Materiales_Click);
            // 
            // Grilla_Materiales_Disponibles
            // 
            this.Grilla_Materiales_Disponibles.AllowUserToAddRows = false;
            this.Grilla_Materiales_Disponibles.AllowUserToDeleteRows = false;
            this.Grilla_Materiales_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Materiales_Disponibles.Location = new System.Drawing.Point(13, 498);
            this.Grilla_Materiales_Disponibles.Name = "Grilla_Materiales_Disponibles";
            this.Grilla_Materiales_Disponibles.ReadOnly = true;
            this.Grilla_Materiales_Disponibles.Size = new System.Drawing.Size(377, 164);
            this.Grilla_Materiales_Disponibles.TabIndex = 6;
            // 
            // Grilla_Materiales_Seleccionados
            // 
            this.Grilla_Materiales_Seleccionados.AllowUserToAddRows = false;
            this.Grilla_Materiales_Seleccionados.AllowUserToDeleteRows = false;
            this.Grilla_Materiales_Seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Materiales_Seleccionados.Location = new System.Drawing.Point(506, 498);
            this.Grilla_Materiales_Seleccionados.Name = "Grilla_Materiales_Seleccionados";
            this.Grilla_Materiales_Seleccionados.ReadOnly = true;
            this.Grilla_Materiales_Seleccionados.Size = new System.Drawing.Size(377, 164);
            this.Grilla_Materiales_Seleccionados.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Materiales disponibles";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(584, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materiales del usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Agregar / Quitar";
            // 
            // TextBox_Codigo
            // 
            this.TextBox_Codigo.Enabled = false;
            this.TextBox_Codigo.Location = new System.Drawing.Point(737, 138);
            this.TextBox_Codigo.Name = "TextBox_Codigo";
            this.TextBox_Codigo.ReadOnly = true;
            this.TextBox_Codigo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Codigo.TabIndex = 16;
            // 
            // Eliminar_Materiales
            // 
            this.Eliminar_Materiales.Location = new System.Drawing.Point(402, 606);
            this.Eliminar_Materiales.Name = "Eliminar_Materiales";
            this.Eliminar_Materiales.Size = new System.Drawing.Size(91, 37);
            this.Eliminar_Materiales.TabIndex = 23;
            this.Eliminar_Materiales.Text = "Quitar Materiales";
            this.Eliminar_Materiales.UseVisualStyleBackColor = true;
            this.Eliminar_Materiales.Click += new System.EventHandler(this.Eliminar_Materiales_Click);
            // 
            // RadioButton_Aerobico
            // 
            this.RadioButton_Aerobico.AutoSize = true;
            this.RadioButton_Aerobico.Location = new System.Drawing.Point(6, 39);
            this.RadioButton_Aerobico.Name = "RadioButton_Aerobico";
            this.RadioButton_Aerobico.Size = new System.Drawing.Size(67, 17);
            this.RadioButton_Aerobico.TabIndex = 26;
            this.RadioButton_Aerobico.Text = "Aerobico";
            this.RadioButton_Aerobico.UseVisualStyleBackColor = true;
            this.RadioButton_Aerobico.Visible = false;
            // 
            // RadioButton_Hipertrofia
            // 
            this.RadioButton_Hipertrofia.AutoSize = true;
            this.RadioButton_Hipertrofia.Checked = true;
            this.RadioButton_Hipertrofia.Location = new System.Drawing.Point(6, 16);
            this.RadioButton_Hipertrofia.Name = "RadioButton_Hipertrofia";
            this.RadioButton_Hipertrofia.Size = new System.Drawing.Size(73, 17);
            this.RadioButton_Hipertrofia.TabIndex = 25;
            this.RadioButton_Hipertrofia.TabStop = true;
            this.RadioButton_Hipertrofia.Text = "Hipertrofia";
            this.RadioButton_Hipertrofia.UseVisualStyleBackColor = true;
            this.RadioButton_Hipertrofia.Visible = false;
            // 
            // GroupBox_Tipo_Rutina
            // 
            this.GroupBox_Tipo_Rutina.Controls.Add(this.RadioButton_Aerobico);
            this.GroupBox_Tipo_Rutina.Controls.Add(this.RadioButton_Hipertrofia);
            this.GroupBox_Tipo_Rutina.Location = new System.Drawing.Point(236, -2);
            this.GroupBox_Tipo_Rutina.Name = "GroupBox_Tipo_Rutina";
            this.GroupBox_Tipo_Rutina.Size = new System.Drawing.Size(90, 67);
            this.GroupBox_Tipo_Rutina.TabIndex = 27;
            this.GroupBox_Tipo_Rutina.TabStop = false;
            this.GroupBox_Tipo_Rutina.Visible = false;
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Location = new System.Drawing.Point(757, 19);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(123, 53);
            this.Boton_Salir.TabIndex = 28;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Codigo";
            // 
            // ComboBox_Sexo
            // 
            this.ComboBox_Sexo.FormattingEnabled = true;
            this.ComboBox_Sexo.Location = new System.Drawing.Point(610, 138);
            this.ComboBox_Sexo.Name = "ComboBox_Sexo";
            this.ComboBox_Sexo.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_Sexo.TabIndex = 104;
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(610, 92);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 105;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Location = new System.Drawing.Point(737, 92);
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Apellido.TabIndex = 106;
            // 
            // Boton_Modificar_Datos_Personales
            // 
            this.Boton_Modificar_Datos_Personales.Location = new System.Drawing.Point(610, 265);
            this.Boton_Modificar_Datos_Personales.Name = "Boton_Modificar_Datos_Personales";
            this.Boton_Modificar_Datos_Personales.Size = new System.Drawing.Size(227, 23);
            this.Boton_Modificar_Datos_Personales.TabIndex = 107;
            this.Boton_Modificar_Datos_Personales.Text = "Modificar datos personales";
            this.Boton_Modificar_Datos_Personales.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Datos_Personales.Click += new System.EventHandler(this.Boton_Modificar_Datos_Personales_Click_1);
            // 
            // ComboBox_Valoracion
            // 
            this.ComboBox_Valoracion.FormattingEnabled = true;
            this.ComboBox_Valoracion.Location = new System.Drawing.Point(699, 221);
            this.ComboBox_Valoracion.Name = "ComboBox_Valoracion";
            this.ComboBox_Valoracion.Size = new System.Drawing.Size(41, 21);
            this.ComboBox_Valoracion.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(644, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 32);
            this.label8.TabIndex = 109;
            this.label8.Text = "Indique cuan satisfecho se encuentra con la aplicacion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUI_UsrAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 685);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBox_Valoracion);
            this.Controls.Add(this.Boton_Modificar_Datos_Personales);
            this.Controls.Add(this.TextBox_Apellido);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.ComboBox_Sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Eliminar_Materiales);
            this.Controls.Add(this.TextBox_Codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Materiales_Seleccionados);
            this.Controls.Add(this.Grilla_Materiales_Disponibles);
            this.Controls.Add(this.Ingreso_Materiales);
            this.Controls.Add(this.Generar_Rutina);
            this.Controls.Add(this.Grilla_Rutina);
            this.Controls.Add(this.GroupBox_Tipo_Rutina);
            this.Name = "GUI_UsrAlumno";
            this.Text = "GUI_UsrAlumno";
            this.Load += new System.EventHandler(this.GUI_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Rutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).EndInit();
            this.GroupBox_Tipo_Rutina.ResumeLayout(false);
            this.GroupBox_Tipo_Rutina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Rutina;
        private System.Windows.Forms.Button Generar_Rutina;
        private System.Windows.Forms.Button Ingreso_Materiales;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Disponibles;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Seleccionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Codigo;
        private System.Windows.Forms.Button Eliminar_Materiales;
        private System.Windows.Forms.RadioButton RadioButton_Aerobico;
        private System.Windows.Forms.RadioButton RadioButton_Hipertrofia;
        private System.Windows.Forms.GroupBox GroupBox_Tipo_Rutina;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_Sexo;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Apellido;
        private System.Windows.Forms.Button Boton_Modificar_Datos_Personales;
        private System.Windows.Forms.ComboBox ComboBox_Valoracion;
        private System.Windows.Forms.Label label8;
    }
}