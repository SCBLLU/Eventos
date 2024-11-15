using Eventos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDPaquetes
    {
        public void CrearPaquete(Paquete p)
        {
            using (var bd = new EventosContext())
            {
                var paqueteExistente = bd.Paquetes
                    .FirstOrDefault(paquete => paquete.NombrePaquete == p.NombrePaquete);

                if (paqueteExistente != null)
                {
                    throw new InvalidOperationException("Ya existe un paquete con el mismo nombre.");
                }

                bd.Paquetes.Add(p);
                bd.SaveChanges();
            }
        }

        public void EliminarPaquete(Paquete p)
        {
            using (var bd = new EventosContext())
            {
                var paquete = bd.Paquetes.Include(p => p.Eventos).FirstOrDefault(p => p.PaqueteId == p.PaqueteId);
                if (paquete.Eventos.Any())
                {
                    throw new InvalidOperationException("No se puede eliminar este paquete porque que está asociado a un evento.");
                }
                bd.Paquetes.Remove(paquete);
                bd.SaveChanges();
            }
        }

        public void ActualizarPaquete(Paquete p)
        {
            using (var bd = new EventosContext())
            {
                var paquete = bd.Paquetes.Find(p.PaqueteId);
                paquete.NombrePaquete = p.NombrePaquete;
                paquete.Descripcion = p.Descripcion;
                paquete.Articulos = p.Articulos;
                bd.SaveChanges();
            }
        }
    }
}
