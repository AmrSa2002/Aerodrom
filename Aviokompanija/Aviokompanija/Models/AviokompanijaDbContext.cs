using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aviokompanija.Models
{
    public class AviokompanijaDbContext : DbContext
    {
        public AviokompanijaDbContext(DbContextOptions<AviokompanijaDbContext> options) : base(options)
        {

        }

        public DbSet<Avion> Avion { get; set; }
        public DbSet<Destinacija> Destinacija { get; set; }
        public DbSet<Karta> Karta { get; set; }
        public DbSet<Let> Let { get; set; }
        public DbSet<Putnik> Putnik { get; set; }
        public DbSet<Radnik> Radnik { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>().ToTable("Automobil");
            modelBuilder.Entity<Destinacija>().ToTable("Destinacija");
            modelBuilder.Entity<Karta>().ToTable("Karta");
            modelBuilder.Entity<Let>().ToTable("Let");
            modelBuilder.Entity<Putnik>().ToTable("Putnik");
            modelBuilder.Entity<Radnik>().ToTable("Radnik");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
        }

    }
}
