namespace ProyectoPropietaria
{
    partial class FormMenuCandidatos
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
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButtonSesion = new MetroFramework.Controls.MetroButton();
            this.experienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.experienciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.mantenimientosToolStripMenuItem.Text = "Candidatos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPropietaria.Properties.Resources._14_empleo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroButtonSesion
            // 
            this.metroButtonSesion.Location = new System.Drawing.Point(618, 99);
            this.metroButtonSesion.Name = "metroButtonSesion";
            this.metroButtonSesion.Size = new System.Drawing.Size(159, 23);
            this.metroButtonSesion.TabIndex = 2;
            this.metroButtonSesion.Text = "Cerrar Sesion";
            this.metroButtonSesion.UseSelectable = true;
            this.metroButtonSesion.Click += new System.EventHandler(this.metroButtonSesion_Click);
            // 
            // experienciaToolStripMenuItem
            // 
            this.experienciaToolStripMenuItem.Name = "experienciaToolStripMenuItem";
            this.experienciaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.experienciaToolStripMenuItem.Text = "Experiencia";
            this.experienciaToolStripMenuItem.Click += new System.EventHandler(this.experienciaToolStripMenuItem_Click_1);
            // 
            // FormMenuCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuCandidatos";
            this.Text = "Bienvenido";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormMenuCandidatos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButtonSesion;
        private System.Windows.Forms.ToolStripMenuItem experienciaToolStripMenuItem;
    }
}