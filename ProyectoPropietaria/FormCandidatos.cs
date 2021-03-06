﻿using MetroFramework.Forms;
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
    public partial class FormCandidatos : MetroForm
    {
        public FormCandidatos()
        {
            InitializeComponent();
        }

        private void FormCandidatos_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var candidatos = from can in context.Candidatos
                                    select new
                                    {
                                        can.Id,
                                        can.Nombre,
                                        can.Cedula,
                                        can.PuestoAspirante,
                                        can.Deparamento,
                                        can.SalarioDeseado,
                                        can.Competencias,
                                        can.Capacitaciones,
                                        can.Experiencia,
                                        can.Recomendacion
                                    };
                metroGridCandidatos.DataSource = candidatos.ToList();
                FillComboBox();
            }
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Candidatos candidato = new Candidatos()
            {
                Nombre = metroTextNombre.Text,
                Cedula = metroTextCedula.Text,
                PuestoAspirante = metroComboPuesto.Text,
                Deparamento = metroComboDepartamento.Text,
                SalarioDeseado = float.Parse(metroTextSalario.Text),
                Competencias = metroComboCompetencias.Text,
                Capacitaciones = metroComboCapacitaciones.Text,
                Experiencia = metroTextExperiencia.Text,
                Recomendacion = metroTextRecomendacion.Text

            };

            if (metroTextCedula.Text != string.Empty)
            {
                using (var context = new RRHHEntities())
                {
                    context.Candidatos.Add(candidato);
                    context.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                }
            }
            else {
                MessageBox.Show("Cedula no Valida", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Refrescar();
        }

        private void metroGridCandidatos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridCandidatos.SelectedRows.Count > 0)
            {
                selectedRow = metroGridCandidatos.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            metroTextCedula.Text = selectedRow.Cells["Cedula"].Value.ToString();
            metroComboPuesto.SelectedIndex = metroComboPuesto.FindStringExact(selectedRow.Cells["PuestoAspirante"].Value.ToString());
            metroComboDepartamento.SelectedIndex = metroComboDepartamento.FindStringExact(selectedRow.Cells["Deparamento"].Value.ToString());
            metroTextSalario.Text = selectedRow.Cells["SalarioDeseado"].Value.ToString();
            metroComboCompetencias.SelectedIndex = metroComboCompetencias.FindStringExact(selectedRow.Cells["Competencias"].Value.ToString());
            metroComboCapacitaciones.SelectedIndex = metroComboCapacitaciones.FindStringExact(selectedRow.Cells["Capacitaciones"].Value.ToString());
            metroTextExperiencia.Text = selectedRow.Cells["Experiencia"].Value.ToString();
            metroTextRecomendacion.Text = selectedRow.Cells["Recomendacion"].Value.ToString();

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

                var competencias = from com in context.Competencias
                                 where (com.Estado == true)
                                 select com.Descripcion;
                metroComboCompetencias.DataSource = competencias.ToList();

                var capacitaciones = from cap in context.Capacitaciones
                                     select cap.Descripcion;
                metroComboCapacitaciones.DataSource = capacitaciones.ToList();
            }
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var candidatos = from cap in context.Capacitaciones
                                   where (cap.Descripcion.StartsWith(metroTextBuscar.Text) || cap.Institucion.StartsWith(metroTextBuscar.Text) || cap.Nivel.StartsWith(metroTextBuscar.Text)
                                   || cap.Idiomas.StartsWith(metroTextBuscar.Text))
                                   select cap;
                metroGridCandidatos.DataSource = candidatos.ToList();
            }


        }

        private void metroButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonCapacitaciones_Click(object sender, EventArgs e)
        {
            var capacitacion = new FormCapacitaciones();
            capacitacion.ShowDialog();
        }

        private void metroButtonExperiencia_Click(object sender, EventArgs e)
        {
            var experiencia = new FormExperienciaLaboral();
            experiencia.ShowDialog();
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int canId = Convert.ToInt32(metroLabelId.Text);
            if (metroTextCedula.Text != string.Empty)
            {
                using (var context = new RRHHEntities())
                {
                    var canToUpdate = context.Candidatos.SingleOrDefault(can => can.Id == canId);
                    if (canToUpdate != null)
                    {
                        canToUpdate.Nombre = metroTextNombre.Text;
                        canToUpdate.Cedula = metroTextCedula.Text;
                        canToUpdate.PuestoAspirante = metroComboPuesto.Text;
                        canToUpdate.Deparamento = metroComboDepartamento.Text;
                        canToUpdate.SalarioDeseado = float.Parse(metroTextSalario.Text);
                        canToUpdate.Competencias = metroComboCompetencias.Text;
                        canToUpdate.Capacitaciones = metroComboCapacitaciones.Text;
                        canToUpdate.Experiencia = metroTextExperiencia.Text;
                        canToUpdate.Recomendacion = metroTextRecomendacion.Text;
                    }
                    context.Entry(canToUpdate).State = EntityState.Modified;
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

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int canId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var candidato = context.Candidatos.Find(canId);
                context.Candidatos.Remove(candidato);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
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

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            int canId = Convert.ToInt32(metroLabelId.Text);
            Empleados empleado = new Empleados
            {
                Nombre = metroTextNombre.Text,
                Cedula = metroTextCedula.Text,
                FechaIngreso = DateTime.Now,
                Departamento = metroComboDepartamento.Text,
                Puesto = metroComboPuesto.Text,
                Salario = float.Parse(metroTextSalario.Text),
                Estado = true

            };

            using (var context = new RRHHEntities())
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();

                var candidato = context.Candidatos.Find(canId);
                context.Candidatos.Remove(candidato);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
                Refrescar();
            }
        }
    }
   
}
