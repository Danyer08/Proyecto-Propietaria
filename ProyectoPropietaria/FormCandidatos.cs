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
                SalarioDeseado = Convert.ToInt32(metroTextSalario.Text),
                Competencias = metroTextCompetencias.Text,
                Capacitaciones = metroTextCapacitaciones.Text,
                Experiencia = metroTextExperiencia.Text,
                Recomendacion = metroTextRecomendacion.Text

            };


            using (var context = new RRHHEntities())
            {
                context.Candidatos.Add(candidato);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
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
            metroComboDepartamento.SelectedIndex = metroComboDepartamento.FindStringExact(selectedRow.Cells["Departamento"].Value.ToString());
            metroTextSalario.Text = selectedRow.Cells["SalarioDeseado"].Value.ToString();
            metroTextCompetencias.Text = selectedRow.Cells["Competencias"].Value.ToString();
            metroTextCapacitaciones.Text = selectedRow.Cells["Capacitaciones"].Value.ToString();
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

            using (var context = new RRHHEntities())
            {
                var canToUpdate = context.Candidatos.SingleOrDefault(can => can.Id == canId);
                if (canToUpdate != null)
                {
                    canToUpdate.Nombre = metroTextNombre.Text;
                    canToUpdate.Cedula = metroTextCedula.Text;
                    canToUpdate.PuestoAspirante = metroComboPuesto.Text;
                    canToUpdate.Deparamento = metroComboDepartamento.Text;
                    canToUpdate.SalarioDeseado = Convert.ToInt32(metroTextSalario.Text);
                    canToUpdate.Competencias = metroTextCompetencias.Text;
                    canToUpdate.Capacitaciones = metroTextCapacitaciones.Text;
                    canToUpdate.Experiencia = metroTextExperiencia.Text;
                    canToUpdate.Recomendacion = metroTextRecomendacion.Text;
                }
                context.Entry(canToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados");
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
    }
   
}
