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
    public partial class FormReportView : MetroForm
    {
        public FormReportView()
        {
            InitializeComponent();
        }

        private void FormReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RRHHDataSet.Empleados' table. You can move, or remove it, as needed.
            this.EmpleadosTableAdapter.Fill(this.RRHHDataSet.Empleados);
            using (var context = new RRHHEntities())
            {

                var empleado = from emp in context.Empleados
                               select new {
                                   emp.Nombre,
                                   emp.Cedula,
                                   emp.FechaIngreso,
                                   emp.Departamento,
                                   emp.Estado};
                EmpleadosBindingSource.DataSource = empleado.ToList();

            }
            this.reportViewer1.RefreshReport();
        }

        private void EmpleadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
