
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
            this.Grilla_Rutina = new System.Windows.Forms.DataGridView();
            this.Generar_Rutina = new System.Windows.Forms.Button();
            this.Boton_Alta_usuario = new System.Windows.Forms.Button();
            this.Boton_Seleccionar_Usuario = new System.Windows.Forms.Button();
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
            this.GroupBox_Alta_Sexo = new System.Windows.Forms.GroupBox();
            this.Eliminar_Materiales = new System.Windows.Forms.Button();
            this.Boton_Baja_Usuario = new System.Windows.Forms.Button();
            this.GroupBox_Mod_Sexo = new System.Windows.Forms.GroupBox();
            this.radioButton_Mod_Fem = new System.Windows.Forms.RadioButton();
            this.radioButton_Mod_Masc = new System.Windows.Forms.RadioButton();
            this.RadioButton_Aerobico = new System.Windows.Forms.RadioButton();
            this.RadioButton_Hipertrofia = new System.Windows.Forms.RadioButton();
            this.GroupBox_Tipo_Rutina = new System.Windows.Forms.GroupBox();
            this.Boton_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Rutina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).BeginInit();
            this.GroupBox_Alta_Sexo.SuspendLayout();
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
            // Boton_Alta_usuario
            // 
            this.Boton_Alta_usuario.Location = new System.Drawing.Point(550, 94);
            this.Boton_Alta_usuario.Name = "Boton_Alta_usuario";
            this.Boton_Alta_usuario.Size = new System.Drawing.Size(133, 26);
            this.Boton_Alta_usuario.TabIndex = 3;
            this.Boton_Alta_usuario.Text = "Alta Usuario";
            this.Boton_Alta_usuario.UseVisualStyleBackColor = true;
            this.Boton_Alta_usuario.Click += new System.EventHandler(this.Boton_Alta_usuario_Click);
            // 
            // Boton_Seleccionar_Usuario
            // 
            this.Boton_Seleccionar_Usuario.Location = new System.Drawing.Point(550, 12);
            this.Boton_Seleccionar_Usuario.Name = "Boton_Seleccionar_Usuario";
            this.Boton_Seleccionar_Usuario.Size = new System.Drawing.Size(133, 53);
            this.Boton_Seleccionar_Usuario.TabIndex = 4;
            this.Boton_Seleccionar_Usuario.Text = "Acceda a la aplicacion ingresando su DNI";
            this.Boton_Seleccionar_Usuario.UseVisualStyleBackColor = true;
            this.Boton_Seleccionar_Usuario.Click += new System.EventHandler(this.Boton_Seleccionar_Usuario_Click);
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
            // radioButton_Alta_Fem
            // 
            this.radioButton_Alta_Fem.AutoSize = true;
            this.radioButton_Alta_Fem.Location = new System.Drawing.Point(24, 7);
            this.radioButton_Alta_Fem.Name = "radioButton_Alta_Fem";
            this.radioButton_Alta_Fem.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Alta_Fem.TabIndex = 10;
            this.radioButton_Alta_Fem.Text = "Femenino";
            this.radioButton_Alta_Fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_Alta_Masc
            // 
            this.radioButton_Alta_Masc.AutoSize = true;
            this.radioButton_Alta_Masc.Location = new System.Drawing.Point(24, 33);
            this.radioButton_Alta_Masc.Name = "radioButton_Alta_Masc";
            this.radioButton_Alta_Masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Alta_Masc.TabIndex = 11;
            this.radioButton_Alta_Masc.Text = "Masculino";
            this.radioButton_Alta_Masc.UseVisualStyleBackColor = true;
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
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Enabled = false;
            this.TextBox_Nombre.Location = new System.Drawing.Point(550, 280);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 13;
            // 
            // TextBox_Apellido
            // 
            this.TextBox_Apellido.Enabled = false;
            this.TextBox_Apellido.Location = new System.Drawing.Point(677, 280);
            this.TextBox_Apellido.Name = "TextBox_Apellido";
            this.TextBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Apellido.TabIndex = 14;
            // 
            // TextBox_Sexo
            // 
            this.TextBox_Sexo.Enabled = false;
            this.TextBox_Sexo.Location = new System.Drawing.Point(550, 306);
            this.TextBox_Sexo.Name = "TextBox_Sexo";
            this.TextBox_Sexo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Sexo.TabIndex = 15;
            // 
            // TextBox_Codigo
            // 
            this.TextBox_Codigo.Enabled = false;
            this.TextBox_Codigo.Location = new System.Drawing.Point(677, 306);
            this.TextBox_Codigo.Name = "TextBox_Codigo";
            this.TextBox_Codigo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Codigo.TabIndex = 16;
            // 
            // Boton_Modificar_Datos
            // 
            this.Boton_Modificar_Datos.Location = new System.Drawing.Point(550, 370);
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
            this.Boton_Aceptar_Cambios.Location = new System.Drawing.Point(677, 370);
            this.Boton_Aceptar_Cambios.Name = "Boton_Aceptar_Cambios";
            this.Boton_Aceptar_Cambios.Size = new System.Drawing.Size(100, 23);
            this.Boton_Aceptar_Cambios.TabIndex = 18;
            this.Boton_Aceptar_Cambios.Text = "Aceptar Cambios";
            this.Boton_Aceptar_Cambios.UseVisualStyleBackColor = true;
            this.Boton_Aceptar_Cambios.Click += new System.EventHandler(this.Boton_Aceptar_Cambios_Click);
            // 
            // GroupBox_Alta_Sexo
            // 
            this.GroupBox_Alta_Sexo.Controls.Add(this.radioButton_Alta_Fem);
            this.GroupBox_Alta_Sexo.Controls.Add(this.radioButton_Alta_Masc);
            this.GroupBox_Alta_Sexo.Location = new System.Drawing.Point(550, 119);
            this.GroupBox_Alta_Sexo.Name = "GroupBox_Alta_Sexo";
            this.GroupBox_Alta_Sexo.Size = new System.Drawing.Size(133, 54);
            this.GroupBox_Alta_Sexo.TabIndex = 22;
            this.GroupBox_Alta_Sexo.TabStop = false;
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
            // Boton_Baja_Usuario
            // 
            this.Boton_Baja_Usuario.Location = new System.Drawing.Point(760, 89);
            this.Boton_Baja_Usuario.Name = "Boton_Baja_Usuario";
            this.Boton_Baja_Usuario.Size = new System.Drawing.Size(133, 31);
            this.Boton_Baja_Usuario.TabIndex = 24;
            this.Boton_Baja_Usuario.Text = "Dar de baja suscripcion";
            this.Boton_Baja_Usuario.UseVisualStyleBackColor = true;
            this.Boton_Baja_Usuario.Visible = false;
            this.Boton_Baja_Usuario.Click += new System.EventHandler(this.Boton_Baja_Usuario_Click);
            // 
            // GroupBox_Mod_Sexo
            // 
            this.GroupBox_Mod_Sexo.Location = new System.Drawing.Point(527, 326);
            this.GroupBox_Mod_Sexo.Name = "GroupBox_Mod_Sexo";
            this.GroupBox_Mod_Sexo.Size = new System.Drawing.Size(276, 38);
            this.GroupBox_Mod_Sexo.TabIndex = 21;
            this.GroupBox_Mod_Sexo.TabStop = false;
            this.GroupBox_Mod_Sexo.Visible = false;
            // 
            // radioButton_Mod_Fem
            // 
            this.radioButton_Mod_Fem.AutoSize = true;
            this.radioButton_Mod_Fem.Location = new System.Drawing.Point(550, 337);
            this.radioButton_Mod_Fem.Name = "radioButton_Mod_Fem";
            this.radioButton_Mod_Fem.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Mod_Fem.TabIndex = 19;
            this.radioButton_Mod_Fem.Text = "Femenino";
            this.radioButton_Mod_Fem.UseVisualStyleBackColor = true;
            this.radioButton_Mod_Fem.Visible = false;
            // 
            // radioButton_Mod_Masc
            // 
            this.radioButton_Mod_Masc.AutoSize = true;
            this.radioButton_Mod_Masc.Location = new System.Drawing.Point(677, 337);
            this.radioButton_Mod_Masc.Name = "radioButton_Mod_Masc";
            this.radioButton_Mod_Masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Mod_Masc.TabIndex = 20;
            this.radioButton_Mod_Masc.Text = "Masculino";
            this.radioButton_Mod_Masc.UseVisualStyleBackColor = true;
            this.radioButton_Mod_Masc.Visible = false;
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
            this.Boton_Salir.Location = new System.Drawing.Point(760, 12);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(123, 53);
            this.Boton_Salir.TabIndex = 28;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 685);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Boton_Baja_Usuario);
            this.Controls.Add(this.Eliminar_Materiales);
            this.Controls.Add(this.radioButton_Mod_Masc);
            this.Controls.Add(this.radioButton_Mod_Fem);
            this.Controls.Add(this.Boton_Aceptar_Cambios);
            this.Controls.Add(this.Boton_Modificar_Datos);
            this.Controls.Add(this.TextBox_Codigo);
            this.Controls.Add(this.TextBox_Sexo);
            this.Controls.Add(this.TextBox_Apellido);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Materiales_Seleccionados);
            this.Controls.Add(this.Grilla_Materiales_Disponibles);
            this.Controls.Add(this.Ingreso_Materiales);
            this.Controls.Add(this.Boton_Seleccionar_Usuario);
            this.Controls.Add(this.Boton_Alta_usuario);
            this.Controls.Add(this.Generar_Rutina);
            this.Controls.Add(this.Grilla_Rutina);
            this.Controls.Add(this.GroupBox_Mod_Sexo);
            this.Controls.Add(this.GroupBox_Alta_Sexo);
            this.Controls.Add(this.GroupBox_Tipo_Rutina);
            this.Name = "GUI_User";
            this.Text = "GUI_User";
            this.Load += new System.EventHandler(this.GUI_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Rutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).EndInit();
            this.GroupBox_Alta_Sexo.ResumeLayout(false);
            this.GroupBox_Alta_Sexo.PerformLayout();
            this.GroupBox_Tipo_Rutina.ResumeLayout(false);
            this.GroupBox_Tipo_Rutina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Rutina;
        private System.Windows.Forms.Button Generar_Rutina;
        private System.Windows.Forms.Button Boton_Alta_usuario;
        private System.Windows.Forms.Button Boton_Seleccionar_Usuario;
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
        private System.Windows.Forms.GroupBox GroupBox_Alta_Sexo;
        private System.Windows.Forms.Button Eliminar_Materiales;
        private System.Windows.Forms.Button Boton_Baja_Usuario;
        private System.Windows.Forms.GroupBox GroupBox_Mod_Sexo;
        private System.Windows.Forms.RadioButton radioButton_Mod_Fem;
        private System.Windows.Forms.RadioButton radioButton_Mod_Masc;
        private System.Windows.Forms.RadioButton RadioButton_Aerobico;
        private System.Windows.Forms.RadioButton RadioButton_Hipertrofia;
        private System.Windows.Forms.GroupBox GroupBox_Tipo_Rutina;
        private System.Windows.Forms.Button Boton_Salir;
    }
}