using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietaria
{
    public partial class FormEmpleados : MetroForm
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados
            {
                Nombre = metroTextNombre.Text,
                Cedula = metroTextCedula.Text,
                FechaIngreso = (DateTime)metroDateIngreso.Value,
                Departamento = metroComboDepartamento.Text,
                Puesto = metroComboPuesto.Text,
                Salario = Convert.ToInt32(metroTextSalario.Text),
                Estado = (bool)metroCheckEstado.Checked

            };

            using (var context = new RRHHEntities())
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var empleados = from emp in context.Empleados
                                 select new
                                 {
                                     emp.Id,
                                     emp.Nombre,
                                     emp.Cedula,
                                     emp.FechaIngreso,
                                     emp.Departamento,
                                     emp.Puesto,
                                     emp.Salario,
                                     emp.Estado

                                 };
                metroGridEmpleados.DataSource = empleados.ToList();
                FillComboBox();
            }
        }
        public void FillComboBox()
        {
            using (var context = new RRHHEntities())
            {
                var puesto = from pue in context.Puestos
                             select new
                             {
                                 pue.Nombre
                             };
                metroComboPuesto.DataSource = puesto.ToList();

                var departamento = from dep in context.Departamento
                                   select new
                                   {
                                       dep.NombreDepartamento
                                   };
                metroComboDepartamento.DataSource = departamento.ToList();
            }
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(metroLabeId.Text);

            using (var context = new RRHHEntities())
            {
                var empToUpdate = context.Empleados.SingleOrDefault(emp => emp.Id == empId);
                if (empToUpdate != null)
                {
                    empToUpdate.Nombre = metroTextNombre.Text;
                    empToUpdate.Cedula = metroTextCedula.Text;
                    empToUpdate.FechaIngreso = (DateTime)metroDateIngreso.Value;
                    empToUpdate.Departamento = metroComboDepartamento.Text;
                    empToUpdate.Puesto = metroComboPuesto.Text;
                    empToUpdate.Salario = Convert.ToInt32(metroTextSalario.Text);
                    empToUpdate.Estado = (bool)metroCheckEstado.Checked;
                }
                context.Entry(empToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados");
            }
        }

        private void metroGridEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridEmpleados.SelectedRows.Count > 0)
            {
                selectedRow = metroGridEmpleados.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabeId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            metroTextCedula.Text = selectedRow.Cells["Cedula"].Value.ToString();
            metroComboPuesto.SelectedIndex = metroComboPuesto.FindStringExact(selectedRow.Cells["Puesto"].Value.ToString());
            metroComboDepartamento.SelectedIndex = metroComboDepartamento.FindStringExact(selectedRow.Cells["Departamento"].Value.ToString());
            metroTextSalario.Text = selectedRow.Cells["Salario"].Value.ToString();
            metroCheckEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(metroLabeId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var empleado = context.Empleados.Find(empId);
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var empleados = from emp in context.Empleados
                                   where (emp.Nombre.StartsWith(metroTextBuscar.Text) || emp.Cedula.StartsWith(metroTextBuscar.Text))
                                   select emp;
                metroGridEmpleados.DataSource = empleados.ToList();
            }


        }

        private void metroButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
