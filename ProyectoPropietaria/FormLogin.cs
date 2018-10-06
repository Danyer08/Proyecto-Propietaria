using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Login admin = new Login("Admin", "1233456");
        Login candidato = new Login("Candidato", "123456");
        Login empleado = new Login("Empleado", "123456");

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = metroTextUsuario.Text;
            string pass = metroTextPass.Text;
            //check if eligible to be logged in 
            if (admin.IsLoggedIn(user, pass))
            {
                var mainmenu = new FormMainMenu();
                mainmenu.ShowDialog();
            }
            else if (candidato.IsLoggedIn(user, pass))
            {
                var menuCandidatos = new FormMenuCandidatos();
                menuCandidatos.ShowDialog();
            }
            else if (empleado.IsLoggedIn(user, pass))
            {
                var menuEmpleados = new FormMenuEmpleados();
                menuEmpleados.ShowDialog();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Usuario no Valido","Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
