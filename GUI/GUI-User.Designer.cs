
namespace GUI
{
    partial class GUI_User
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
            this.Grilla_rutina = new System.Windows.Forms.DataGridView();
            this.Generar_Rutina = new System.Windows.Forms.Button();
            this.Boton_Alta_usuario = new System.Windows.Forms.Button();
            this.Seleccionar_Usuario = new System.Windows.Forms.Button();
            this.Ingreso_Materiales = new System.Windows.Forms.Button();
            this.Grilla_Materiales_Disponibles = new System.Windows.Forms.DataGridView();
            this.Grilla_Materiales_Seleccionados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Alta_Fem = new System.Windows.Forms.RadioButton();
            this.radioButton_Alta_Masc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Apellido = new System.Windows.Forms.TextBox();
            this.TextBox_Sexo = new System.Windows.Forms.TextBox();
            this.TextBox_Codigo = new System.Windows.Forms.TextBox();
            this.Boton_Modificar_Datos = new System.Windows.Forms.Button();
            this.Boton_Aceptar_Cambios = new System.Windows.Forms.Button();
            this.radioButton_Mod_Fem = new System.Windows.Forms.RadioButton();
            this.radioButton_Mod_Masc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_rutina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_rutina
            // 
            this.Grilla_rutina.AllowUserToAddRows = false;
            this.Grilla_rutina.AllowUserToDeleteRows = false;
            this.Grilla_rutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_rutina.Location = new System.Drawing.Point(12, 71);
            this.Grilla_rutina.Name = "Grilla_rutina";
            this.Grilla_rutina.ReadOnly = true;
            this.Grilla_rutina.Size = new System.Drawing.Size(217, 377);
            this.Grilla_rutina.TabIndex = 0;
            // 
            // Generar_Rutina
            // 
            this.Generar_Rutina.Location = new System.Drawing.Point(12, 12);
            this.Generar_Rutina.Name = "Generar_Rutina";
            this.Generar_Rutina.Size = new System.Drawing.Size(217, 35);
            this.Generar_Rutina.TabIndex = 2;
            this.Generar_Rutina.Text = "Genere su rutina";
            this.Generar_Rutina.UseVisualStyleBackColor = true;
            // 
            // Boton_Alta_usuario
            // 
            this.Boton_Alta_usuario.Location = new System.Drawing.Point(633, 12);
            this.Boton_Alta_usuario.Name = "Boton_Alta_usuario";
            this.Boton_Alta_usuario.Size = new System.Drawing.Size(166, 26);
            this.Boton_Alta_usuario.TabIndex = 3;
            this.Boton_Alta_usuario.Text = "Alta Usuario";
            this.Boton_Alta_usuario.UseVisualStyleBackColor = true;
            this.Boton_Alta_usuario.Click += new System.EventHandler(this.Alta_usuario_Click);
            // 
            // Seleccionar_Usuario
            // 
            this.Seleccionar_Usuario.Location = new System.Drawing.Point(276, 12);
            this.Seleccionar_Usuario.Name = "Seleccionar_Usuario";
            this.Seleccionar_Usuario.Size = new System.Drawing.Size(227, 26);
            this.Seleccionar_Usuario.TabIndex = 4;
            this.Seleccionar_Usuario.Text = "Ingrese su DNI";
            this.Seleccionar_Usuario.UseVisualStyleBackColor = true;
            this.Seleccionar_Usuario.Click += new System.EventHandler(this.Seleccionar_Usuario_Click);
            // 
            // Ingreso_Materiales
            // 
            this.Ingreso_Materiales.Location = new System.Drawing.Point(486, 375);
            this.Ingreso_Materiales.Name = "Ingreso_Materiales";
            this.Ingreso_Materiales.Size = new System.Drawing.Size(91, 31);
            this.Ingreso_Materiales.TabIndex = 5;
            this.Ingreso_Materiales.Text = "Seleccione las herramientas que tiene y oprima el boton";
            this.Ingreso_Materiales.UseVisualStyleBackColor = true;
            this.Ingreso_Materiales.Click += new System.EventHandler(this.Ingreso_Materiales_Click);
            // 
            // Grilla_Materiales_Disponibles
            // 
            this.Grilla_Materiales_Disponibles.AllowUserToAddRows = false;
            this.Grilla_Materiales_Disponibles.AllowUserToDeleteRows = false;
            this.Grilla_Materiales_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Materiales_Disponibles.Location = new System.Drawing.Point(253, 284);
            this.Grilla_Materiales_Disponibles.Name = "Grilla_Materiales_Disponibles";
            this.Grilla_Materiales_Disponibles.ReadOnly = true;
            this.Grilla_Materiales_Disponibles.Size = new System.Drawing.Size(218, 164);
            this.Grilla_Materiales_Disponibles.TabIndex = 6;
            // 
            // Grilla_Materiales_Seleccionados
            // 
            this.Grilla_Materiales_Seleccionados.AllowUserToAddRows = false;
            this.Grilla_Materiales_Seleccionados.AllowUserToDeleteRows = false;
            this.Grilla_Materiales_Seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Materiales_Seleccionados.Location = new System.Drawing.Point(592, 284);
            this.Grilla_Materiales_Seleccionados.Name = "Grilla_Materiales_Seleccionados";
            this.Grilla_Materiales_Seleccionados.ReadOnly = true;
            this.Grilla_Materiales_Seleccionados.Size = new System.Drawing.Size(218, 164);
            this.Grilla_Materiales_Seleccionados.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Herramientas disponibles";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(617, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Herramientas del usuario";
            // 
            // radioButton_Alta_Fem
            // 
            this.radioButton_Alta_Fem.AutoSize = true;
            this.radioButton_Alta_Fem.Location = new System.Drawing.Point(666, 45);
            this.radioButton_Alta_Fem.Name = "radioButton_Alta_Fem";
            this.radioButton_Alta_Fem.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Alta_Fem.TabIndex = 10;
            this.radioButton_Alta_Fem.TabStop = true;
            this.radioButton_Alta_Fem.Text = "Femenino";
            this.radioButton_Alta_Fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_Alta_Masc
            // 
            this.radioButton_Alta_Masc.AutoSize = true;
            this.radioButton_Alta_Masc.Location = new System.Drawing.Point(666, 71);
            this.radioButton_Alta_Masc.Name = "radioButton_Alta_Masc";
            this.radioButton_Alta_Masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Alta_Masc.TabIndex = 11;
            this.radioButton_Alta_Masc.TabStop = true;
            this.radioButton_Alta_Masc.Text = "Masculino";
            this.radioButton_Alta_Masc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Agregar / Quitar";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Enabled = false;
            this.TextBox_Nombre.Location = new System.Drawing.Point(276, 71);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 13;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Enabled = false;
            this.TextBox_Apellido.Location = new System.Drawing.Point(403, 71);
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Apellido.TabIndex = 14;
            // 
            // TextBox_Sexo
            // 
            this.TextBox_Sexo.Enabled = false;
            this.TextBox_Sexo.Location = new System.Drawing.Point(276, 97);
            this.TextBox_Sexo.Name = "TextBox_Sexo";
            this.TextBox_Sexo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Sexo.TabIndex = 15;
            // 
            // TextBox_Codigo
            // 
            this.TextBox_Codigo.Enabled = false;
            this.TextBox_Codigo.Location = new System.Drawing.Point(403, 97);
            this.TextBox_Codigo.Name = "TextBox_Codigo";
            this.TextBox_Codigo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Codigo.TabIndex = 16;
            // 
            // Boton_Modificar_Datos
            // 
            this.Boton_Modificar_Datos.Location = new System.Drawing.Point(276, 161);
            this.Boton_Modificar_Datos.Name = "Boton_Modificar_Datos";
            this.Boton_Modificar_Datos.Size = new System.Drawing.Size(100, 23);
            this.Boton_Modificar_Datos.TabIndex = 17;
            this.Boton_Modificar_Datos.Text = "Modificar datos";
            this.Boton_Modificar_Datos.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Datos.Click += new System.EventHandler(this.Modificar_Datos_Click);
            // 
            // Boton_Aceptar_Cambios
            // 
            this.Boton_Aceptar_Cambios.Enabled = false;
            this.Boton_Aceptar_Cambios.Location = new System.Drawing.Point(403, 161);
            this.Boton_Aceptar_Cambios.Name = "Boton_Aceptar_Cambios";
            this.Boton_Aceptar_Cambios.Size = new System.Drawing.Size(100, 23);
            this.Boton_Aceptar_Cambios.TabIndex = 18;
            this.Boton_Aceptar_Cambios.Text = "Aceptar Cambios";
            this.Boton_Aceptar_Cambios.UseVisualStyleBackColor = true;
            this.Boton_Aceptar_Cambios.Click += new System.EventHandler(this.Boton_Aceptar_Cambios_Click);
            // 
            // radioButton_Mod_Fem
            // 
            this.radioButton_Mod_Fem.AutoSize = true;
            this.radioButton_Mod_Fem.Location = new System.Drawing.Point(276, 128);
            this.radioButton_Mod_Fem.Name = "radioButton_Mod_Fem";
            this.radioButton_Mod_Fem.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Mod_Fem.TabIndex = 19;
            this.radioButton_Mod_Fem.TabStop = true;
            this.radioButton_Mod_Fem.Text = "Femenino";
            this.radioButton_Mod_Fem.UseVisualStyleBackColor = true;
            this.radioButton_Mod_Fem.Visible = false;
            // 
            // radioButton_Mod_Masc
            // 
            this.radioButton_Mod_Masc.AutoSize = true;
            this.radioButton_Mod_Masc.Location = new System.Drawing.Point(403, 128);
            this.radioButton_Mod_Masc.Name = "radioButton_Mod_Masc";
            this.radioButton_Mod_Masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Mod_Masc.TabIndex = 20;
            this.radioButton_Mod_Masc.TabStop = true;
            this.radioButton_Mod_Masc.Text = "Masculino";
            this.radioButton_Mod_Masc.UseVisualStyleBackColor = true;
            this.radioButton_Mod_Masc.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(253, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 38);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(633, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 66);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 460);
            this.Controls.Add(this.radioButton_Mod_Masc);
            this.Controls.Add(this.radioButton_Mod_Fem);
            this.Controls.Add(this.Boton_Aceptar_Cambios);
            this.Controls.Add(this.Boton_Modificar_Datos);
            this.Controls.Add(this.TextBox_Codigo);
            this.Controls.Add(this.TextBox_Sexo);
            this.Controls.Add(this.TextBox_Apellido);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_Alta_Masc);
            this.Controls.Add(this.radioButton_Alta_Fem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Materiales_Seleccionados);
            this.Controls.Add(this.Grilla_Materiales_Disponibles);
            this.Controls.Add(this.Ingreso_Materiales);
            this.Controls.Add(this.Seleccionar_Usuario);
            this.Controls.Add(this.Boton_Alta_usuario);
            this.Controls.Add(this.Generar_Rutina);
            this.Controls.Add(this.Grilla_rutina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GUI_User";
            this.Text = "GUI_User";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_rutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_rutina;
        private System.Windows.Forms.Button Generar_Rutina;
        private System.Windows.Forms.Button Boton_Alta_usuario;
        private System.Windows.Forms.Button Seleccionar_Usuario;
        private System.Windows.Forms.Button Ingreso_Materiales;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Disponibles;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Seleccionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Alta_Fem;
        private System.Windows.Forms.RadioButton radioButton_Alta_Masc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Apellido;
        private System.Windows.Forms.TextBox TextBox_Sexo;
        private System.Windows.Forms.TextBox TextBox_Codigo;
        private System.Windows.Forms.Button Boton_Modificar_Datos;
        private System.Windows.Forms.Button Boton_Aceptar_Cambios;
        private System.Windows.Forms.RadioButton radioButton_Mod_Fem;
        private System.Windows.Forms.RadioButton radioButton_Mod_Masc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}