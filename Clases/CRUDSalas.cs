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
                bd.Salas.Remove(s);
                bd.SaveChanges();
            }
        }

        public Sala ObtenerSalaPorId(int salaId)
        {
            using (var bd = new EventosContext())
            {
                return bd.Salas.FirstOrDefault(s => s.SalaId == salaId);
            }
        }

        public List<Sala> ObtenerTodasLasSalas()
        {
            using (var bd = new EventosContext())
            {
                return bd.Salas.ToList();
            }
        }
    }
}
