using System;
using System.Collections.Generic;

namespace Eventos.Modelos;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }
}
