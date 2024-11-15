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
                try
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
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione una sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, seleccione una sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta sala?", "Eliminar Sala", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var sala = new Sala
                    {
                        SalaId = int.Parse(txtID.Text),
                        NombreSala = txtNombre.Text,
                        Capacidad = (int)numCapacidad.Value,
                        Ubicacion = txtUbicacion.Text,
                        Caracteristicas = txtCaracteristicas.Text
                    };
                    crudSalas.EliminarSala(sala);
                    CargarSalas();
                    limpiarCampos();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarSalas()
        {
            using (var context = new EventosContext())
            {
                var salas = context.Salas.ToList();
                dataGridView1.DataSource = salas;
                dataGridView1.Columns["SalaId"].Visible = false;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            using (var context = new EventosContext())
            {
                var salasFiltradas = context.Salas
                    .Where(s => s.NombreSala.ToLower().Contains(filtro) ||
                                s.Ubicacion.ToLower().Contains(filtro) ||
                                s.Caracteristicas.ToLower().Contains(filtro))
                    .ToList();
                dataGridView1.DataSource = salasFiltradas;
            }
        }
    }
}
