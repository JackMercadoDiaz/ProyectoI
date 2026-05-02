using Microsoft.EntityFrameworkCore;
using ProyectoI.Entidades;
using System.Data;
namespace ProyectoI.RestauranteDbContext;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Horario>().HasData(
            new Horario { Id = 1, Nombre = "Almuerzo", DiaSemana = "Lunes a Viernes", HoraInicio = new TimeOnly(12, 0), HoraFin = new TimeOnly(15, 0) },
            new Horario { Id = 2, Nombre = "Cena", DiaSemana = "Lunes a Domingo", HoraInicio = new TimeOnly(18, 0), HoraFin = new TimeOnly(23, 0) }
        );

        modelBuilder.Entity<Seccion>().HasData(
            new Seccion { Id = 1, Nombre = "Planta Alta" },
            new Seccion { Id = 2, Nombre = "Planta Baja" }
        );

        modelBuilder.Entity<Zona>().HasData(
            new Zona { Id = 1, Nombre = "Zona Interior", SeccionId = 1 },
            new Zona { Id = 2, Nombre = "Zona Exterior", SeccionId = 1 },
            new Zona { Id = 3, Nombre = "Zona VIP", SeccionId = 2 }
        );

        modelBuilder.Entity<Mesa>().HasData(
            new Mesa { Id = 1, ZonaId = 1, NumMesa = 1, Capacidad = 4, Estado = "Disponible" },
            new Mesa { Id = 2, ZonaId = 1, NumMesa = 2, Capacidad = 7, Estado = "Disponible" },
            new Mesa { Id = 3, ZonaId = 2, NumMesa = 3, Capacidad = 6, Estado = "Disponible" },
            new Mesa { Id = 4, ZonaId = 2, NumMesa = 4, Capacidad = 3, Estado = "Disponible" },
            new Mesa { Id = 5, ZonaId = 1, NumMesa = 5, Capacidad = 5, Estado = "Disponible" },
            new Mesa { Id = 6, ZonaId = 1, NumMesa = 6, Capacidad = 4, Estado = "Disponible" },
            new Mesa { Id = 7, ZonaId = 2, NumMesa = 7, Capacidad = 16, Estado = "Disponible" },
            new Mesa { Id = 8, ZonaId = 3, NumMesa = 8, Capacidad = 4, Estado = "Disponible" }
        );

        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { Id = 1, Nombre = "Juan", Telefono = "123456789", CorreoElectronico = "juan@example.com" },
            new Cliente { Id = 2, Nombre = "María", Telefono = "987654321", CorreoElectronico = "maria@example.com" },
            new Cliente { Id = 3, Nombre = "Carlos", Telefono = "456789123", CorreoElectronico = "carlos@example.com" },
            new Cliente { Id = 4, Nombre = "Ana", Telefono = "321654987", CorreoElectronico = "ana@example.com" },
            new Cliente { Id = 5, Nombre = "Luis", Telefono = "654987321", CorreoElectronico = "luis@example.com" }
        );

        modelBuilder.Entity<Reserva>().HasData(
            new Reserva { Id = 1, ClienteId = 1, MesaId = 1, HorarioId = 1, NumPersonas = 4, Fecha = DateTime.Today.AddDays(1), Estado = "Activa" },
            new Reserva { Id = 2, ClienteId = 2, MesaId = 2, HorarioId = 2, NumPersonas = 2, Fecha = DateTime.Today.AddDays(2), Estado = "Activa" },
            new Reserva { Id = 3, ClienteId = 3, MesaId = 3, HorarioId = 1, NumPersonas = 6, Fecha = DateTime.Today.AddDays(3), Estado = "Activa" },
            new Reserva { Id = 4, ClienteId = 4, MesaId = 4, HorarioId = 2, NumPersonas = 3, Fecha = DateTime.Today.AddDays(4), Estado = "Activa" },
            new Reserva { Id = 5, ClienteId = 5, MesaId = 5, HorarioId = 1, NumPersonas = 5, Fecha = DateTime.Today.AddDays(5), Estado = "Activa" }
        );

        modelBuilder.Entity<Bloqueo>().HasData(
            new Bloqueo { Id = 1, MesaId = 1, ZonaId = null, FechaInicio = DateTime.Today.AddDays(1), FechaFin = DateTime.Today.AddDays(2), Estado = "Activo", Motivo = "Mantenimiento" },
        new Bloqueo { Id = 2, MesaId = 2, ZonaId = null, FechaInicio = DateTime.Today.AddDays(3), FechaFin = DateTime.Today.AddDays(4), Estado = "Activo", Motivo = "Evento Privado" },
        new Bloqueo { Id = 3, MesaId = null, ZonaId = 2, FechaInicio = DateTime.Today.AddDays(5), FechaFin = DateTime.Today.AddDays(6), Estado = "Activo", Motivo = "Mantenimiento" }
        );

        modelBuilder.Entity<ListaDeEspera>().HasData(
            new ListaDeEspera { Id = 1, ClienteId = 1, HorarioId = 1, ZonaId = 1, NumPersonas = 4, Fecha = DateTime.Today.AddDays(1), Estado = "Pendiente" },
            new ListaDeEspera { Id = 2, ClienteId = 2, HorarioId = 2, ZonaId = 1, NumPersonas = 2, Fecha = DateTime.Today.AddDays(2), Estado = "Pendiente" },
            new ListaDeEspera { Id = 3, ClienteId = 3, HorarioId = 1, ZonaId = 2, NumPersonas = 6, Fecha = DateTime.Today.AddDays(3), Estado = "Pendiente" }
        );

    }

}
   
