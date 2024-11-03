using Eventos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = InputUser.Text;
            string contrasena = InputPassword.Text;

            using (var bd = new EventosContext())
            {
                var user = bd.Usuarios
                    .Include(u => u.Empleado)
                    .FirstOrDefault(u => u.NombreUsuario == usuario && u.Contraseña == contrasena);

                if (user != null)
                {
                    if (user.Empleado != null)
                    {
                        if (user.Empleado.Rol == "Administrador")
                        {
                            var adminMenu = new Eventos.Formularios.Administrador.Menu();
                            adminMenu.Show();
                        }
                        else if (user.Empleado.Rol == "Empleado")
                        {
                            var empleadoMenu = new Eventos.Formularios.Empleado.Menu();
                            empleadoMenu.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no tiene un rol asignado.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }
    }
}
