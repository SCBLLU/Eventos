using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Tarea
{
    public int TareaId { get; set; }

    public int? EventoId { get; set; }

    public int? EmpleadoId { get; set; }

    public string DescripcionTarea { get; set; } = null!;

    public string? Estado { get; set; }

    public string? Comentarios { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual Evento? Evento { get; set; }
}
