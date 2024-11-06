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

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Eventos;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0A7B5097FA5");

            entity.HasIndex(e => e.Email, "UQ__Clientes__A9D1053437B1A4E5").IsUnique();

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__958BE6F0FC32415C");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Empleado__6B0F5AE065753194").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Empleado__A9D105344C57FE81").IsUnique();

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventoId).HasName("PK__Eventos__1EEB59011B0F6BF7");

            entity.HasIndex(e => e.NombreEvento, "UQ__Eventos__FB7DE1C1222C9642").IsUnique();

            entity.Property(e => e.EventoId).HasColumnName("EventoID");
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.NombreEvento).HasMaxLength(100);
            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.SalaId).HasColumnName("SalaID");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Eventos__Cliente__48CFD27E");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Eventos__Emplead__4AB81AF0");

            entity.HasOne(d => d.Paquete).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.PaqueteId)
                .HasConstraintName("FK__Eventos__Paquete__49C3F6B7");

            entity.HasOne(d => d.Sala).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.SalaId)
                .HasConstraintName("FK__Eventos__SalaID__47DBAE45");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__Facturas__5C024805008F35B2");

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
                .HasConstraintName("FK__Facturas__Client__5165187F");

            entity.HasOne(d => d.Evento).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Facturas__Evento__5070F446");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.PaqueteId).HasName("PK__Paquetes__7B9F2DD2DA4DE14C");

            entity.HasIndex(e => e.NombrePaquete, "UQ__Paquetes__C97A4BE6FB187562").IsUnique();

            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.NombrePaquete).HasMaxLength(100);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.SalaId).HasName("PK__Salas__0428485ADCDB7716");

            entity.HasIndex(e => e.NombreSala, "UQ__Salas__1399C32B08CDB55B").IsUnique();

            entity.Property(e => e.SalaId).HasColumnName("SalaID");
            entity.Property(e => e.NombreSala).HasMaxLength(100);
            entity.Property(e => e.Ubicacion).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
