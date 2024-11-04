using Eventos.Clases;
using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.Formularios.Administrador
{
    public partial class Salas : Form
    {

        private List<Sala> sala;
        CRUDSalas crudSalas = new CRUDSalas();

        public Salas()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            CargarSalas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombreSala"].Value.ToString();
                numCapacidad.Value = int.Parse(dataGridView1.CurrentRow.Cells["Capacidad"].Value.ToString());
                txtUbicacion.Text = dataGridView1.CurrentRow.Cells["Ubicacion"].Value.ToString();
                txtCaracteristicas.Text = dataGridView1.CurrentRow.Cells["Caracteristicas"].Value.ToString();
                txtID.Text = dataGridView1.CurrentRow.Cells["SalaId"].Value.ToString();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtCaracteristicas.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea crear esta sala?", "Crear Sala", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var sala = new Sala
                {
                    NombreSala = txtNombre.Text,
                    Capacidad = (int)numCapacidad.Value,
                    Ubicacion = txtUbicacion.Text,
                    Caracteristicas = txtCaracteristicas.Text
                };
                crudSalas.CrearSala(sala);
                CargarSalas();
                limpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione una sala para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea editar esta sala?", "Editar Sala", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var sala = new Sala
                {
                    SalaId = int.Parse(txtID.Text),
                    NombreSala = txtNombre.Text,
                    Capacidad = (int)numCapacidad.Value,
                    Ubicacion = txtUbicacion.Text,
                    Caracteristicas = txtCaracteristicas.Text
                };
                crudSalas.ActualizarSala(sala);
                CargarSalas();
                limpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione una sala para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta sala?", "Eliminar Sala", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var sala = new Sala
                {
                    SalaId = int.Parse(txtID.Text)
                };
                crudSalas.EliminarSala(sala);
                CargarSalas();
                limpiarCampos();
            }
        }

        private void CargarSalas()
        {
            // Cargar las salas desde la base de datos y enlazarlas al DataGridView
            using (var context = new EventosContext())
            {
                var salas = context.Salas.ToList();
                dataGridView1.DataSource = salas;
                dataGridView1.Columns["Eventos"].Visible = false;

            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            numCapacidad.Value = 0;
            txtUbicacion.Text = "";
            txtCaracteristicas.Text = "";
            txtID.Text = "";
        }

    }
}
