
namespace GUI
{
    partial class GUI_Materiales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Peso = new System.Windows.Forms.Label();
            this.TextBox_nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Peso = new System.Windows.Forms.TextBox();
            this.Boton_Alta_Materiales = new System.Windows.Forms.Button();
            this.Boton_Baja_Materiales = new System.Windows.Forms.Button();
            this.Boton_Modificar_Materiales = new System.Windows.Forms.Button();
            this.Boton_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(384, 122);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Label_Nombre.TabIndex = 1;
            this.Label_Nombre.Tag = "";
            this.Label_Nombre.Text = "Nombre";
            // 
            // Label_Peso
            // 
            this.Label_Peso.AutoSize = true;
            this.Label_Peso.Location = new System.Drawing.Point(384, 157);
            this.Label_Peso.Name = "Label_Peso";
            this.Label_Peso.Size = new System.Drawing.Size(31, 13);
            this.Label_Peso.TabIndex = 2;
            this.Label_Peso.Text = "Peso";
            // 
            // TextBox_nombre
            // 
            this.TextBox_nombre.Location = new System.Drawing.Point(435, 122);
            this.TextBox_nombre.Name = "TextBox_nombre";
            this.TextBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_nombre.TabIndex = 3;
            // 
            // TextBox_Peso
            // 
            this.TextBox_Peso.Location = new System.Drawing.Point(435, 154);
            this.TextBox_Peso.Name = "TextBox_Peso";
            this.TextBox_Peso.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Peso.TabIndex = 4;
            // 
            // Boton_Alta_Materiales
            // 
            this.Boton_Alta_Materiales.Location = new System.Drawing.Point(328, 300);
            this.Boton_Alta_Materiales.Name = "Boton_Alta_Materiales";
            this.Boton_Alta_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta_Materiales.TabIndex = 5;
            this.Boton_Alta_Materiales.Text = "Alta";
            this.Boton_Alta_Materiales.UseVisualStyleBackColor = true;
            // 
            // Boton_Baja_Materiales
            // 
            this.Boton_Baja_Materiales.Location = new System.Drawing.Point(409, 300);
            this.Boton_Baja_Materiales.Name = "Boton_Baja_Materiales";
            this.Boton_Baja_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja_Materiales.TabIndex = 6;
            this.Boton_Baja_Materiales.Text = "Baja";
            this.Boton_Baja_Materiales.UseVisualStyleBackColor = true;
            // 
            // Boton_Modificar_Materiales
            // 
            this.Boton_Modificar_Materiales.Location = new System.Drawing.Point(503, 300);
            this.Boton_Modificar_Materiales.Name = "Boton_Modificar_Materiales";
            this.Boton_Modificar_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar_Materiales.TabIndex = 7;
            this.Boton_Modificar_Materiales.Text = "Modificar";
            this.Boton_Modificar_Materiales.UseVisualStyleBackColor = true;
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Location = new System.Drawing.Point(603, 300);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cerrar.TabIndex = 8;
            this.Boton_Cerrar.Text = "Salir";
            this.Boton_Cerrar.UseVisualStyleBackColor = true;
            // 
            // GUI_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Cerrar);
            this.Controls.Add(this.Boton_Modificar_Materiales);
            this.Controls.Add(this.Boton_Baja_Materiales);
            this.Controls.Add(this.Boton_Alta_Materiales);
            this.Controls.Add(this.TextBox_Peso);
            this.Controls.Add(this.TextBox_nombre);
            this.Controls.Add(this.Label_Peso);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_Materiales";
            this.Text = "GUI_Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Peso;
        private System.Windows.Forms.TextBox TextBox_nombre;
        private System.Windows.Forms.TextBox TextBox_Peso;
        private System.Windows.Forms.Button Boton_Alta_Materiales;
        private System.Windows.Forms.Button Boton_Baja_Materiales;
        private System.Windows.Forms.Button Boton_Modificar_Materiales;
        private System.Windows.Forms.Button Boton_Cerrar;
    }
}