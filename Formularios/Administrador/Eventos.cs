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
    public partial class Eventos : Form
    {
        private List<Evento> evento;
        private List<Sala> sala;
        private List<Cliente> cliente;
        private List<Empleados> empleado;
        private List<Paquete> paquete;

        CRUDEventos crudEventos = new CRUDEventos();

        public Eventos()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            CargarEventos();
            CargarSalas();
            CargarClientes();
            CargarEmpleados();
            CargarPaquetes();
            CargarEstados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["EventoId"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombreEvento"].Value.ToString();
                dateInicio.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["FechaInicio"].Value.ToString());
                dateFin.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["FechaFin"].Value.ToString());
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                comboSalaID.SelectedValue = dataGridView1.CurrentRow.Cells["SalaId"].Value;
                comboClienteID.SelectedValue = dataGridView1.CurrentRow.Cells["ClienteId"].Value;
                comboEmpleadoID.SelectedValue = dataGridView1.CurrentRow.Cells["EmpleadoId"].Value;
                comboPaquetesID.SelectedValue = dataGridView1.CurrentRow.Cells["PaqueteId"].Value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea crear este evento?", "Crear Evento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var evento = new Evento
                {
                    NombreEvento = txtNombre.Text,
                    FechaInicio = dateInicio.Value,
                    FechaFin = dateFin.Value,
                    Descripcion = txtDescripcion.Text,
                    SalaId = (int)comboSalaID.SelectedValue,
                    ClienteId = (int)comboClienteID.SelectedValue,
                    EmpleadoId = (int)comboEmpleadoID.SelectedValue,
                    PaqueteId = (int)comboPaquetesID.SelectedValue,
                    Estado = comboEstado.Text
                };

                crudEventos.CrearEvento(evento);
                CargarEventos();
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea editar este evento?", "Editar Evento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var evento = new Evento
                {
                    EventoId = int.Parse(txtID.Text),
                    NombreEvento = txtNombre.Text,
                    FechaInicio = dateInicio.Value,
                    FechaFin = dateFin.Value,
                    Descripcion = txtDescripcion.Text,
                    SalaId = (int)comboSalaID.SelectedValue,
                    ClienteId = (int)comboClienteID.SelectedValue,
                    EmpleadoId = (int)comboEmpleadoID.SelectedValue,
                    PaqueteId = (int)comboPaquetesID.SelectedValue,
                    Estado = comboEstado.Text
                };

                crudEventos.ActualizarEvento(evento);
                CargarEventos();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este evento?", "Eliminar Evento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var evento = new Evento
                {
                    EventoId = int.Parse(txtID.Text)
                };

                crudEventos.EliminarEvento(evento);
                CargarEventos();
                LimpiarCampos();
            }
        }

        private void CargarEventos()
        {
            using (var contexto = new EventosContext())
            {
                var eventos = contexto.Eventos.ToList();
                dataGridView1.DataSource = eventos;
                dataGridView1.Columns["Sala"].Visible = false;
                dataGridView1.Columns["Cliente"].Visible = false;
                dataGridView1.Columns["Empleado"].Visible = false;
                dataGridView1.Columns["Paquete"].Visible = false;
                dataGridView1.Columns["Facturas"].Visible = false;
            }
        }

        private void CargarSalas()
        {
            using (var contexto = new EventosContext())
            {
                var salas = contexto.Salas.ToList();
                comboSalaID.DataSource = salas;
                comboSalaID.DisplayMember = "NombreSala";
                comboSalaID.ValueMember = "SalaId";
            }
        }

        private void CargarClientes()
        {
            using (var contexto = new EventosContext())
            {
                var clientes = contexto.Clientes.ToList();
                comboClienteID.DataSource = clientes;
                comboClienteID.DisplayMember = "Nombre";
                comboClienteID.ValueMember = "ClienteId";
            }
        }

        private void CargarPaquetes()
        {
            using (var contexto = new EventosContext())
            {
                var paquetes = contexto.Paquetes.ToList();
                comboPaquetesID.DataSource = paquetes;
                comboPaquetesID.DisplayMember = "NombrePaquete";
                comboPaquetesID.ValueMember = "PaqueteId";
            }
        }

        private void CargarEmpleados()
        {
            using (var contexto = new EventosContext())
            {
                var empleados = contexto.Empleados.ToList();
                comboEmpleadoID.DataSource = empleados;
                comboEmpleadoID.DisplayMember = "Nombre";
                comboEmpleadoID.ValueMember = "EmpleadoId";
            }
        }


        private void CargarEstados()
        {
            var estados = new List<string>
            {
                "Pendiente",
                "En curso",
                "Completado",
                "Cancelado"
            };
            comboEstado.DataSource = estados;
        }

        private void LimpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            dateInicio.Value = DateTime.Now;
            dateFin.Value = DateTime.Now;
            txtDescripcion.Text = "";
            comboSalaID.SelectedIndex = 0;
            comboClienteID.SelectedIndex = 0;
            comboEmpleadoID.SelectedIndex = 0;
            comboPaquetesID.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }
    }
}
