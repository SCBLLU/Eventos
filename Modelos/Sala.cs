using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Sala
{
    public int SalaId { get; set; }

    public string NombreSala { get; set; } = null!;

    public int Capacidad { get; set; }

    public string? Ubicacion { get; set; }

    public string? Caracteristicas { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
