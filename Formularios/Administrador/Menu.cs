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
            MiDiseño();
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

        // Método para inicializar el diseño del formulario
        private void MiDiseño()
        {
            panelsubmenureportes.Visible = false;
        }

        // Método para ocultar el submenú
        private void hideSubMenu(Panel submenu)
        {
            if (panelsubmenureportes.Visible == true)
                panelsubmenureportes.Visible = false;
        }

        // Método para mostrar el submenú
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Evento click para el botón de reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubmenureportes);
        }

        // Eventos click para los reportes
        private void repoEventos_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de reportes de eventos
            hideSubMenu(panelsubmenureportes);
        }

        private void repoEmpleados_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de reportes de empleados
            hideSubMenu(panelsubmenureportes);
        }

        private void repoSalas_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de reportes de salas
            hideSubMenu(panelsubmenureportes);
        }

        private void repoPaquetes_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de reportes de paquetes
            hideSubMenu(panelsubmenureportes);
        }

        private void repoClientes_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de reportes de clientes
            hideSubMenu(panelsubmenureportes);
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
