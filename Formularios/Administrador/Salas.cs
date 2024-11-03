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
            // Manejar el evento de clic en una celda si es necesario
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var sala = new Sala
            {
                NombreSala = txtNombre.Text,
                Capacidad = int.Parse(numCapacidad.Text),
                Ubicacion = txtUbicacion.Text,
                Caracteristicas = txtCaracteristicas.Text
            };
            crudSalas.CrearSala(sala);
            CargarSalas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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


    }
}
