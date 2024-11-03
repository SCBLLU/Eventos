using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class AsignacionesEmpleado
{
    public int AsignacionId { get; set; }

    public int? EventoId { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Evento? Evento { get; set; }
}
