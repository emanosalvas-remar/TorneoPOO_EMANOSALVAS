using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoPOO_EMANOSALVAS.Datos
{
    public class TorneoDbContext : DbContext
    {

        //1er paso DbSet para cada clase que se quiera mapear a la base de datos
        public DbSet<Models.Equipo> Equipos { get; set; }
        public DbSet<Models.Jugador> Jugadores { get; set; }
        public DbSet<Models.Partido> Partidos { get; set; }

        //2do paso Configurar la cadena de conexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //CADENA CONEXION USUARIO SQL SERVER
            optionsBuilder.UseSqlServer("Server=LT-EMANOSALVAS;Database=TORNEO_EMANOSALVAS;User Id=sa;Password=R3pr3s3ntac10n3s.2024;TrustServerCertificate=True;");
            //CADENA CONEXION USUARIO WINDOWS
            //optionsBuilder.UseSqlServer("Server=LT-EMANOSALVAS;Database=TORNEO_EMANOSALVAS;Trusted_Connection=True;");
        }

        //3er paso Configurar las relaciones entre las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion 1 a muchos entre Equipo y Jugador
            modelBuilder.Entity<Models.Equipo>()
                .HasMany(e => e.Jugadores)
                .WithOne()
                .HasForeignKey(j => j.EquipoId)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacion 1 a muchos entre Partido y Equipo (local y visitante)
            modelBuilder.Entity<Models.Partido>()
                .HasOne(p => p.Local)
                .WithMany()
                .HasForeignKey(p => p.LocalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Models.Partido>()
                .HasOne(p => p.Visitante)
                .WithMany()
                .HasForeignKey(p => p.VisitanteId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
