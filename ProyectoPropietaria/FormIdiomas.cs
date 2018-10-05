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
    public partial class FormIdiomas : MetroForm
    {
        public FormIdiomas()
        {
            InitializeComponent();
        }

        private void FormIdiomas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var idiomas = from idiom in context.Idiomas
                                    select new
                                    {
                                        idiom.Id,
                                        idiom.Nombre,
                                        idiom.Estado
                                    };
                metroGridIdiomas.DataSource = idiomas.ToList();
            }
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Idiomas idioma = new Idiomas()
            {
                Nombre = metroTextNombre.Text,
                Estado = metroCheckEstado.Checked
            };
            using (RRHHEntities context = new RRHHEntities())
            {
                context.Idiomas.Add(idioma);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados.");
            };
            Refrescar();
        }

        private void metroGridIdiomas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridIdiomas.SelectedRows.Count > 0)
            {
                selectedRow = metroGridIdiomas.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            metroCheckEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int idiomId = Convert.ToInt32(metroLabelId.Text);

            using (var context = new RRHHEntities())
            {
                var idiomToUpdate = context.Idiomas.SingleOrDefault(idiom => idiom.Id == idiomId);
                if (idiomToUpdate != null)
                {
                    idiomToUpdate.Nombre = metroTextNombre.Text;
                    idiomToUpdate.Estado = metroCheckEstado.Checked;
                }
                context.Entry(idiomToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados.");
            }
            Refrescar();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int idiomId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var idioma = context.Idiomas.Find(idiomId);
                context.Idiomas.Remove(idioma);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var idioma = from idiom in context.Idiomas
                                    where (idiom.Nombre.StartsWith(metroTextBuscar.Text))
                                    select idiom;
                metroGridIdiomas.DataSource = idioma.ToList();
            }
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        private void metroButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
