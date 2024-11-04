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
                bd.Empleados.Add(e);
                bd.SaveChanges();
            }
        }

        public void EliminarEmpleado(Empleado e)
        {
            using (var bd = new EventosContext())
            {
                var empleado = bd.Empleados.Find(e.EmpleadoId);
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
                empleado.Telefono = e.Telefono;
                empleado.Email = e.Email;
                bd.SaveChanges();
            }
        }
    }
}
