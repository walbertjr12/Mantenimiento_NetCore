using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mantenimiento_Api.EntityModels
{
    public partial class MantenimientoContext : DbContext
    {
        public MantenimientoContext()
        {
        }

        public MantenimientoContext(DbContextOptions<MantenimientoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CrudBase> CrudBases { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-A3FADA4F\\SQLEXPRESS;Database=Mantenimiento;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<CrudBase>(entity =>
            {
                entity.ToTable("crud_base");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcioncorta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcioncorta");

                entity.Property(e => e.Descripcionlarga)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionlarga");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion");

                entity.Property(e => e.Fechamodificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamodificacion");

                entity.Property(e => e.Usuariocreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomodificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomodificacion");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcioncorta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcioncorta");

                entity.Property(e => e.Descripcionlarga)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionlarga");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechacreacion");

                entity.Property(e => e.Fechamodificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechamodificacion");

                entity.Property(e => e.Usuariocreacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariocreacion");

                entity.Property(e => e.Usuariomodificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuariomodificacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
