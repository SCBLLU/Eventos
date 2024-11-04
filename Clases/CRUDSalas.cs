using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDSalas
    {
        public void CrearSala(Sala s)
        {
            using (var bd = new EventosContext())
            {
                bd.Salas.Add(s);
                bd.SaveChanges();
            }
        }

        public void EliminarSala(Sala s)
        {
            using (var bd = new EventosContext())
            {
                var eventosRelacionados = bd.Eventos.Where(e => e.SalaId == s.SalaId).ToList();
                bd.Eventos.RemoveRange(eventosRelacionados);
                bd.Salas.Remove(s);
                bd.SaveChanges();
            }
        }

        public void ActualizarSala(Sala s)
        {
            using (var bd = new EventosContext())
            {
                var sala = bd.Salas.Find(s.SalaId);
                sala.NombreSala = s.NombreSala;
                sala.Capacidad = s.Capacidad;
                sala.Ubicacion = s.Ubicacion;
                sala.Caracteristicas = s.Caracteristicas;
                bd.SaveChanges();
            }
        }
    }
}
