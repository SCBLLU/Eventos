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
    public partial class Menu : Form
    {
        private int empleadoIdEnSesion;

        public Menu(int empleadoId)
        {
            InitializeComponent();
            empleadoIdEnSesion = empleadoId; // Asignar el ID del empleado en sesión
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void CargarFormularios(Form formulario)
        {
            // Cerrar el formulario anterior si existe
            if (Contenedor.Controls.Count > 0)
            {
                Form formularioAnterior = Contenedor.Controls[0] as Form;
                if (formularioAnterior != null)
                {
                    formularioAnterior.Close();
                }
                Contenedor.Controls.Clear();
            }

            // Configurar y mostrar el nuevo formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(formulario);
            Contenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Eventos(empleadoIdEnSesion)); // envia el id al formulario de eventos
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Clientes());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Facturas());
        }
    }
}
