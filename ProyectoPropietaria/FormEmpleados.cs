﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
                Salario = float.Parse(metroTextSalario.Text),
                Estado = (bool)metroCheckEstado.Checked

            };
            if (metroTextCedula.Text != string.Empty)
            {
                using (var context = new RRHHEntities())
                {
                    context.Empleados.Add(empleado);
                    context.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                }
                Refrescar();
            }
            else
            {
                MessageBox.Show("Cedula no Valida", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                var puesto = from pues in context.Puestos
                             where (pues.Estado == true)
                             select pues.Nombre;
                metroComboPuesto.DataSource = puesto.ToList();

                var departameto = from dep in context.Departamento
                                  where (dep.Estado == true)
                                  select dep.NombreDepartamento;
                metroComboDepartamento.DataSource = departameto.ToList();


            }
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(metroLabeId.Text);
            if (metroTextCedula.Text != string.Empty)
            {
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
                    Refrescar();
                }
            }
            else
            {
                MessageBox.Show("Cedula no Valida", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void metroButtonReporte_Click(object sender, EventArgs e)
        {
            var report = new FormReportView();
            report.ShowDialog();
          
        }

        private void metroTextSalario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(metroTextSalario.Text))
            {
                MessageBox.Show("Salario es un campo requerido.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (float.Parse(metroTextSalario.Text) < 0)
            {
                MessageBox.Show("Salario no puede ser menor que 0", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextSalario.Clear();
            }
        }

        private void metroTextCedula_Validating(object sender, CancelEventArgs e)
        {
            validaCedula(metroTextCedula.Text);
        }
        public static void validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
            {
                MessageBox.Show("Ingrese solo Numeros (Ej: 40214736478)", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 != 0)
            {
                MessageBox.Show("Cedula no Valida", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
