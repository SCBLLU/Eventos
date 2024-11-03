using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class DetallesPaquete
{
    public int DetalleId { get; set; }

    public int? PaqueteId { get; set; }

    public string Articulo { get; set; } = null!;

    public int Cantidad { get; set; }

    public virtual Paquete? Paquete { get; set; }
}
