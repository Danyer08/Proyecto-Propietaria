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
    public partial class FormCapacitaciones : MetroForm
    {

        public FormCapacitaciones()
        {
            InitializeComponent();
        }

        private void FormCapacitaciones_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var capacitacion = from cap in context.Capacitaciones
                                    select new
                                    {
                                        cap.Id,
                                        cap.Descripcion,
                                        cap.Nivel,
                                        cap.FechaInicio,
                                        cap.FechaFinalizacion,
                                        cap.Institucion,
                                        cap.Idiomas
                                    };
                metroGridCapacitaciones.DataSource = capacitacion.ToList();
                FillComboBox();
            }
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Capacitaciones capacitacion = new Capacitaciones
            {
                Descripcion = metroTextDescripcion.Text,
                Nivel = metroComboNivel.Text,
                FechaInicio = (DateTime)metroDateInicio.Value,
                FechaFinalizacion =  (DateTime)metroDateFin.Value,
                Institucion = metroTextInstitucion.Text,
                Idiomas = metroComboIdiomas.Text
                
            };

            using (var context = new RRHHEntities())
            {
                context.Capacitaciones.Add(capacitacion);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var capacitacion = from cap in context.Capacitaciones
                                   where (cap.Descripcion.StartsWith(metroTextBuscar.Text) || cap.Institucion.StartsWith(metroTextBuscar.Text) || cap.Nivel.StartsWith(metroTextBuscar.Text)
                                   || cap.Idiomas.StartsWith(metroTextBuscar.Text))
                                    select cap;
                metroGridCapacitaciones.DataSource = capacitacion.ToList();
            }


        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        private void metroComboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void FillComboBox()
        {
            Dictionary<string, string> niveles = new Dictionary<string, string>();
            niveles.Add("1", "Bachiller");
            niveles.Add("2", "Licenciado");
            niveles.Add("3", "Master");
            niveles.Add("4", "Doctor");
            metroComboNivel.DataSource = new BindingSource(niveles, null);
            metroComboNivel.DisplayMember = "Value";
            metroComboNivel.ValueMember = "Key";

            Dictionary<string, string> idiomas = new Dictionary<string, string>();
            idiomas.Add("1", "Español");
            idiomas.Add("2", "Ingles");
            idiomas.Add("3", "Frances");
            idiomas.Add("4", "Italiano");
            metroComboIdiomas.DataSource = new BindingSource(idiomas, null);
            metroComboIdiomas.DisplayMember = "Value";
            metroComboIdiomas.ValueMember = "Key";
        }

        private void metroGridCapacitaciones_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridCapacitaciones.SelectedRows.Count > 0)
            {
                selectedRow = metroGridCapacitaciones.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabeld.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            metroComboNivel.SelectedIndex = metroComboNivel.FindStringExact(selectedRow.Cells["Nivel"].Value.ToString());
            metroDateInicio.Value = (DateTime)selectedRow.Cells["FechaInicio"].Value;
            metroDateFin.Value = (DateTime)selectedRow.Cells["FechaFinalizacion"].Value;
            metroTextInstitucion.Text = selectedRow.Cells["Institucion"].Value.ToString();
            metroComboIdiomas.SelectedIndex = metroComboIdiomas.FindStringExact(selectedRow.Cells["Idiomas"].Value.ToString());
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int capId = Convert.ToInt32(metroLabeld.Text);

            using (var context = new RRHHEntities())
            {
                var capToUpdate = context.Capacitaciones.SingleOrDefault(cap => cap.Id == capId);
                if (capToUpdate != null)
                {
                    capToUpdate.Descripcion = metroTextDescripcion.Text;
                    capToUpdate.Nivel = metroComboNivel.Text;
                    capToUpdate.FechaInicio = metroDateInicio.Value;
                    capToUpdate.FechaFinalizacion = metroDateFin.Value;
                    capToUpdate.Institucion = metroTextInstitucion.Text;
                    capToUpdate.Idiomas = metroComboIdiomas.Text;
                }
                context.Entry(capToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados");
            }
            Refrescar();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int capId = Convert.ToInt32(metroLabeld.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var capacitacion = context.Capacitaciones.Find(capId);
                context.Capacitaciones.Remove(capacitacion);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }
    }


}