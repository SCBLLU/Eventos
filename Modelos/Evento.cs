using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Evento
{
    public int EventoId { get; set; }

    public string NombreEvento { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Descripcion { get; set; }

    public int? SalaId { get; set; }

    public virtual ICollection<AsignacionesEmpleado> AsignacionesEmpleados { get; set; } = new List<AsignacionesEmpleado>();

    public virtual Sala? Sala { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
