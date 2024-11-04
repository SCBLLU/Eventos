using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Paquete
{
    public int PaqueteId { get; set; }

    public string NombrePaquete { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Articulos { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
