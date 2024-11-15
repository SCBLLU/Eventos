using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDEmpleados
    {
        public void CrearEmpleado(Empleado e)
        {
            using (var bd = new EventosContext())
            {
                var existingEmpleadoByUsername = bd.Empleados.FirstOrDefault(emp => emp.NombreUsuario == e.NombreUsuario);
                if (existingEmpleadoByUsername != null)
                {
                    throw new InvalidOperationException("El nombre de usuario ya existe. Por favor, elija otro.");
                }

                var existingEmpleadoByEmail = bd.Empleados.FirstOrDefault(emp => emp.Email == e.Email);
                if (existingEmpleadoByEmail != null)
                {
                    throw new InvalidOperationException("El correo electrónico ya existe. Por favor, elija otro.");
                }

                bd.Empleados.Add(e);
                bd.SaveChanges();
            }
        }

        public void EliminarEmpleado(Empleado e)
        {
            using (var bd = new EventosContext())
            {
                var empleado = bd.Empleados.Find(e.EmpleadoId);
                if (bd.Eventos.Any(ev => ev.EmpleadoId == e.EmpleadoId))
                {
                    throw new InvalidOperationException("El empleado tiene eventos asignados. Elimine los eventos antes de eliminar al empleado.");
                }
                bd.Empleados.Remove(empleado);
                bd.SaveChanges();
            }
        }

        public void ActualizarEmpleado(Empleado e)
        {
            using (var bd = new EventosContext())
            {
                var empleado = bd.Empleados.Find(e.EmpleadoId);
                empleado.Nombre = e.Nombre;
                empleado.Apellido = e.Apellido;
                empleado.Rol = e.Rol;
                empleado.Email = e.Email;
                empleado.Telefono = e.Telefono;
                empleado.NombreUsuario = e.NombreUsuario;
                empleado.Contraseña = e.Contraseña;
                bd.SaveChanges();
            }
        }
    }
}
