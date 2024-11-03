using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int? EmpleadoId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public virtual Empleado? Empleado { get; set; }
}
