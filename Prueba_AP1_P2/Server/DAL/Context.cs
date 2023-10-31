using Microsoft.EntityFrameworkCore;
using Prueba_AP1_P2.Shared.Models;

namespace Prueba_AP1_P2.Server.DAL
{
    public class Context: DbContext
    {
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<EntredasDetalle> EntredasDetalles { get; set; }
        public Context(DbContextOptions<Context> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                new Productos() { ProductoId = 1, Descripcion = "Maní", Existencia = 40, Tipo = 0 },
                new Productos() { ProductoId = 2, Descripcion = "Pistachos", Existencia = 600, Tipo = 0 },
                new Productos() { ProductoId = 3, Descripcion = "Pasas", Existencia = 500, Tipo = 0 },
                new Productos() { ProductoId = 4, Descripcion = "Ciruelas", Existencia = 700, Tipo = 0 },
                new Productos() { ProductoId = 5, Descripcion = "Mixto MPP 0.5lb", Existencia = 0, Tipo = 1 },
                new Productos() { ProductoId = 6, Descripcion = "Mixto MPC 0.5lb", Existencia = 0, Tipo = 1 },
                new Productos() { ProductoId = 7, Descripcion = "Mixto MPP 0.2lb", Existencia = 0, Tipo = 1 }
            });
        }
    }
}
