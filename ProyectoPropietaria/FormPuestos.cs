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
    public partial class FormPuestos : MetroForm
    {
        public FormPuestos()
        {
            InitializeComponent();
        }

        private void FormPuestos_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Puestos puesto = new Puestos
            {
                Nombre = metroTextNombre.Text,
                NivelRiesgo = metroComboRiego.Text,
                SalarioMinimo = float.Parse(metroTextMinimo.Text),
                SalarioMaximo = float.Parse(metroTextMaximo.Text),
                Departamento = metroComboDepartamento.Text,
                Estado = (bool)metroCheckEstado.Checked

            };

            using (var context = new RRHHEntities())
            {
                context.Puestos.Add(puesto);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }
        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var puestos = from pue in context.Puestos
                                   select new
                                   {
                                       pue.Id,
                                       pue.Nombre,
                                       pue.NivelRiesgo,
                                       pue.SalarioMinimo,
                                       pue.SalarioMaximo,
                                       pue.Departamento,
                                       pue.Estado
                                   };
                metroGridPuestos.DataSource = puestos.ToList();
                FillComboBox();
            }
        }
        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var puestos = from pue in context.Puestos
                                  where (pue.Nombre.StartsWith(metroTextBuscar.Text) || pue.NivelRiesgo.StartsWith(metroButtonBuscar.Text))
                                  select pue;
                metroGridPuestos.DataSource = puestos.ToList();
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

        private void metroGridPuestos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (metroGridPuestos.SelectedRows.Count > 0)
            {
                selectedRow = metroGridPuestos.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroLabelId.Text = selectedRow.Cells["Id"].Value.ToString();
            metroTextNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
            metroComboRiego.SelectedIndex = metroComboRiego.FindStringExact(selectedRow.Cells["NivelRiesgo"].Value.ToString());
            metroTextMinimo.Text = selectedRow.Cells["SalarioMinimo"].Value.ToString();
            metroTextMaximo.Text = selectedRow.Cells["SalarioMaximo"].Value.ToString();
            metroComboDepartamento.SelectedIndex = metroComboDepartamento.FindStringExact(selectedRow.Cells["Departamento"].Value.ToString());
            metroCheckEstado.Checked = (bool)selectedRow.Cells["Estado"].Value;
        }
        public void FillComboBox()
        {
            Dictionary<string, string> niveles = new Dictionary<string, string>();
            niveles.Add("1", "Alto");
            niveles.Add("2", "Medio");
            niveles.Add("3", "Bajo");
            metroComboRiego.DataSource = new BindingSource(niveles, null);
            metroComboRiego.DisplayMember = "Value";
            metroComboRiego.ValueMember = "Key";

            using (var context = new RRHHEntities())
            {

                var departameto = from dep in context.Departamento
                                  where (dep.Estado == true)
                                  select dep.NombreDepartamento;
                metroComboDepartamento.DataSource = departameto.ToList();


            }
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            int pueId = Convert.ToInt32(metroLabelId.Text);

            using (var context = new RRHHEntities())
            {
                var pueToUpdate = context.Puestos.SingleOrDefault(pue => pue.Id == pueId);
                if (pueToUpdate != null)
                {
                    pueToUpdate.Nombre = metroTextNombre.Text;
                    pueToUpdate.NivelRiesgo = metroComboRiego.Text;
                    pueToUpdate.SalarioMinimo = float.Parse(metroTextMinimo.Text);
                    pueToUpdate.SalarioMaximo = float.Parse(metroTextMaximo.Text);
                    pueToUpdate.Departamento = metroComboDepartamento.Text;
                    pueToUpdate.Estado = (bool)metroCheckEstado.Checked;
                }
                context.Entry(pueToUpdate).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Datos Modificados");
            }
            Refrescar();
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            int pueId = Convert.ToInt32(metroLabelId.Text);

            using (RRHHEntities context = new RRHHEntities())
            {
                var puesto = context.Puestos.Find(pueId);
                context.Puestos.Remove(puesto);
                context.SaveChanges();
                MessageBox.Show("Datos Eliminados");
                Refrescar();
            }
        }

        private void metroTextMinimo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(metroTextMinimo.Text))
            {
                MessageBox.Show("Salario es un campo requerido.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (float.Parse(metroTextMinimo.Text) < 0)
            {
                MessageBox.Show("Salario no puede ser menor que 0", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextMinimo.Clear();
            }
           
        }

        private void metroTextMaximo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(metroTextMaximo.Text))
            {
                MessageBox.Show("Salario es un campo requerido.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (float.Parse(metroTextMaximo.Text) < 0)
            {
                MessageBox.Show("Salario no puede ser menor que 0", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextMaximo.Clear();
            }
            
        }
    }
}

