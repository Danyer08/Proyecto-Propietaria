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
    public partial class FormDepartamento : MetroForm
    {
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento
            {
                NombreDepartamento = metroTextNombre.Text,
                Estado = metroCheckEstado.Checked
            };

            using (var context = new RRHHEntities())
            {
                context.Departamento.Add(departamento);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var departamentos = from dep in context.Departamento
                                    select new
                                    {
                                        dep.Id,
                                        dep.NombreDepartamento,
                                        dep.Estado
                                    };
                metroGridDepartamentos.DataSource = departamentos.ToList();
            }
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var departamentos = from dep in context.Departamento
                                    where (dep.NombreDepartamento.StartsWith(metroTextBuscar.Text))
                                    select dep;
                metroGridDepartamentos.DataSource = departamentos.ToList();
            }


        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        private void metroGridDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridDepartamentos.SelectedRows.Count > 0)
            {
                selectedRow = metroGridDepartamentos.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextNombre.Text = selectedRow.Cells["NombreDepartamento"].Value.ToString();
            metroCheckEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int depId = Convert.ToInt32(metroLabelId.Text);

            using (var context = new RRHHEntities())
            {
                var depToUpdate = context.Departamento.SingleOrDefault(dep => dep.Id == depId);
                if(depToUpdate != null)
                {
                    depToUpdate.NombreDepartamento = metroTextNombre.Text;
                    depToUpdate.Estado = metroCheckEstado.Checked;
                }
                context.Entry(depToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados.");
            }
            Refrescar();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int depId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var departamento = context.Departamento.Find(depId);
                context.Departamento.Remove(departamento);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }

        private void metroLabelId_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
