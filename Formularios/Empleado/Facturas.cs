using Eventos.Clases;
using Eventos.Formularios.Administrador;
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

namespace Eventos.Formularios.Empleado
{
    public partial class Facturas : Form
    {
        private List<Facturas> facturas;
        private List<Eventos> eventos;
        private List<Clientes> clientes;

        CRUDFacturas crudFacturas = new CRUDFacturas();

        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            CargarFacturas();
            CargarEventos();
            CargarClientes();
            CargarEstadoFactura();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["FacturaId"].Value.ToString();
                comboEvento.SelectedValue = dataGridView1.CurrentRow.Cells["EventoId"].Value;
                comboCliente.SelectedValue = dataGridView1.CurrentRow.Cells["ClienteId"].Value;
                inputMonto.Text = dataGridView1.CurrentRow.Cells["MontoTotal"].Value.ToString();
                dateFecha.Text = dataGridView1.CurrentRow.Cells["FechaFactura"].Value.ToString();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputMonto.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea crear esta factura?", "Crear Factura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var factura = new Modelos.Factura
                {
                    EventoId = (int)comboEvento.SelectedValue,
                    ClienteId = (int)comboCliente.SelectedValue,
                    MontoTotal = decimal.Parse(inputMonto.Text),
                    FechaFactura = dateFecha.Value,
                    Estado = comboEstado.SelectedValue.ToString()
                };

                crudFacturas.CrearFactura(factura);
                CargarFacturas();
                LimpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputMonto.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea editar esta factura?", "Editar Factura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var factura = new Modelos.Factura
                {
                    FacturaId = int.Parse(txtID.Text),
                    EventoId = (int)comboEvento.SelectedValue,
                    ClienteId = (int)comboCliente.SelectedValue,
                    MontoTotal = decimal.Parse(inputMonto.Text),
                    FechaFactura = dateFecha.Value,
                    Estado = comboEstado.SelectedValue.ToString()
                };

                crudFacturas.ActualizarFactura(factura);
                CargarFacturas();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Por favor, seleccione una factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta factura?", "Eliminar Factura", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var factura = new Modelos.Factura
                {
                    FacturaId = int.Parse(txtID.Text)
                };
                crudFacturas.EliminarFactura(factura);
                CargarFacturas();
                LimpiarCampos();
            }
        }

        private void CargarFacturas()
        {
            using (var contexto = new EventosContext())
            {
                var facturas = contexto.Facturas
                    .Select(f => new
                    {
                        f.FacturaId,
                        Evento = f.Evento.NombreEvento,
                        Cliente = f.Cliente.Nombre,
                        Monto = f.MontoTotal,
                        Facturacion = f.FechaFactura,
                        f.Estado
                    })
                    .ToList();
                dataGridView1.DataSource = facturas;
            }
        }

        private void CargarEventos()
        {
            using (var contexto = new EventosContext())
            {
                var eventos = contexto.Eventos.ToList();
                comboEvento.DataSource = eventos;
                comboEvento.DisplayMember = "NombreEvento";
                comboEvento.ValueMember = "EventoId";
            }
        }

        private void CargarClientes()
        {
            using (var contexto = new EventosContext())
            {
                var clientes = contexto.Clientes.ToList();
                comboCliente.DataSource = clientes;
                comboCliente.DisplayMember = "Nombre";
                comboCliente.ValueMember = "ClienteId";
            }
        }

        private void CargarEstadoFactura()
        {
            var estadoFactura = new List<string>
            {
                "Pendiente",
                "Pagada"
            };
            comboEstado.DataSource = estadoFactura;
        }

        private void LimpiarCampos()
        {
            txtID.Text = "";
            comboEvento.SelectedIndex = 0;
            comboCliente.SelectedIndex = 0;
            inputMonto.Text = "";
            dateFecha.Value = DateTime.Now;
            comboEstado.SelectedIndex = 0;
        }
    }
}
