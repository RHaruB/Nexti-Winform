using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nexti_Winform.Models;

public partial class NextiContext : DbContext
{
    public NextiContext()
    {
    }

    public NextiContext(DbContextOptions<NextiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Informacion> Informacions { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RH;Database=NEXTI;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC277638E08A");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.Correo).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Informacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Informacion");

            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Persona");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
