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
                bd.SaveChanges();
            }
        }
    }
}
