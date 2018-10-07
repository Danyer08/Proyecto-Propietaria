namespace ProyectoPropietaria
{
    partial class FormExperienciaLaboral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGridExperiencia = new MetroFramework.Controls.MetroGrid();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            this.metroButtonBuscar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCerrar = new MetroFramework.Controls.MetroButton();
            this.metroDateFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroDateFechaFin = new MetroFramework.Controls.MetroDateTime();
            this.metroTextEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.metroTextPuesto = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelId = new MetroFramework.Controls.MetroLabel();
            this.textBoxCandidato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Empresa";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Puesto";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Fecha de Finalizacion";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(302, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Fecha de Inicio";
            // 
            // metroGridExperiencia
            // 
            this.metroGridExperiencia.AllowUserToResizeRows = false;
            this.metroGridExperiencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridExperiencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridExperiencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridExperiencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridExperiencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridExperiencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridExperiencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridExperiencia.EnableHeadersVisualStyles = false;
            this.metroGridExperiencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridExperiencia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridExperiencia.Location = new System.Drawing.Point(24, 269);
            this.metroGridExperiencia.Name = "metroGridExperiencia";
            this.metroGridExperiencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridExperiencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridExperiencia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridExperiencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridExperiencia.Size = new System.Drawing.Size(753, 150);
            this.metroGridExperiencia.TabIndex = 4;
            this.metroGridExperiencia.SelectionChanged += new System.EventHandler(this.metroGridExperiencia_SelectionChanged);
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(702, 76);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonGuardar.TabIndex = 5;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroButtonEditar
            // 
            this.metroButtonEditar.Location = new System.Drawing.Point(702, 119);
            this.metroButtonEditar.Name = "metroButtonEditar";
            this.metroButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEditar.TabIndex = 6;
            this.metroButtonEditar.Text = "Editar";
            this.metroButtonEditar.UseSelectable = true;
            this.metroButtonEditar.Click += new System.EventHandler(this.metroButtonEditar_Click);
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.Location = new System.Drawing.Point(702, 161);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEliminar.TabIndex = 7;
            this.metroButtonEliminar.Text = "Eliminar";
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // metroButtonBuscar
            // 
            this.metroButtonBuscar.Location = new System.Drawing.Point(271, 240);
            this.metroButtonBuscar.Name = "metroButtonBuscar";
            this.metroButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonBuscar.TabIndex = 8;
            this.metroButtonBuscar.Text = "Buscar";
            this.metroButtonBuscar.UseSelectable = true;
            this.metroButtonBuscar.Click += new System.EventHandler(this.metroButtonBuscar_Click);
            // 
            // metroButtonCerrar
            // 
            this.metroButtonCerrar.Location = new System.Drawing.Point(702, 240);
            this.metroButtonCerrar.Name = "metroButtonCerrar";
            this.metroButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonCerrar.TabIndex = 9;
            this.metroButtonCerrar.Text = "Cerrar";
            this.metroButtonCerrar.UseSelectable = true;
            this.metroButtonCerrar.Click += new System.EventHandler(this.metroButtonCerrar_Click);
            // 
            // metroDateFechaInicio
            // 
            this.metroDateFechaInicio.Location = new System.Drawing.Point(429, 92);
            this.metroDateFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateFechaInicio.Name = "metroDateFechaInicio";
            this.metroDateFechaInicio.Size = new System.Drawing.Size(239, 29);
            this.metroDateFechaInicio.TabIndex = 10;
            // 
            // metroDateFechaFin
            // 
            this.metroDateFechaFin.Location = new System.Drawing.Point(429, 137);
            this.metroDateFechaFin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateFechaFin.Name = "metroDateFechaFin";
            this.metroDateFechaFin.Size = new System.Drawing.Size(239, 29);
            this.metroDateFechaFin.TabIndex = 11;
            // 
            // metroTextEmpresa
            // 
            // 
            // 
            // 
            this.metroTextEmpresa.CustomButton.Image = null;
            this.metroTextEmpresa.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.metroTextEmpresa.CustomButton.Name = "";
            this.metroTextEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextEmpresa.CustomButton.TabIndex = 1;
            this.metroTextEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextEmpresa.CustomButton.UseSelectable = true;
            this.metroTextEmpresa.CustomButton.Visible = false;
            this.metroTextEmpresa.Lines = new string[0];
            this.metroTextEmpresa.Location = new System.Drawing.Point(112, 98);
            this.metroTextEmpresa.MaxLength = 32767;
            this.metroTextEmpresa.Name = "metroTextEmpresa";
            this.metroTextEmpresa.PasswordChar = '\0';
            this.metroTextEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextEmpresa.SelectedText = "";
            this.metroTextEmpresa.SelectionLength = 0;
            this.metroTextEmpresa.SelectionStart = 0;
            this.metroTextEmpresa.ShortcutsEnabled = true;
            this.metroTextEmpresa.Size = new System.Drawing.Size(172, 23);
            this.metroTextEmpresa.TabIndex = 12;
            this.metroTextEmpresa.UseSelectable = true;
            this.metroTextEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextPuesto
            // 
            // 
            // 
            // 
            this.metroTextPuesto.CustomButton.Image = null;
            this.metroTextPuesto.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.metroTextPuesto.CustomButton.Name = "";
            this.metroTextPuesto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextPuesto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextPuesto.CustomButton.TabIndex = 1;
            this.metroTextPuesto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextPuesto.CustomButton.UseSelectable = true;
            this.metroTextPuesto.CustomButton.Visible = false;
            this.metroTextPuesto.Lines = new string[0];
            this.metroTextPuesto.Location = new System.Drawing.Point(112, 137);
            this.metroTextPuesto.MaxLength = 32767;
            this.metroTextPuesto.Name = "metroTextPuesto";
            this.metroTextPuesto.PasswordChar = '\0';
            this.metroTextPuesto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextPuesto.SelectedText = "";
            this.metroTextPuesto.SelectionLength = 0;
            this.metroTextPuesto.SelectionStart = 0;
            this.metroTextPuesto.ShortcutsEnabled = true;
            this.metroTextPuesto.Size = new System.Drawing.Size(170, 23);
            this.metroTextPuesto.TabIndex = 13;
            this.metroTextPuesto.UseSelectable = true;
            this.metroTextPuesto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextPuesto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBuscar
            // 
            // 
            // 
            // 
            this.metroTextBuscar.CustomButton.Image = null;
            this.metroTextBuscar.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.metroTextBuscar.CustomButton.Name = "";
            this.metroTextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBuscar.CustomButton.TabIndex = 1;
            this.metroTextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBuscar.CustomButton.UseSelectable = true;
            this.metroTextBuscar.CustomButton.Visible = false;
            this.metroTextBuscar.Lines = new string[0];
            this.metroTextBuscar.Location = new System.Drawing.Point(24, 240);
            this.metroTextBuscar.MaxLength = 32767;
            this.metroTextBuscar.Name = "metroTextBuscar";
            this.metroTextBuscar.PasswordChar = '\0';
            this.metroTextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBuscar.SelectedText = "";
            this.metroTextBuscar.SelectionLength = 0;
            this.metroTextBuscar.SelectionStart = 0;
            this.metroTextBuscar.ShortcutsEnabled = true;
            this.metroTextBuscar.Size = new System.Drawing.Size(241, 23);
            this.metroTextBuscar.TabIndex = 14;
            this.metroTextBuscar.UseSelectable = true;
            this.metroTextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(64, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(20, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Id";
            // 
            // metroLabelId
            // 
            this.metroLabelId.AutoSize = true;
            this.metroLabelId.Location = new System.Drawing.Point(114, 63);
            this.metroLabelId.Name = "metroLabelId";
            this.metroLabelId.Size = new System.Drawing.Size(12, 19);
            this.metroLabelId.TabIndex = 16;
            this.metroLabelId.Text = ".";
            // 
            // textBoxCandidato
            // 
            this.textBoxCandidato.Location = new System.Drawing.Point(366, 60);
            this.textBoxCandidato.Name = "textBoxCandidato";
            this.textBoxCandidato.Size = new System.Drawing.Size(173, 20);
            this.textBoxCandidato.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre de Candidato";
            // 
            // FormExperienciaLaboral
            // 
            this.AcceptButton = this.metroButtonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCandidato);
            this.Controls.Add(this.metroLabelId);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBuscar);
            this.Controls.Add(this.metroTextPuesto);
            this.Controls.Add(this.metroTextEmpresa);
            this.Controls.Add(this.metroDateFechaFin);
            this.Controls.Add(this.metroDateFechaInicio);
            this.Controls.Add(this.metroButtonCerrar);
            this.Controls.Add(this.metroButtonBuscar);
            this.Controls.Add(this.metroButtonEliminar);
            this.Controls.Add(this.metroButtonEditar);
            this.Controls.Add(this.metroButtonGuardar);
            this.Controls.Add(this.metroGridExperiencia);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormExperienciaLaboral";
            this.Text = "Experiencia Laboral";
            this.Load += new System.EventHandler(this.FormExperienciaLaboral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid metroGridExperiencia;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonEditar;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
        private MetroFramework.Controls.MetroButton metroButtonBuscar;
        private MetroFramework.Controls.MetroButton metroButtonCerrar;
        private MetroFramework.Controls.MetroDateTime metroDateFechaInicio;
        private MetroFramework.Controls.MetroDateTime metroDateFechaFin;
        private MetroFramework.Controls.MetroTextBox metroTextEmpresa;
        private MetroFramework.Controls.MetroTextBox metroTextPuesto;
        private MetroFramework.Controls.MetroTextBox metroTextBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabelId;
        private System.Windows.Forms.TextBox textBoxCandidato;
        private System.Windows.Forms.Label label1;
    }
}