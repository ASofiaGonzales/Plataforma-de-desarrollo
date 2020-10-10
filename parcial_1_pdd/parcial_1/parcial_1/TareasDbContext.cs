using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace parcial_1
{
    public class TareasDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Usuarios
            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")
                .HasKey(p => p.IdUsuario);

            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")
                .Property(p => p.IdUsuario)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("ID Usuario");

            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")
                .Property(p => p.Usuario)
                .HasColumnType("varchar(30)")
                .IsRequired()
                .HasColumnName("Usuario");

            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")                 
                .Property(p => p.Clave)
                .HasColumnType("varchar(30)")
                .IsRequired()
                .HasColumnName("Clave");

            //Recursos
            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos")
                .HasKey(p => p.IdRecursos);

            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos")
                .Property(p => p.IdRecursos)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("ID Recurso");

            modelBuilder.Entity<Recursos>()
                .ToTable("Nombre")
                .Property(p => p.Nombre)
                .HasColumnType("varchar(30)")
                .IsRequired()
                .HasColumnName("Nombre");

            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos")
                .Property(p => p.Usuario)
                .HasColumnType("varchar(30)")
                .IsRequired()
                .HasColumnName("Usuarios");

            //Detalles
            modelBuilder.Entity<Detalles>()
                    .ToTable("Detalles")
                    .HasKey(p => p.IdDetalles);

            modelBuilder.Entity<Detalles>()
                   .ToTable("Detalles")
                   .Property(p => p.IdDetalles)
                   .HasColumnType("int")
                   .IsRequired()
                   .HasColumnName("Id Detalles");

            modelBuilder.Entity<Detalles>()
                    .ToTable("Detalles")
                    .Property(p => p.Fecha)
                    .HasColumnType("DateTime")
                    .IsRequired()
                    .HasColumnName("Fecha");

            modelBuilder.Entity<Detalles>()
                   .ToTable("Detalles")
                   .Property(p => p.Tiempo)
                   .HasColumnType("int")
                   .IsRequired()
                   .HasColumnName("Tiempo");
            
            //Tareas
            modelBuilder.Entity<Tareas>()
                .ToTable("Tareas")
                .HasKey(p => p.IdTareas);

            modelBuilder.Entity<Tareas>()
                .ToTable("Tareas")
                .Property(p => p.IdTareas)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasColumnName("ID Tarea");

            modelBuilder.Entity<Tareas>()
                   .ToTable("Tareas")
                   .Property(p => p.Titulo)
                   .HasColumnType("varchar(100)")
                   .IsRequired()
                   .HasColumnName("Titulo");

            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.Vencimiento)
                    .HasColumnType("DateTime")
                    .IsRequired()
                    .HasColumnName("Vencimiento");

            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.Estimacion)
                    .HasColumnType("int")
                    .IsRequired()
                    .HasColumnName("Estimacion");
            
            modelBuilder.Entity<Tareas>()
                    .ToTable("Tareas")
                    .Property(p => p.Estado)
                    .HasColumnType("varchar(100)")
                    .IsRequired()
                    .HasColumnName("Estado");
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
    }
}
