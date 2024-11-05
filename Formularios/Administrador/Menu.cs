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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void btnEventos_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Eventos());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Empleados());
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Salas());
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Paquetes());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Informes());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarFormularios(new Clientes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la sesión y redirigir al formulario de inicio de sesión
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}
