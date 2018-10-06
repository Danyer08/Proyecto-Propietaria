namespace ProyectoPropietaria
{
    partial class FormCompetencias
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
            this.metroLabelId = new MetroFramework.Controls.MetroLabel();
            this.metroCheckEstado = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroGridCompetencias = new MetroFramework.Controls.MetroGrid();
            this.metroTextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonBuscar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCerrar = new MetroFramework.Controls.MetroButton();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Descripcion";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Estado";
            // 
            // metroLabelId
            // 
            this.metroLabelId.AutoSize = true;
            this.metroLabelId.Location = new System.Drawing.Point(129, 78);
            this.metroLabelId.Name = "metroLabelId";
            this.metroLabelId.Size = new System.Drawing.Size(12, 19);
            this.metroLabelId.TabIndex = 3;
            this.metroLabelId.Text = ".";
            // 
            // metroCheckEstado
            // 
            this.metroCheckEstado.AutoSize = true;
            this.metroCheckEstado.Location = new System.Drawing.Point(140, 192);
            this.metroCheckEstado.Name = "metroCheckEstado";
            this.metroCheckEstado.Size = new System.Drawing.Size(104, 15);
            this.metroCheckEstado.TabIndex = 4;
            this.metroCheckEstado.Text = "Activo/Inactivo";
            this.metroCheckEstado.UseSelectable = true;
            // 
            // metroTextDescripcion
            // 
            // 
            // 
            // 
            this.metroTextDescripcion.CustomButton.Image = null;
            this.metroTextDescripcion.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.metroTextDescripcion.CustomButton.Name = "";
            this.metroTextDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextDescripcion.CustomButton.TabIndex = 1;
            this.metroTextDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextDescripcion.CustomButton.UseSelectable = true;
            this.metroTextDescripcion.CustomButton.Visible = false;
            this.metroTextDescripcion.Lines = new string[0];
            this.metroTextDescripcion.Location = new System.Drawing.Point(140, 127);
            this.metroTextDescripcion.MaxLength = 32767;
            this.metroTextDescripcion.Name = "metroTextDescripcion";
            this.metroTextDescripcion.PasswordChar = '\0';
            this.metroTextDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextDescripcion.SelectedText = "";
            this.metroTextDescripcion.SelectionLength = 0;
            this.metroTextDescripcion.SelectionStart = 0;
            this.metroTextDescripcion.ShortcutsEnabled = true;
            this.metroTextDescripcion.Size = new System.Drawing.Size(198, 23);
            this.metroTextDescripcion.TabIndex = 5;
            this.metroTextDescripcion.UseSelectable = true;
            this.metroTextDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridCompetencias
            // 
            this.metroGridCompetencias.AllowUserToResizeRows = false;
            this.metroGridCompetencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCompetencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCompetencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCompetencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompetencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCompetencias.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridCompetencias.EnableHeadersVisualStyles = false;
            this.metroGridCompetencias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCompetencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCompetencias.Location = new System.Drawing.Point(26, 277);
            this.metroGridCompetencias.Name = "metroGridCompetencias";
            this.metroGridCompetencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompetencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridCompetencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCompetencias.Size = new System.Drawing.Size(564, 150);
            this.metroGridCompetencias.TabIndex = 6;
            this.metroGridCompetencias.SelectionChanged += new System.EventHandler(this.metroGridCompetencias_SelectionChanged);
            // 
            // metroTextBuscar
            // 
            // 
            // 
            // 
            this.metroTextBuscar.CustomButton.Image = null;
            this.metroTextBuscar.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.metroTextBuscar.CustomButton.Name = "";
            this.metroTextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBuscar.CustomButton.TabIndex = 1;
            this.metroTextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBuscar.CustomButton.UseSelectable = true;
            this.metroTextBuscar.CustomButton.Visible = false;
            this.metroTextBuscar.Lines = new string[0];
            this.metroTextBuscar.Location = new System.Drawing.Point(29, 247);
            this.metroTextBuscar.MaxLength = 32767;
            this.metroTextBuscar.Name = "metroTextBuscar";
            this.metroTextBuscar.PasswordChar = '\0';
            this.metroTextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBuscar.SelectedText = "";
            this.metroTextBuscar.SelectionLength = 0;
            this.metroTextBuscar.SelectionStart = 0;
            this.metroTextBuscar.ShortcutsEnabled = true;
            this.metroTextBuscar.Size = new System.Drawing.Size(234, 23);
            this.metroTextBuscar.TabIndex = 7;
            this.metroTextBuscar.UseSelectable = true;
            this.metroTextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonBuscar
            // 
            this.metroButtonBuscar.Location = new System.Drawing.Point(269, 247);
            this.metroButtonBuscar.Name = "metroButtonBuscar";
            this.metroButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonBuscar.TabIndex = 8;
            this.metroButtonBuscar.Text = "Buscar";
            this.metroButtonBuscar.UseSelectable = true;
            this.metroButtonBuscar.Click += new System.EventHandler(this.metroButtonBuscar_Click);
            // 
            // metroButtonCerrar
            // 
            this.metroButtonCerrar.Location = new System.Drawing.Point(482, 247);
            this.metroButtonCerrar.Name = "metroButtonCerrar";
            this.metroButtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonCerrar.TabIndex = 9;
            this.metroButtonCerrar.Text = "Cerrar";
            this.metroButtonCerrar.UseSelectable = true;
            this.metroButtonCerrar.Click += new System.EventHandler(this.metroButtonCerrar_Click);
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(482, 78);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonGuardar.TabIndex = 10;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroButtonEditar
            // 
            this.metroButtonEditar.Location = new System.Drawing.Point(482, 127);
            this.metroButtonEditar.Name = "metroButtonEditar";
            this.metroButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEditar.TabIndex = 11;
            this.metroButtonEditar.Text = "Editar";
            this.metroButtonEditar.UseSelectable = true;
            this.metroButtonEditar.Click += new System.EventHandler(this.metroButtonEditar_Click);
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.Location = new System.Drawing.Point(482, 178);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEliminar.TabIndex = 12;
            this.metroButtonEliminar.Text = "Eliminar";
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // FormCompetencias
            // 
            this.AcceptButton = this.metroButtonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.metroButtonEliminar);
            this.Controls.Add(this.metroButtonEditar);
            this.Controls.Add(this.metroButtonGuardar);
            this.Controls.Add(this.metroButtonCerrar);
            this.Controls.Add(this.metroButtonBuscar);
            this.Controls.Add(this.metroTextBuscar);
            this.Controls.Add(this.metroGridCompetencias);
            this.Controls.Add(this.metroTextDescripcion);
            this.Controls.Add(this.metroCheckEstado);
            this.Controls.Add(this.metroLabelId);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormCompetencias";
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.FormCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabelId;
        private MetroFramework.Controls.MetroCheckBox metroCheckEstado;
        private MetroFramework.Controls.MetroTextBox metroTextDescripcion;
        private MetroFramework.Controls.MetroGrid metroGridCompetencias;
        private MetroFramework.Controls.MetroTextBox metroTextBuscar;
        private MetroFramework.Controls.MetroButton metroButtonBuscar;
        private MetroFramework.Controls.MetroButton metroButtonCerrar;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonEditar;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
    }
}