namespace ProyectoPropietaria
{
    partial class FormDepartamento
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
            this.metroCheckEstado = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            this.metroGridDepartamentos = new MetroFramework.Controls.MetroGrid();
            this.metroButtonBuscar = new MetroFramework.Controls.MetroButton();
            this.metroTextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelId = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Estado";
            // 
            // metroCheckEstado
            // 
            this.metroCheckEstado.AutoSize = true;
            this.metroCheckEstado.Location = new System.Drawing.Point(151, 184);
            this.metroCheckEstado.Name = "metroCheckEstado";
            this.metroCheckEstado.Size = new System.Drawing.Size(104, 15);
            this.metroCheckEstado.TabIndex = 2;
            this.metroCheckEstado.Text = "Activo/Inactivo";
            this.metroCheckEstado.UseSelectable = true;
            // 
            // metroTextNombre
            // 
            // 
            // 
            // 
            this.metroTextNombre.CustomButton.Image = null;
            this.metroTextNombre.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.metroTextNombre.CustomButton.Name = "";
            this.metroTextNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextNombre.CustomButton.TabIndex = 1;
            this.metroTextNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextNombre.CustomButton.UseSelectable = true;
            this.metroTextNombre.CustomButton.Visible = false;
            this.metroTextNombre.Lines = new string[0];
            this.metroTextNombre.Location = new System.Drawing.Point(151, 132);
            this.metroTextNombre.MaxLength = 32767;
            this.metroTextNombre.Name = "metroTextNombre";
            this.metroTextNombre.PasswordChar = '\0';
            this.metroTextNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextNombre.SelectedText = "";
            this.metroTextNombre.SelectionLength = 0;
            this.metroTextNombre.SelectionStart = 0;
            this.metroTextNombre.ShortcutsEnabled = true;
            this.metroTextNombre.Size = new System.Drawing.Size(212, 23);
            this.metroTextNombre.TabIndex = 3;
            this.metroTextNombre.UseSelectable = true;
            this.metroTextNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(474, 78);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonGuardar.TabIndex = 4;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroButtonEditar
            // 
            this.metroButtonEditar.Location = new System.Drawing.Point(474, 132);
            this.metroButtonEditar.Name = "metroButtonEditar";
            this.metroButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEditar.TabIndex = 5;
            this.metroButtonEditar.Text = "Editar";
            this.metroButtonEditar.UseSelectable = true;
            this.metroButtonEditar.Click += new System.EventHandler(this.metroButtonEditar_Click);
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.Location = new System.Drawing.Point(474, 184);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEliminar.TabIndex = 6;
            this.metroButtonEliminar.Text = "Eliminar";
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // metroGridDepartamentos
            // 
            this.metroGridDepartamentos.AllowUserToResizeRows = false;
            this.metroGridDepartamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridDepartamentos.EnableHeadersVisualStyles = false;
            this.metroGridDepartamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDepartamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartamentos.Location = new System.Drawing.Point(24, 321);
            this.metroGridDepartamentos.Name = "metroGridDepartamentos";
            this.metroGridDepartamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridDepartamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDepartamentos.Size = new System.Drawing.Size(525, 194);
            this.metroGridDepartamentos.TabIndex = 7;
            this.metroGridDepartamentos.SelectionChanged += new System.EventHandler(this.metroGridDepartamentos_SelectionChanged);
            // 
            // metroButtonBuscar
            // 
            this.metroButtonBuscar.Location = new System.Drawing.Point(395, 292);
            this.metroButtonBuscar.Name = "metroButtonBuscar";
            this.metroButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonBuscar.TabIndex = 8;
            this.metroButtonBuscar.Text = "Buscar";
            this.metroButtonBuscar.UseSelectable = true;
            this.metroButtonBuscar.Click += new System.EventHandler(this.metroButtonBuscar_Click);
            // 
            // metroTextBuscar
            // 
            // 
            // 
            // 
            this.metroTextBuscar.CustomButton.Image = null;
            this.metroTextBuscar.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.metroTextBuscar.CustomButton.Name = "";
            this.metroTextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBuscar.CustomButton.TabIndex = 1;
            this.metroTextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBuscar.CustomButton.UseSelectable = true;
            this.metroTextBuscar.CustomButton.Visible = false;
            this.metroTextBuscar.Lines = new string[0];
            this.metroTextBuscar.Location = new System.Drawing.Point(151, 292);
            this.metroTextBuscar.MaxLength = 32767;
            this.metroTextBuscar.Name = "metroTextBuscar";
            this.metroTextBuscar.PasswordChar = '\0';
            this.metroTextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBuscar.SelectedText = "";
            this.metroTextBuscar.SelectionLength = 0;
            this.metroTextBuscar.SelectionStart = 0;
            this.metroTextBuscar.ShortcutsEnabled = true;
            this.metroTextBuscar.Size = new System.Drawing.Size(220, 23);
            this.metroTextBuscar.TabIndex = 9;
            this.metroTextBuscar.UseSelectable = true;
            this.metroTextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(23, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Id:";
            // 
            // metroLabelId
            // 
            this.metroLabelId.AutoSize = true;
            this.metroLabelId.Location = new System.Drawing.Point(53, 78);
            this.metroLabelId.Name = "metroLabelId";
            this.metroLabelId.Size = new System.Drawing.Size(12, 19);
            this.metroLabelId.TabIndex = 11;
            this.metroLabelId.Text = ".";
            this.metroLabelId.Click += new System.EventHandler(this.metroLabelId_Click);
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 538);
            this.Controls.Add(this.metroLabelId);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBuscar);
            this.Controls.Add(this.metroButtonBuscar);
            this.Controls.Add(this.metroGridDepartamentos);
            this.Controls.Add(this.metroButtonEliminar);
            this.Controls.Add(this.metroButtonEditar);
            this.Controls.Add(this.metroButtonGuardar);
            this.Controls.Add(this.metroTextNombre);
            this.Controls.Add(this.metroCheckEstado);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormDepartamento";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.FormDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckEstado;
        private MetroFramework.Controls.MetroTextBox metroTextNombre;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonEditar;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
        private MetroFramework.Controls.MetroGrid metroGridDepartamentos;
        private MetroFramework.Controls.MetroButton metroButtonBuscar;
        private MetroFramework.Controls.MetroTextBox metroTextBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabelId;
    }
}

