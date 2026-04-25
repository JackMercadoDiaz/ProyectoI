using ProyectoI.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ProyectoI.RestauranteDbContext

{
    public class ResturanteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ResturanteDbTest");
        }
        // DbSet para cada entidad
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
    }
}
