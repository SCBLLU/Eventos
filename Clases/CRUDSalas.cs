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
                var salaExistente = bd.Salas.FirstOrDefault(sala => sala.NombreSala == s.NombreSala);
                if (salaExistente != null)
                {
                    throw new InvalidOperationException("Ya existe una sala con el mismo nombre.");
                }
                if (s.Capacidad <= 0)
                {
                    throw new InvalidOperationException("La capacidad debe ser mayor que cero.");
                }
                bd.Salas.Add(s);
                bd.SaveChanges();
            }
        }

        public void EliminarSala(Sala s)
        {
            using (var bd = new EventosContext())
            {
                var eventosRelacionados = bd.Eventos.Where(e => e.SalaId == s.SalaId).ToList();
                if (eventosRelacionados.Any())
                {
                    throw new InvalidOperationException("No se puede eliminar la sala porque hay eventos relacionados.");
                }
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
