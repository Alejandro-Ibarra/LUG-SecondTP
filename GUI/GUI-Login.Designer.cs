
namespace GUI
{
    partial class Login
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RadioButton_Alumno = new System.Windows.Forms.RadioButton();
            this.RadioButton_Profe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButton_Admin = new System.Windows.Forms.RadioButton();
            this.val_DNI_RGX1 = new GUI.Val_DNI_RGX();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(39, 196);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 22;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RadioButton_Alumno
            // 
            this.RadioButton_Alumno.AutoSize = true;
            this.RadioButton_Alumno.Location = new System.Drawing.Point(28, 164);
            this.RadioButton_Alumno.Name = "RadioButton_Alumno";
            this.RadioButton_Alumno.Size = new System.Drawing.Size(60, 17);
            this.RadioButton_Alumno.TabIndex = 24;
            this.RadioButton_Alumno.TabStop = true;
            this.RadioButton_Alumno.Text = "Alumno";
            this.RadioButton_Alumno.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Profe
            // 
            this.RadioButton_Profe.AutoSize = true;
            this.RadioButton_Profe.Location = new System.Drawing.Point(94, 164);
            this.RadioButton_Profe.Name = "RadioButton_Profe";
            this.RadioButton_Profe.Size = new System.Drawing.Size(64, 17);
            this.RadioButton_Profe.TabIndex = 25;
            this.RadioButton_Profe.TabStop = true;
            this.RadioButton_Profe.Text = "Profesor";
            this.RadioButton_Profe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione el tipo de cuenta que desea usar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña";
            // 
            // RadioButton_Admin
            // 
            this.RadioButton_Admin.AutoSize = true;
            this.RadioButton_Admin.Location = new System.Drawing.Point(164, 164);
            this.RadioButton_Admin.Name = "RadioButton_Admin";
            this.RadioButton_Admin.Size = new System.Drawing.Size(54, 17);
            this.RadioButton_Admin.TabIndex = 29;
            this.RadioButton_Admin.TabStop = true;
            this.RadioButton_Admin.Text = "Admin";
            this.RadioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // val_DNI_RGX1
            // 
            this.val_DNI_RGX1.Location = new System.Drawing.Point(69, 37);
            this.val_DNI_RGX1.Name = "val_DNI_RGX1";
            this.val_DNI_RGX1.Size = new System.Drawing.Size(100, 20);
            this.val_DNI_RGX1.TabIndex = 30;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 229);
            this.Controls.Add(this.val_DNI_RGX1);
            this.Controls.Add(this.RadioButton_Admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButton_Profe);
            this.Controls.Add(this.RadioButton_Alumno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.textBox2);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RadioButton_Alumno;
        private System.Windows.Forms.RadioButton RadioButton_Profe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButton_Admin;
        private Val_DNI_RGX val_DNI_RGX1;
    }
}