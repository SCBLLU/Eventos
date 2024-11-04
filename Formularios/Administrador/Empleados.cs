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
    public partial class Empleados : Form
    {

        private List<Empleados> empleado;
        CRUDEmpleados crudEmpleados = new CRUDEmpleados();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarRoles();
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(cmbRol.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea crear este empleado?", "Crear Empleado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var empleado = new Modelos.Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Rol = cmbRol.Text,
                    Email = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                };

                crudEmpleados.CrearEmpleado(empleado);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea editar este empleado?", "Editar Empleado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var empleado = new Modelos.Empleado
                {
                    EmpleadoId = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Rol = cmbRol.Text,
                    Email = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                };

                crudEmpleados.ActualizarEmpleado(empleado);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var empleado = new Modelos.Empleado
                {
                    EmpleadoId = int.Parse(txtID.Text)
                };

                crudEmpleados.EliminarEmpleado(empleado);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                cmbRol.Text = dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtID.Text = dataGridView1.CurrentRow.Cells["EmpleadoId"].Value.ToString();
            }
        }

        private void CargarEmpleados()
        {
            using (var context = new EventosContext())
            {
                var empleados = context.Empleados.ToList();
                dataGridView1.DataSource = empleados;
                dataGridView1.Columns["AsignacionesEmpleados"].Visible = false;
                dataGridView1.Columns["Tareas"].Visible = false;
                dataGridView1.Columns["Usuarios"].Visible = false;
            }
        }

        private void CargarRoles()
        {
            using (var context = new EventosContext())
            {
                // Obtener los roles únicos de los empleados
                var roles = context.Empleados
                                   .Select(e => e.Rol)
                                   .Distinct()
                                   .ToList();

                // Asignar los roles al ComboBox
                cmbRol.DataSource = roles;
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbRol.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtID.Text = "";
        }
    }
}
