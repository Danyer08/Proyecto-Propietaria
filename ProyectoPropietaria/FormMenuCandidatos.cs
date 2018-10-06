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
    public partial class FormMenuCandidatos : MetroForm
    {
        public FormMenuCandidatos()
        {
            InitializeComponent();
        }

        private void FormMenuCandidatos_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var candidato = new FormCandidatos();
            candidato.ShowDialog();
        }

        private void experienciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var experiencia = new FormExperienciaLaboral();
            experiencia.ShowDialog();
        }
    }
}
