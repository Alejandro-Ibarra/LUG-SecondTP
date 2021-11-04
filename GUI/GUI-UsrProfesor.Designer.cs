
namespace GUI
{
    partial class GUI_UsrProfesor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialesToolStripMenuItem,
            this.MusculosToolStripMenuItem,
            this.EjerciciosToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MaterialesToolStripMenuItem
            // 
            this.MaterialesToolStripMenuItem.Name = "MaterialesToolStripMenuItem";
            this.MaterialesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.MaterialesToolStripMenuItem.Text = "MATERIALES";
            this.MaterialesToolStripMenuItem.Click += new System.EventHandler(this.MaterialesToolStripMenuItem_Click);
            // 
            // MusculosToolStripMenuItem
            // 
            this.MusculosToolStripMenuItem.Name = "MusculosToolStripMenuItem";
            this.MusculosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.MusculosToolStripMenuItem.Text = "MUSCULOS";
            this.MusculosToolStripMenuItem.Click += new System.EventHandler(this.MusculosToolStripMenuItem_Click);
            // 
            // EjerciciosToolStripMenuItem
            // 
            this.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem";
            this.EjerciciosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.EjerciciosToolStripMenuItem.Text = "EJERCICIOS";
            this.EjerciciosToolStripMenuItem.Click += new System.EventHandler(this.EjerciciosToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // GUI_UsrProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_UsrProfesor";
            this.Text = "GUI_UsrProfesor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}