
namespace GUI
{
    partial class GUI_Musculos
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
            this.Boton_Modificar_Musculo = new System.Windows.Forms.Button();
            this.Boton_Baja_Musculo = new System.Windows.Forms.Button();
            this.Boton_Alta_Musculo = new System.Windows.Forms.Button();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(481, 110);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.ReadOnly = true;
            this.TextBox_ID.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Location = new System.Drawing.Point(649, 262);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cerrar.TabIndex = 19;
            this.Boton_Cerrar.Text = "Salir";
            this.Boton_Cerrar.UseVisualStyleBackColor = true;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // Boton_Modificar_Musculo
            // 
            this.Boton_Modificar_Musculo.Location = new System.Drawing.Point(549, 262);
            this.Boton_Modificar_Musculo.Name = "Boton_Modificar_Musculo";
            this.Boton_Modificar_Musculo.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar_Musculo.TabIndex = 18;
            this.Boton_Modificar_Musculo.Text = "Modificar";
            this.Boton_Modificar_Musculo.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Musculo.Click += new System.EventHandler(this.Boton_Modificar_Musculo_Click);
            // 
            // Boton_Baja_Musculo
            // 
            this.Boton_Baja_Musculo.Location = new System.Drawing.Point(455, 262);
            this.Boton_Baja_Musculo.Name = "Boton_Baja_Musculo";
            this.Boton_Baja_Musculo.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja_Musculo.TabIndex = 17;
            this.Boton_Baja_Musculo.Text = "Baja";
            this.Boton_Baja_Musculo.UseVisualStyleBackColor = true;
            this.Boton_Baja_Musculo.Click += new System.EventHandler(this.Boton_Baja_Musculo_Click);
            // 
            // Boton_Alta_Musculo
            // 
            this.Boton_Alta_Musculo.Location = new System.Drawing.Point(374, 262);
            this.Boton_Alta_Musculo.Name = "Boton_Alta_Musculo";
            this.Boton_Alta_Musculo.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta_Musculo.TabIndex = 16;
            this.Boton_Alta_Musculo.Text = "Alta";
            this.Boton_Alta_Musculo.UseVisualStyleBackColor = true;
            this.Boton_Alta_Musculo.Click += new System.EventHandler(this.Boton_Alta_Musculo_Click);
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(481, 84);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 14;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(430, 84);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Label_Nombre.TabIndex = 12;
            this.Label_Nombre.Tag = "";
            this.Label_Nombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 282);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // GUI_Musculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Cerrar);
            this.Controls.Add(this.Boton_Modificar_Musculo);
            this.Controls.Add(this.Boton_Baja_Musculo);
            this.Controls.Add(this.Boton_Alta_Musculo);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_Musculos";
            this.Text = "GUI_Musculos";
            this.Load += new System.EventHandler(this.GUI_Musculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boton_Cerrar;
        private System.Windows.Forms.Button Boton_Modificar_Musculo;
        private System.Windows.Forms.Button Boton_Baja_Musculo;
        private System.Windows.Forms.Button Boton_Alta_Musculo;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}