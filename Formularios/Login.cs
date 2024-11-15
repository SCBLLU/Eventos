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
                var user = bd.Empleados
                    .FirstOrDefault(u => u.NombreUsuario == usuario && u.Contraseña == contrasena);

                if (user != null)
                {
                    if (user.Rol == "Administrador")
                    {
                        var adminMenu = new Eventos.Formularios.Administrador.Menu();
                        adminMenu.Show();
                    }
                    else if (user.Rol == "Empleado")
                    {
                        var empleadoMenu = new Eventos.Formularios.Empleado.Menu(user.EmpleadoId);
                        empleadoMenu.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }
    }
}
