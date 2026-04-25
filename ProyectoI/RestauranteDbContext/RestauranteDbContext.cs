using ProyectoI.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ProyectoI.RestauranteDbContext

{
    public class ResturanteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("RestauranteDbTest");
        }
        // DbSet para cada entidad
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Bloqueo> Bloqueos { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet <Mesa> Mesas { get; set; }
        public DbSet<ListaDeEspera> ListaDeEsperas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
