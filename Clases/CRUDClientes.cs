using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDClientes
    {
        public void CrearCliente(Cliente c)
        {
            using (var bd = new EventosContext())
            {
                bd.Clientes.Add(c);
                bd.SaveChanges();
            }
        }

        public void EliminarCliente(Cliente c)
        {
            using (var bd = new EventosContext())
            {
                var cliente = bd.Clientes.Find(c.ClienteId);
                bd.Clientes.Remove(cliente);
                bd.SaveChanges();
            }
        }

        public void ActualizarCliente(Cliente c)
        {
            using (var bd = new EventosContext())
            {
                var cliente = bd.Clientes.Find(c.ClienteId);
                cliente.Nombre = c.Nombre;
                cliente.Apellido = c.Apellido;
                cliente.Email = c.Email;
                cliente.Telefono = c.Telefono;
                cliente.Direccion = c.Direccion;
                bd.SaveChanges();
            }
        }
    }
}
