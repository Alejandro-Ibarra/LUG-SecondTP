
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
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Peso = new System.Windows.Forms.TextBox();
            this.Boton_Alta_Materiales = new System.Windows.Forms.Button();
            this.Boton_Baja_Materiales = new System.Windows.Forms.Button();
            this.Boton_Modificar_Materiales = new System.Windows.Forms.Button();
            this.Boton_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(277, 12);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Label_Nombre.TabIndex = 1;
            this.Label_Nombre.Tag = "";
            this.Label_Nombre.Text = "Nombre";
            // 
            // Label_Peso
            // 
            this.Label_Peso.AutoSize = true;
            this.Label_Peso.Location = new System.Drawing.Point(277, 47);
            this.Label_Peso.Name = "Label_Peso";
            this.Label_Peso.Size = new System.Drawing.Size(31, 13);
            this.Label_Peso.TabIndex = 2;
            this.Label_Peso.Text = "Peso";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(328, 12);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 3;
            // 
            // TextBox_Peso
            // 
            this.TextBox_Peso.Location = new System.Drawing.Point(328, 44);
            this.TextBox_Peso.Name = "TextBox_Peso";
            this.TextBox_Peso.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Peso.TabIndex = 4;
            // 
            // Boton_Alta_Materiales
            // 
            this.Boton_Alta_Materiales.Location = new System.Drawing.Point(280, 131);
            this.Boton_Alta_Materiales.Name = "Boton_Alta_Materiales";
            this.Boton_Alta_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Alta_Materiales.TabIndex = 5;
            this.Boton_Alta_Materiales.Text = "Alta";
            this.Boton_Alta_Materiales.UseVisualStyleBackColor = true;
            this.Boton_Alta_Materiales.Click += new System.EventHandler(this.Boton_Alta_Materiales_Click);
            // 
            // Boton_Baja_Materiales
            // 
            this.Boton_Baja_Materiales.Location = new System.Drawing.Point(361, 131);
            this.Boton_Baja_Materiales.Name = "Boton_Baja_Materiales";
            this.Boton_Baja_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Baja_Materiales.TabIndex = 6;
            this.Boton_Baja_Materiales.Text = "Baja";
            this.Boton_Baja_Materiales.UseVisualStyleBackColor = true;
            this.Boton_Baja_Materiales.Click += new System.EventHandler(this.Boton_Baja_Materiales_Click);
            // 
            // Boton_Modificar_Materiales
            // 
            this.Boton_Modificar_Materiales.Location = new System.Drawing.Point(280, 177);
            this.Boton_Modificar_Materiales.Name = "Boton_Modificar_Materiales";
            this.Boton_Modificar_Materiales.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar_Materiales.TabIndex = 7;
            this.Boton_Modificar_Materiales.Text = "Modificar";
            this.Boton_Modificar_Materiales.UseVisualStyleBackColor = true;
            this.Boton_Modificar_Materiales.Click += new System.EventHandler(this.Boton_Modificar_Materiales_Click);
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Location = new System.Drawing.Point(361, 177);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cerrar.TabIndex = 8;
            this.Boton_Cerrar.Text = "Salir";
            this.Boton_Cerrar.UseVisualStyleBackColor = true;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(328, 76);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ID.TabIndex = 10;
            // 
            // GUI_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 374);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Cerrar);
            this.Controls.Add(this.Boton_Modificar_Materiales);
            this.Controls.Add(this.Boton_Baja_Materiales);
            this.Controls.Add(this.Boton_Alta_Materiales);
            this.Controls.Add(this.TextBox_Peso);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.Label_Peso);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_Materiales";
            this.Text = "GUI_Materiales";
            this.Load += new System.EventHandler(this.GUI_Materiales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Peso;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Peso;
        private System.Windows.Forms.Button Boton_Alta_Materiales;
        private System.Windows.Forms.Button Boton_Baja_Materiales;
        private System.Windows.Forms.Button Boton_Modificar_Materiales;
        private System.Windows.Forms.Button Boton_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_ID;
    }
}