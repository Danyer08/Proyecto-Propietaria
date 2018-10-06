namespace ProyectoPropietaria
{
    partial class FormLogin
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
            this.metroTextUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroTextPass = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextUsuario
            // 
            // 
            // 
            // 
            this.metroTextUsuario.CustomButton.Image = null;
            this.metroTextUsuario.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.metroTextUsuario.CustomButton.Name = "";
            this.metroTextUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextUsuario.CustomButton.TabIndex = 1;
            this.metroTextUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextUsuario.CustomButton.UseSelectable = true;
            this.metroTextUsuario.CustomButton.Visible = false;
            this.metroTextUsuario.Lines = new string[0];
            this.metroTextUsuario.Location = new System.Drawing.Point(24, 92);
            this.metroTextUsuario.MaxLength = 32767;
            this.metroTextUsuario.Name = "metroTextUsuario";
            this.metroTextUsuario.PasswordChar = '\0';
            this.metroTextUsuario.PromptText = "Usuario";
            this.metroTextUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextUsuario.SelectedText = "";
            this.metroTextUsuario.SelectionLength = 0;
            this.metroTextUsuario.SelectionStart = 0;
            this.metroTextUsuario.ShortcutsEnabled = true;
            this.metroTextUsuario.Size = new System.Drawing.Size(263, 23);
            this.metroTextUsuario.TabIndex = 0;
            this.metroTextUsuario.UseSelectable = true;
            this.metroTextUsuario.WaterMark = "Usuario";
            this.metroTextUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextPass
            // 
            // 
            // 
            // 
            this.metroTextPass.CustomButton.Image = null;
            this.metroTextPass.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.metroTextPass.CustomButton.Name = "";
            this.metroTextPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextPass.CustomButton.TabIndex = 1;
            this.metroTextPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextPass.CustomButton.UseSelectable = true;
            this.metroTextPass.CustomButton.Visible = false;
            this.metroTextPass.Lines = new string[0];
            this.metroTextPass.Location = new System.Drawing.Point(24, 134);
            this.metroTextPass.MaxLength = 32767;
            this.metroTextPass.Name = "metroTextPass";
            this.metroTextPass.PasswordChar = '●';
            this.metroTextPass.PromptText = "Contraseña";
            this.metroTextPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextPass.SelectedText = "";
            this.metroTextPass.SelectionLength = 0;
            this.metroTextPass.SelectionStart = 0;
            this.metroTextPass.ShortcutsEnabled = true;
            this.metroTextPass.Size = new System.Drawing.Size(263, 23);
            this.metroTextPass.TabIndex = 1;
            this.metroTextPass.UseSelectable = true;
            this.metroTextPass.UseSystemPasswordChar = true;
            this.metroTextPass.WaterMark = "Contraseña";
            this.metroTextPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(92, 178);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(118, 23);
            this.metroButtonLogin.TabIndex = 2;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPropietaria.Properties.Resources.login_icon_png_27;
            this.pictureBox1.Location = new System.Drawing.Point(23, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.metroTextPass);
            this.Controls.Add(this.metroTextUsuario);
            this.Name = "FormLogin";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextUsuario;
        private MetroFramework.Controls.MetroTextBox metroTextPass;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}