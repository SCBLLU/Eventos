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
    public partial class Paquetes : Form
    {

        private List<Paquetes> paquete;
        CRUDPaquetes crudPaquetes = new CRUDPaquetes();

        public Paquetes()
        {
            InitializeComponent();
        }

        private void Paquetes_Load(object sender, EventArgs e)
        {
            CargarPaquetes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["PaqueteId"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombrePaquete"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtArticulos.Text = dataGridView1.CurrentRow.Cells["Articulos"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtArticulos.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea crear este paquete?", "Crear Paquete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var paquete = new Modelos.Paquete
                {
                    NombrePaquete = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Articulos = txtArticulos.Text
                };

                crudPaquetes.CrearPaquete(paquete);
                CargarPaquetes();
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un paquete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea editar este paquete?", "Editar Paquete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var paquete = new Modelos.Paquete
                {
                    PaqueteId = int.Parse(txtID.Text),
                    NombrePaquete = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Articulos = txtArticulos.Text
                };

                crudPaquetes.ActualizarPaquete(paquete);
                CargarPaquetes();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un paquete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este paquete?", "Eliminar Paquete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var paquete = new Modelos.Paquete
                {
                    PaqueteId = int.Parse(txtID.Text)
                };

                crudPaquetes.EliminarPaquete(paquete);
                CargarPaquetes();
                LimpiarCampos();
            }
        }

        private void CargarPaquetes()
        {
            using (var bd = new EventosContext())
            {
                var paquetes = bd.Paquetes.ToList();
                dataGridView1.DataSource = paquetes;
                dataGridView1.Columns["PaqueteId"].Visible = false;
                dataGridView1.Columns["Eventos"].Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtArticulos.Text = "";
            txtID.Text = "";
        }
    }
}
