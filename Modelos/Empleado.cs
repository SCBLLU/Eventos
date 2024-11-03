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

    public virtual ICollection<AsignacionesEmpleado> AsignacionesEmpleados { get; set; } = new List<AsignacionesEmpleado>();

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
