using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDEventos
    {
        public void CrearEvento(Evento e)
        {
            using (var bd = new EventosContext())
            {
                if (bd.Eventos.Any(ev => ev.NombreEvento == e.NombreEvento))
                {
                    throw new InvalidOperationException("Ya existe un evento con este nombre.");
                }

                if (e.FechaFin < e.FechaInicio)
                {
                    throw new InvalidOperationException("La fecha de fin debe ser mayor o igual a la fecha de inicio.");
                }

                bd.Eventos.Add(e);
                bd.SaveChanges();
            }
        }

        public void EliminarEvento(Evento e)
        {
            using (var bd = new EventosContext())
            {
                var evento = bd.Eventos.Find(e.EventoId);
                bd.Eventos.Remove(evento);
                bd.SaveChanges();
            }
        }

        public void ActualizarEvento(Evento e)
        {
            using (var bd = new EventosContext())
            {
                var evento = bd.Eventos.Find(e.EventoId);
                evento.NombreEvento = e.NombreEvento;
                evento.FechaInicio = e.FechaInicio;
                evento.FechaFin = e.FechaFin;
                evento.Descripcion = e.Descripcion;
                evento.SalaId = e.SalaId;
                evento.ClienteId = e.ClienteId;
                evento.PaqueteId = e.PaqueteId;
                evento.EmpleadoId = e.EmpleadoId;
                evento.Estado = e.Estado;
                bd.SaveChanges();
            }
        }
    }
}
