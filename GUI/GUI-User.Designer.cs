
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
            this.Alta_usuario = new System.Windows.Forms.Button();
            this.Seleccionar_Usuario = new System.Windows.Forms.Button();
            this.Ingreso_Materiales = new System.Windows.Forms.Button();
            this.Grilla_Materiales_Disponibles = new System.Windows.Forms.DataGridView();
            this.Grilla_Materiales_Seleccionados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Grilla_rutina.Location = new System.Drawing.Point(36, 86);
            this.Grilla_rutina.Name = "Grilla_rutina";
            this.Grilla_rutina.ReadOnly = true;
            this.Grilla_rutina.Size = new System.Drawing.Size(351, 305);
            this.Grilla_rutina.TabIndex = 0;
            // 
            // Generar_Rutina
            // 
            this.Generar_Rutina.Location = new System.Drawing.Point(36, 27);
            this.Generar_Rutina.Name = "Generar_Rutina";
            this.Generar_Rutina.Size = new System.Drawing.Size(289, 35);
            this.Generar_Rutina.TabIndex = 2;
            this.Generar_Rutina.Text = "Genere su rutina";
            this.Generar_Rutina.UseVisualStyleBackColor = true;
            // 
            // Alta_usuario
            // 
            this.Alta_usuario.Location = new System.Drawing.Point(631, 27);
            this.Alta_usuario.Name = "Alta_usuario";
            this.Alta_usuario.Size = new System.Drawing.Size(166, 26);
            this.Alta_usuario.TabIndex = 3;
            this.Alta_usuario.Text = "Alta Usuario";
            this.Alta_usuario.UseVisualStyleBackColor = true;
            this.Alta_usuario.Click += new System.EventHandler(this.Alta_usuario_Click);
            // 
            // Seleccionar_Usuario
            // 
            this.Seleccionar_Usuario.Location = new System.Drawing.Point(422, 27);
            this.Seleccionar_Usuario.Name = "Seleccionar_Usuario";
            this.Seleccionar_Usuario.Size = new System.Drawing.Size(166, 26);
            this.Seleccionar_Usuario.TabIndex = 4;
            this.Seleccionar_Usuario.Text = "Ingrese su nombre de usuario";
            this.Seleccionar_Usuario.UseVisualStyleBackColor = true;
            // 
            // Ingreso_Materiales
            // 
            this.Ingreso_Materiales.Location = new System.Drawing.Point(422, 151);
            this.Ingreso_Materiales.Name = "Ingreso_Materiales";
            this.Ingreso_Materiales.Size = new System.Drawing.Size(375, 31);
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
            this.Grilla_Materiales_Disponibles.Location = new System.Drawing.Point(422, 220);
            this.Grilla_Materiales_Disponibles.Name = "Grilla_Materiales_Disponibles";
            this.Grilla_Materiales_Disponibles.ReadOnly = true;
            this.Grilla_Materiales_Disponibles.Size = new System.Drawing.Size(166, 228);
            this.Grilla_Materiales_Disponibles.TabIndex = 6;
            // 
            // Grilla_Materiales_Seleccionados
            // 
            this.Grilla_Materiales_Seleccionados.AllowUserToAddRows = false;
            this.Grilla_Materiales_Seleccionados.AllowUserToDeleteRows = false;
            this.Grilla_Materiales_Seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Materiales_Seleccionados.Location = new System.Drawing.Point(631, 220);
            this.Grilla_Materiales_Seleccionados.Name = "Grilla_Materiales_Seleccionados";
            this.Grilla_Materiales_Seleccionados.ReadOnly = true;
            this.Grilla_Materiales_Seleccionados.Size = new System.Drawing.Size(166, 228);
            this.Grilla_Materiales_Seleccionados.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(422, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Herramientas disponibles";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(631, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Herramientas del usuario";
            // 
            // GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Materiales_Seleccionados);
            this.Controls.Add(this.Grilla_Materiales_Disponibles);
            this.Controls.Add(this.Ingreso_Materiales);
            this.Controls.Add(this.Seleccionar_Usuario);
            this.Controls.Add(this.Alta_usuario);
            this.Controls.Add(this.Generar_Rutina);
            this.Controls.Add(this.Grilla_rutina);
            this.Name = "GUI_User";
            this.Text = "GUI_User";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_rutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Materiales_Seleccionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_rutina;
        private System.Windows.Forms.Button Generar_Rutina;
        private System.Windows.Forms.Button Alta_usuario;
        private System.Windows.Forms.Button Seleccionar_Usuario;
        private System.Windows.Forms.Button Ingreso_Materiales;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Disponibles;
        private System.Windows.Forms.DataGridView Grilla_Materiales_Seleccionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}