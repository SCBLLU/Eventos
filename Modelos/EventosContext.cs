using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Modelos;

public partial class EventosContext : DbContext
{
    public EventosContext()
    {
    }

    public EventosContext(DbContextOptions<EventosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsignacionesEmpleado> AsignacionesEmpleados { get; set; }

    public virtual DbSet<DetallesPaquete> DetallesPaquetes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Eventos;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AsignacionesEmpleado>(entity =>
        {
            entity.HasKey(e => e.AsignacionId).HasName("PK__Asignaci__D82B5BB745EE65B0");

            entity.Property(e => e.AsignacionId).HasColumnName("AsignacionID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.EventoId).HasColumnName("EventoID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.AsignacionesEmpleados)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Asignacio__Emple__5070F446");

            entity.HasOne(d => d.Evento).WithMany(p => p.AsignacionesEmpleados)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Asignacio__Event__4F7CD00D");
        });

        modelBuilder.Entity<DetallesPaquete>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FAE8D5409B");

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.Articulo).HasMaxLength(100);
            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");

            entity.HasOne(d => d.Paquete).WithMany(p => p.DetallesPaquetes)
                .HasForeignKey(d => d.PaqueteId)
                .HasConstraintName("FK__DetallesP__Paque__46E78A0C");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE6F04E9448C8");

            entity.HasIndex(e => e.Email, "UQ__Empleado__A9D105349D293F60").IsUnique();

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventoId).HasName("PK__Eventos__1EEB5901D42405FC");

            entity.HasIndex(e => e.NombreEvento, "UQ__Eventos__FB7DE1C189188B01").IsUnique();

            entity.Property(e => e.EventoId).HasColumnName("EventoID");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.NombreEvento).HasMaxLength(100);
            entity.Property(e => e.SalaId).HasColumnName("SalaID");

            entity.HasOne(d => d.Sala).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.SalaId)
                .HasConstraintName("FK__Eventos__SalaID__4BAC3F29");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.PaqueteId).HasName("PK__Paquetes__7B9F2DD2B3299030");

            entity.HasIndex(e => e.NombrePaquete, "UQ__Paquetes__C97A4BE6FCAD8747").IsUnique();

            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.NombrePaquete).HasMaxLength(100);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.SalaId).HasName("PK__Salas__0428485A27E1EE67");

            entity.HasIndex(e => e.NombreSala, "UQ__Salas__1399C32BCFD1B0FE").IsUnique();

            entity.Property(e => e.SalaId).HasColumnName("SalaID");
            entity.Property(e => e.NombreSala).HasMaxLength(100);
            entity.Property(e => e.Ubicacion).HasMaxLength(200);
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.TareaId).HasName("PK__Tareas__5CD83671C3188B3C");

            entity.Property(e => e.TareaId).HasColumnName("TareaID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.EventoId).HasColumnName("EventoID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Tareas__Empleado__5441852A");

            entity.HasOne(d => d.Evento).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Tareas__EventoID__534D60F1");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798EB88DD23");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuarios__6B0F5AE0D44E30CB").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Usuarios__Emplea__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
