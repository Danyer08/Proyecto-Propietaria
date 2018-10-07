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
    public partial class FormExperienciaLaboral : MetroForm
    {
        public FormExperienciaLaboral()
        {
            InitializeComponent();
        }

        private void FormExperienciaLaboral_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var experiencia = from exp in context.ExperienciaLaboral
                                   select new
                                   {
                                       exp.Id,
                                       exp.Empresa,
                                       exp.Puesto,
                                       exp.FechaInicio,
                                       exp.FechaFinalizacion,
                                       exp.Nombre_Candidato
                                   };
                metroGridExperiencia.DataSource = experiencia.ToList();
            }
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            ExperienciaLaboral experiencia = new ExperienciaLaboral
            {
                Empresa = metroTextEmpresa.Text,
                Puesto = metroTextPuesto.Text,
                FechaInicio = (DateTime)metroDateFechaInicio.Value,
                FechaFinalizacion = (DateTime)metroDateFechaFin.Value,
                Nombre_Candidato = textBoxCandidato.Text
            };
            if((DateTime)metroDateFechaInicio.Value > (DateTime)metroDateFechaFin.Value)
            {
                using (var context = new RRHHEntities())
                {
                    context.ExperienciaLaboral.Add(experiencia);
                    context.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                }
                Refrescar();
            }
            else
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha de finalizacion.");
            }
            
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int expId = Convert.ToInt32(metroLabelId.Text);

            using (var context = new RRHHEntities())
            {
                var expToUpdate = context.ExperienciaLaboral.SingleOrDefault(exp => exp.Id == expId );
                if (expToUpdate != null)
                {
                    expToUpdate.Empresa = metroTextEmpresa.Text;
                    expToUpdate.Puesto = metroTextPuesto.Text;
                    expToUpdate.FechaInicio = (DateTime)metroDateFechaInicio.Value;
                    expToUpdate.FechaFinalizacion = (DateTime)metroDateFechaFin.Value;
                    expToUpdate.Nombre_Candidato = textBoxCandidato.Text;
                }
                context.Entry(expToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados");
            }
            Refrescar();
        }

        private void metroGridExperiencia_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridExperiencia.SelectedRows.Count > 0)
            {
                selectedRow = metroGridExperiencia.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextEmpresa.Text = selectedRow.Cells["Empresa"].Value.ToString();
            metroTextPuesto.Text = selectedRow.Cells["Puesto"].Value.ToString();
            metroDateFechaInicio.Value = (DateTime)selectedRow.Cells["FechaInicio"].Value;
            metroDateFechaFin.Value = (DateTime)selectedRow.Cells["FechaFinalizacion"].Value;
            textBoxCandidato.Text = selectedRow.Cells["Nombre_Candidato"].Value.ToString();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int expId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var experiencia = context.ExperienciaLaboral.Find(expId);
                context.ExperienciaLaboral.Remove(experiencia);
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
                var experiencia = from exp in context.ExperienciaLaboral
                                   where (exp.Empresa.StartsWith(metroTextBuscar.Text) || exp.Puesto.StartsWith(metroTextBuscar.Text) || exp.Nombre_Candidato.StartsWith(metroTextBuscar.Text))
                                   select exp;
                metroGridExperiencia.DataSource = experiencia.ToList();
            }


        }

        private void metroButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
