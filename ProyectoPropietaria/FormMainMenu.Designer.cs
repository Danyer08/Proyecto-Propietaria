namespace ProyectoPropietaria
{
    partial class FormMainMenu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienciaLaborlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.idiomasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(20, 84);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.candidatosToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(20, 60);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(760, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatosToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.idiomasToolStripMenuItem1});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.mantenimientosToolStripMenuItem.Text = "Administracion";
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.candidatosToolStripMenuItem.Text = "Empleados";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // candidatosToolStripMenuItem1
            // 
            this.candidatosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capacitacionesToolStripMenuItem,
            this.experienciaLaborlaToolStripMenuItem,
            this.idiomasToolStripMenuItem,
            this.candidatosToolStripMenuItem2});
            this.candidatosToolStripMenuItem1.Name = "candidatosToolStripMenuItem1";
            this.candidatosToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.candidatosToolStripMenuItem1.Text = "Mantenimientos";
            this.candidatosToolStripMenuItem1.Click += new System.EventHandler(this.candidatosToolStripMenuItem1_Click);
            // 
            // capacitacionesToolStripMenuItem
            // 
            this.capacitacionesToolStripMenuItem.Name = "capacitacionesToolStripMenuItem";
            this.capacitacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capacitacionesToolStripMenuItem.Text = "Capacitaciones";
            this.capacitacionesToolStripMenuItem.Click += new System.EventHandler(this.capacitacionesToolStripMenuItem_Click);
            // 
            // experienciaLaborlaToolStripMenuItem
            // 
            this.experienciaLaborlaToolStripMenuItem.Name = "experienciaLaborlaToolStripMenuItem";
            this.experienciaLaborlaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.experienciaLaborlaToolStripMenuItem.Text = "Experiencia Laboral";
            this.experienciaLaborlaToolStripMenuItem.Click += new System.EventHandler(this.experienciaLaborlaToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.Image = global::ProyectoPropietaria.Properties.Resources.planificación_de_los_recursos_humanos;
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(20, 87);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(738, 325);
            this.pictureBoxMainMenu.TabIndex = 9;
            this.pictureBoxMainMenu.TabStop = false;
            // 
            // idiomasToolStripMenuItem1
            // 
            this.idiomasToolStripMenuItem1.Name = "idiomasToolStripMenuItem1";
            this.idiomasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.idiomasToolStripMenuItem1.Text = "Idiomas";
            this.idiomasToolStripMenuItem1.Click += new System.EventHandler(this.idiomasToolStripMenuItem1_Click);
            // 
            // candidatosToolStripMenuItem2
            // 
            this.candidatosToolStripMenuItem2.Name = "candidatosToolStripMenuItem2";
            this.candidatosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.candidatosToolStripMenuItem2.Text = "Candidatos";
            this.candidatosToolStripMenuItem2.Click += new System.EventHandler(this.candidatosToolStripMenuItem2_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainMenu";
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capacitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienciaLaborlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxMainMenu;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem2;
    }
}