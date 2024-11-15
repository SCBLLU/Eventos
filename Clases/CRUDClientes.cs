using Eventos.Modelos;
using Microsoft.EntityFrameworkCore;
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
                var clienteExistente = bd.Clientes.SingleOrDefault(cliente => cliente.Email == c.Email);
                if (clienteExistente != null)
                {
                    throw new InvalidOperationException("Ya existe un cliente con este correo electrónico.");
                }

                bd.Clientes.Add(c);
                bd.SaveChanges();
            }
        }

        public void EliminarCliente(Cliente c)
        {
            using (var bd = new EventosContext())
            {
                var cliente = bd.Clientes.Include(cl => cl.Eventos).FirstOrDefault(cl => cl.ClienteId == c.ClienteId);

                if (cliente.Eventos.Any())
                {
                    throw new Exception("No se puede eliminar el cliente porque está asociado a uno o más eventos.");
                }

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
