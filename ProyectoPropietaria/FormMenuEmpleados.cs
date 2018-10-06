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
    public partial class FormMenuEmpleados : MetroForm
    {
        public FormMenuEmpleados()
        {
            InitializeComponent();
        }

        private void FormMenuEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empleados = new FormEmpleados();
            empleados.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var departamentos = new FormDepartamento();
            departamentos.ShowDialog();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var puestos = new FormPuestos();
            puestos.ShowDialog();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idiomas = new FormIdiomas();
            idiomas.ShowDialog();
        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var competencia = new FormCompetencias();
            competencia.ShowDialog();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var capacitacion = new FormCapacitaciones();
            capacitacion.ShowDialog();
        }
    }
}
