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
    public partial class FormCompetencias : MetroForm
    {
        public FormCompetencias()
        {
            InitializeComponent();
        }

        private void FormCompetencias_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Competencias competencia = new Competencias
            {
                Descripcion = metroTextDescripcion.Text,
                Estado = metroCheckEstado.Checked
            };

            using (var context = new RRHHEntities())
            {
                context.Competencias.Add(competencia);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }

        private void metroGridCompetencias_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridCompetencias.SelectedRows.Count > 0)
            {
                selectedRow = metroGridCompetencias.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            metroCheckEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        private void metroButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int comId = Convert.ToInt32(metroLabelId.Text);

            using (var context = new RRHHEntities())
            {
                var comToUpdate = context.Competencias.SingleOrDefault(com => com.id == comId);
                if (comToUpdate != null)
                {
                    comToUpdate.Descripcion = metroTextDescripcion.Text;
                    comToUpdate.Estado = metroCheckEstado.Checked;
                }
                context.Entry(comToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados.");
            }
            Refrescar();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int comId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var competencia = context.Competencias.Find(comId);
                context.Competencias.Remove(competencia);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var competencias = from com in context.Competencias
                                    select new
                                    {
                                        com.id,
                                        com.Descripcion,
                                        com.Estado
                                    };
                metroGridCompetencias.DataSource = competencias.ToList();
            }
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var competencia = from com  in context.Competencias
                                    where (com.Descripcion.StartsWith(metroTextBuscar.Text))
                                    select com;
                metroGridCompetencias.DataSource = competencia.ToList();
            }


        }
    }
}
