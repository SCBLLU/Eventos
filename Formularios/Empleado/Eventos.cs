using Eventos.Clases;
using Eventos.Formularios.Administrador;
using Eventos.Modelos;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.Formularios.Empleado
{
    public partial class Eventos : Form
    {
        private List<Evento> eventos;
        private List<Sala> salas;
        private List<Cliente> clientes;
        private List<Empleados> empleados;
        private List<Paquete> paquetes;

        private int empleadoIdEnSesion; // recibe el ID del empleado en sesión

        CRUDEventos crudEventos = new CRUDEventos();

        public Eventos(int empleadoId)
        {
            InitializeComponent();
            empleadoIdEnSesion = empleadoId; // Asignar el ID del empleado en sesión
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            CargarEventos();
            CargarSalas();
            CargarClientes();
            CargarPaquetes();
            CargarEmpleados();
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
                comboEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
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
                try
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
                var eventos = contexto.Eventos
                    .Where(e => e.EmpleadoId == empleadoIdEnSesion) // Filtrar por el ID del empleado en sesión
                    .Select(e => new
                    {
                        e.EventoId,
                        e.NombreEvento,
                        e.FechaInicio,
                        e.FechaFin,
                        e.Descripcion,

                        SalaId = e.Sala.SalaId,
                        ClienteId = e.Cliente.ClienteId,
                        PaqueteId = e.Paquete.PaqueteId,
                        EmpleadoId = e.Empleado.EmpleadoId,

                        Sala = e.Sala.NombreSala,
                        Cliente = e.Cliente.Nombre,
                        Paquete = e.Paquete.NombrePaquete,
                        Empleado = e.Empleado.Nombre,

                        e.Estado,
                    }).ToList();
                dataGridView1.DataSource = eventos;

                // Ocultar Ids
                dataGridView1.Columns["EventoId"].Visible = false;
                dataGridView1.Columns["SalaId"].Visible = false;
                dataGridView1.Columns["ClienteId"].Visible = false;
                dataGridView1.Columns["PaqueteId"].Visible = false;
                dataGridView1.Columns["EmpleadoId"].Visible = false;
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

                // Seleccionar el EmpleadoId del empleado en sesión
                comboEmpleadoID.SelectedValue = empleadoIdEnSesion;
            }
        }

        private void CargarEstados()
        {
            using (var context = new EventosContext())
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
            comboEmpleadoID.SelectedValue = empleadoIdEnSesion;
            comboPaquetesID.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            using (var contexto = new EventosContext())
            {
                var eventosFiltrados = contexto.Eventos
                    .Where(e => e.NombreEvento.ToLower().Contains(filtro) ||
                                e.Descripcion.ToLower().Contains(filtro) ||
                                e.Sala.NombreSala.ToLower().Contains(filtro) ||
                                e.Cliente.Nombre.ToLower().Contains(filtro) ||
                                e.Empleado.Nombre.ToLower().Contains(filtro) ||
                                e.Paquete.NombrePaquete.ToLower().Contains(filtro) ||
                                e.Estado.ToLower().Contains(filtro))
                    .Select(e => new
                    {
                        e.EventoId,
                        e.NombreEvento,
                        e.FechaInicio,
                        e.FechaFin,
                        e.Descripcion,
                        SalaId = e.Sala.SalaId,
                        ClienteId = e.Cliente.ClienteId,
                        PaqueteId = e.Paquete.PaqueteId,
                        EmpleadoId = e.Empleado.EmpleadoId,
                        Sala = e.Sala.NombreSala,
                        Cliente = e.Cliente.Nombre,
                        Paquete = e.Paquete.NombrePaquete,
                        Empleado = e.Empleado.Nombre,
                        e.Estado,
                    }).ToList();
                dataGridView1.DataSource = eventosFiltrados;

                // Ocultar Ids
                dataGridView1.Columns["EventoId"].Visible = false;
                dataGridView1.Columns["SalaId"].Visible = false;
                dataGridView1.Columns["ClienteId"].Visible = false;
                dataGridView1.Columns["PaqueteId"].Visible = false;
                dataGridView1.Columns["EmpleadoId"].Visible = false;
            }
        }
    }
}
