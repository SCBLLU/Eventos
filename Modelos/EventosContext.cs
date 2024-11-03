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

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetallesPaquete> DetallesPaquetes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

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
            entity.HasKey(e => e.AsignacionId).HasName("PK__Asignaci__D82B5BB756DC8F22");

            entity.Property(e => e.AsignacionId).HasColumnName("AsignacionID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.EventoId).HasColumnName("EventoID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.AsignacionesEmpleados)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Asignacio__Emple__5441852A");

            entity.HasOne(d => d.Evento).WithMany(p => p.AsignacionesEmpleados)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Asignacio__Event__534D60F1");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0A7C08FCA21");

            entity.HasIndex(e => e.Email, "UQ__Clientes__A9D10534BE0ADB8D").IsUnique();

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<DetallesPaquete>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FAE319B87E");

            entity.Property(e => e.DetalleId).HasColumnName("DetalleID");
            entity.Property(e => e.Articulo).HasMaxLength(100);
            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");

            entity.HasOne(d => d.Paquete).WithMany(p => p.DetallesPaquetes)
                .HasForeignKey(d => d.PaqueteId)
                .HasConstraintName("FK__DetallesP__Paque__46E78A0C");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE6F0FDF6500D");

            entity.HasIndex(e => e.Email, "UQ__Empleado__A9D105348524063C").IsUnique();

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventoId).HasName("PK__Eventos__1EEB5901D1E6AF69");

            entity.HasIndex(e => e.NombreEvento, "UQ__Eventos__FB7DE1C1CF0AA27C").IsUnique();

            entity.Property(e => e.EventoId).HasColumnName("EventoID");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.NombreEvento).HasMaxLength(100);
            entity.Property(e => e.SalaId).HasColumnName("SalaID");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Eventos__Cliente__4F7CD00D");

            entity.HasOne(d => d.Sala).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.SalaId)
                .HasConstraintName("FK__Eventos__SalaID__4E88ABD4");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__Facturas__5C024805EE79AAAC");

            entity.Property(e => e.FacturaId).HasColumnName("FacturaID");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.EventoId).HasColumnName("EventoID");
            entity.Property(e => e.FechaFactura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MontoTotal).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Facturas__Client__5DCAEF64");

            entity.HasOne(d => d.Evento).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Facturas__Evento__5CD6CB2B");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.PaqueteId).HasName("PK__Paquetes__7B9F2DD25077FF21");

            entity.HasIndex(e => e.NombrePaquete, "UQ__Paquetes__C97A4BE68EC941B7").IsUnique();

            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.NombrePaquete).HasMaxLength(100);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.SalaId).HasName("PK__Salas__0428485A666E4623");

            entity.HasIndex(e => e.NombreSala, "UQ__Salas__1399C32B0D67482A").IsUnique();

            entity.Property(e => e.SalaId).HasColumnName("SalaID");
            entity.Property(e => e.NombreSala).HasMaxLength(100);
            entity.Property(e => e.Ubicacion).HasMaxLength(200);
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.TareaId).HasName("PK__Tareas__5CD83671DA991FF9");

            entity.Property(e => e.TareaId).HasColumnName("TareaID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.EventoId).HasColumnName("EventoID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Tareas__Empleado__5812160E");

            entity.HasOne(d => d.Evento).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Tareas__EventoID__571DF1D5");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE7980713FAB0");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuarios__6B0F5AE05AE28306").IsUnique();

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
