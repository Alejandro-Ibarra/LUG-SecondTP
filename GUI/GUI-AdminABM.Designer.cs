
namespace GUI
{
    partial class GUI_AdminABM
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
            this.Grilla_Alumnos = new System.Windows.Forms.DataGridView();
            this.Grilla_Profesores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Boton_Alta_usuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Codigo = new System.Windows.Forms.TextBox();
            this.Boton_Baja_Usuario = new System.Windows.Forms.Button();
            this.Boton_Modificar_Usuario = new System.Windows.Forms.Button();
            this.ComboBox_Sexo = new System.Windows.Forms.ComboBox();
            this.RadioButton_Alumno = new System.Windows.Forms.RadioButton();
            this.RadioButton_Profesor = new System.Windows.Forms.RadioButton();
            this.TextBox_Contraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.val_Ape_RGX1 = new GUI.Val_Ape_RGX();
            this.val_Nro_Cont1 = new GUI.Val_Nro_Cont();
            this.val_Nom_RGX1 = new GUI.Val_Nom_RGX();
            this.val_DNI_RGX1 = new GUI.Val_DNI_RGX();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Profesores)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Alumnos
            // 
            this.Grilla_Alumnos.AllowUserToAddRows = false;
            this.Grilla_Alumnos.AllowUserToDeleteRows = false;
            this.Grilla_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Alumnos.Location = new System.Drawing.Point(12, 194);
            this.Grilla_Alumnos.Name = "Grilla_Alumnos";
            this.Grilla_Alumnos.ReadOnly = true;
            this.Grilla_Alumnos.Size = new System.Drawing.Size(469, 377);
            this.Grilla_Alumnos.TabIndex = 1;
            this.Grilla_Alumnos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Alumnos_MouseClick);
            // 
            // Grilla_Profesores
            // 
            this.Grilla_Profesores.AllowUserToAddRows = false;
            this.Grilla_Profesores.AllowUserToDeleteRows = false;
            this.Grilla_Profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Profesores.Location = new System.Drawing.Point(581, 194);
            this.Grilla_Profesores.Name = "Grilla_Profesores";
            this.Grilla_Profesores.ReadOnly = true;
            this.Grilla_Profesores.Size = new System.Drawing.Size(469, 377);
            this.Grilla_Profesores.TabIndex = 2;
            this.Grilla_Profesores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grilla_Profesores_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sexo";
            // 
            // Boton_Alta_usuario
            // 
            this.Boton_Alta_usuario.Location = new System.Drawing.Point(581, 44);
            this.Boton_Alta_usuario.Name = "Boton_Alta_usuario";
            this.Boton_Alta_usuario.Size = new System.Drawing.Size(133, 26);
            this.Boton_Alta_usuario.TabIndex = 108;
            this.Boton_Alta_usuario.Text = "Alta Usuario";
            this.Boton_Alta_usuario.UseVisualStyleBackColor = true;
            this.Boton_Alta_usuario.Click += new System.EventHandler(this.Boton_Alta_usuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Numero de contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Codigo";
            // 
            // TextBox_Codigo
            // 
            this.TextBox_Codigo.Enabled = false;
            this.TextBox_Codigo.Location = new System.Drawing.Point(292, 137);
            this.TextBox_Codigo.Name = "TextBox_Codigo";
            this.TextBox_Codigo.ReadOnly = true;
            this.TextBox_Codigo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Codigo.TabIndex = 40;
            // 
            // Boton_Baja_Usuario
            // 
            this.Boton_Baja_Usuario.Location = new System.Drawing.Point(581, 90);
            this.Boton_Baja_Usuario.Name = "Boton_Baja_Usuario";
            this.Boton_Baja_Usuario.Size = new System.Drawing.Size(133, 26);
            this.Boton_Baja_Usuario.TabIndex = 109;
            this.Boton_Baja_Usuario.Text = "Baja Usuario";
            this.Boton_Baja_Usuario.UseVisualStyleBackColor = true;
            this.Boton_Baja_Usuario.Click += new System.EventHandler(this.Boton_Baja_usuario_Click);
            // 
            // Boton_Modificar_Usuario
            // 
            this.Boton_Modificar_Usuario.Location = new System.Drawing.Point(581, 137);
            this.Boton_Modificar_Usuario.Name = "Boton_Modificar_Usuario";
            this.Boton_Modificar_Usuario.Size = new System.Drawing.Size(133, 26);
            this.Boton_Modificar_Usuario.TabIndex = 110;
            this.Boton_Modificar_Usuario.Text = "Modificar Usuario";
            this.Boton_Modificar_Usuario.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Usuario.Click += new System.EventHandler(this.Boton_Modificar_Usuario_Click);
            // 
            // ComboBox_Sexo
            // 
            this.ComboBox_Sexo.FormattingEnabled = true;
            this.ComboBox_Sexo.Location = new System.Drawing.Point(147, 137);
            this.ComboBox_Sexo.Name = "ComboBox_Sexo";
            this.ComboBox_Sexo.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Sexo.TabIndex = 103;
            // 
            // RadioButton_Alumno
            // 
            this.RadioButton_Alumno.AutoSize = true;
            this.RadioButton_Alumno.Checked = true;
            this.RadioButton_Alumno.Location = new System.Drawing.Point(421, 44);
            this.RadioButton_Alumno.Name = "RadioButton_Alumno";
            this.RadioButton_Alumno.Size = new System.Drawing.Size(60, 17);
            this.RadioButton_Alumno.TabIndex = 104;
            this.RadioButton_Alumno.TabStop = true;
            this.RadioButton_Alumno.Text = "Alumno";
            this.RadioButton_Alumno.UseVisualStyleBackColor = true;
            this.RadioButton_Alumno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButton_Alumno_MouseClick);
            // 
            // RadioButton_Profesor
            // 
            this.RadioButton_Profesor.AutoSize = true;
            this.RadioButton_Profesor.Location = new System.Drawing.Point(487, 44);
            this.RadioButton_Profesor.Name = "RadioButton_Profesor";
            this.RadioButton_Profesor.Size = new System.Drawing.Size(64, 17);
            this.RadioButton_Profesor.TabIndex = 105;
            this.RadioButton_Profesor.Text = "Profesor";
            this.RadioButton_Profesor.UseVisualStyleBackColor = true;
            this.RadioButton_Profesor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RadioButton_Profesor_MouseClick);
            // 
            // TextBox_Contraseña
            // 
            this.TextBox_Contraseña.Location = new System.Drawing.Point(435, 137);
            this.TextBox_Contraseña.Name = "TextBox_Contraseña";
            this.TextBox_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Contraseña.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Asignar contraseña inicial";
            // 
            // val_Ape_RGX1
            // 
            this.val_Ape_RGX1.Location = new System.Drawing.Point(150, 44);
            this.val_Ape_RGX1.Name = "val_Ape_RGX1";
            this.val_Ape_RGX1.Size = new System.Drawing.Size(100, 20);
            this.val_Ape_RGX1.TabIndex = 114;
            // 
            // val_Nro_Cont1
            // 
            this.val_Nro_Cont1.Location = new System.Drawing.Point(292, 44);
            this.val_Nro_Cont1.Name = "val_Nro_Cont1";
            this.val_Nro_Cont1.Size = new System.Drawing.Size(100, 20);
            this.val_Nro_Cont1.TabIndex = 113;
            // 
            // val_Nom_RGX1
            // 
            this.val_Nom_RGX1.Location = new System.Drawing.Point(15, 44);
            this.val_Nom_RGX1.Name = "val_Nom_RGX1";
            this.val_Nom_RGX1.Size = new System.Drawing.Size(100, 20);
            this.val_Nom_RGX1.TabIndex = 112;
            // 
            // val_DNI_RGX1
            // 
            this.val_DNI_RGX1.Location = new System.Drawing.Point(15, 137);
            this.val_DNI_RGX1.Name = "val_DNI_RGX1";
            this.val_DNI_RGX1.Size = new System.Drawing.Size(100, 20);
            this.val_DNI_RGX1.TabIndex = 111;
            // 
            // GUI_AdminABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 633);
            this.Controls.Add(this.val_Ape_RGX1);
            this.Controls.Add(this.val_Nro_Cont1);
            this.Controls.Add(this.val_Nom_RGX1);
            this.Controls.Add(this.val_DNI_RGX1);
            this.Controls.Add(this.TextBox_Contraseña);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RadioButton_Profesor);
            this.Controls.Add(this.RadioButton_Alumno);
            this.Controls.Add(this.ComboBox_Sexo);
            this.Controls.Add(this.Boton_Modificar_Usuario);
            this.Controls.Add(this.Boton_Baja_Usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Boton_Alta_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Profesores);
            this.Controls.Add(this.Grilla_Alumnos);
            this.Name = "GUI_AdminABM";
            this.Text = "GUI_AdminABM";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Profesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Alumnos;
        private System.Windows.Forms.DataGridView Grilla_Profesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Boton_Alta_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Codigo;
        private System.Windows.Forms.Button Boton_Baja_Usuario;
        private System.Windows.Forms.Button Boton_Modificar_Usuario;
        private System.Windows.Forms.ComboBox ComboBox_Sexo;
        private System.Windows.Forms.RadioButton RadioButton_Alumno;
        private System.Windows.Forms.RadioButton RadioButton_Profesor;
        private System.Windows.Forms.TextBox TextBox_Contraseña;
        private System.Windows.Forms.Label label7;
        private Val_DNI_RGX val_DNI_RGX1;
        private Val_Nom_RGX val_Nom_RGX1;
        private Val_Nro_Cont val_Nro_Cont1;
        private Val_Ape_RGX val_Ape_RGX1;
    }
}