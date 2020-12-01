using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Entidades;


namespace WebApplication1.Data
{

    public class DBCont : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareasDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuario");

            modelBuilder.Entity<Tareas>().ToTable("Tarea");

            modelBuilder.Entity<Recursos>().ToTable("Recurso");

            modelBuilder.Entity<Detalles>().ToTable("Detalle");
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Detalles> Detalles { get; set; }

    }
}