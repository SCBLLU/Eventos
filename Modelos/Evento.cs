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

    public int? ClienteId { get; set; }

    public int? PaqueteId { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Estado { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Paquete? Paquete { get; set; }

    public virtual Sala? Sala { get; set; }
}
