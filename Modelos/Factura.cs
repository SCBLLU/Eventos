using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int? EventoId { get; set; }

    public int? ClienteId { get; set; }

    public DateTime? FechaFactura { get; set; }

    public decimal MontoTotal { get; set; }

    public string? Estado { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Evento? Evento { get; set; }
}
