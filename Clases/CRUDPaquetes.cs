using Eventos.Modelos;
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
                bd.Paquetes.Add(p);
                bd.SaveChanges();
            }
        }

        public void EliminarPaquete(Paquete p)
        {
            using (var bd = new EventosContext())
            {
                var paquete = bd.Paquetes.Find(p.PaqueteId);
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
