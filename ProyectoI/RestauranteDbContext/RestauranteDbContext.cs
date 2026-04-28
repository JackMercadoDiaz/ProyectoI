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
            new Horario { HorarioId = 1, Nombre = "Horario de Almuerzo", DiaSemana = "Lunes a Viernes", HoraInicio = new TimeOnly(12, 0), HoraFin = new TimeOnly(15, 0) },
            new Horario { HorarioId = 2, Nombre = "Horario de Cena", DiaSemana = "Lunes a Domingo", HoraInicio = new TimeOnly(18, 0), HoraFin = new TimeOnly(23, 0) }
        );

        modelBuilder.Entity<Reserva>().HasData(
           new Reserva { ReservaId = 1, ClienteId = 1, MesaId = 1, HorarioId = 1, NumPersonas = 4, Fecha = DateTime.Today.AddDays(1), EstadoId = 1 },
           new Reserva { ReservaId = 2, ClienteId = 2, MesaId = 2, HorarioId = 2, NumPersonas = 2, Fecha = DateTime.Today.AddDays(2), EstadoId = 1 },
           new Reserva { ReservaId = 3, ClienteId = 3, MesaId = 3, HorarioId = 1, NumPersonas = 6, Fecha = DateTime.Today.AddDays(3), EstadoId = 1 },
           new Reserva { ReservaId = 4, ClienteId = 4, MesaId = 4, HorarioId = 2, NumPersonas = 3, Fecha = DateTime.Today.AddDays(4), EstadoId = 1 },
           new Reserva { ReservaId = 5, ClienteId = 5, MesaId = 5, HorarioId = 1, NumPersonas = 5, Fecha = DateTime.Today.AddDays(5), EstadoId = 1 }
        );

        modelBuilder.Entity<Seccion>().HasData(
            new Seccion { SeccionId = 1, Nombre = "Sección A" },
            new Seccion { SeccionId = 2, Nombre = "Sección B" }
        );

        modelBuilder.Entity<Bloqueo>().HasData(
            new Bloqueo { BloqueoId = 1, ZonaId = 1, MesaId = 1, FechaInicio = DateTime.Today.AddDays(1), FechaFin = DateTime.Today.AddDays(2), EstadoId = 1, Motivo = "Mantenimiento" },
            new Bloqueo { BloqueoId = 2, ZonaId = 1, MesaId = 2, FechaInicio = DateTime.Today.AddDays(3), FechaFin = DateTime.Today.AddDays(4), EstadoId = 1, Motivo = "Evento Privado" },
            new Bloqueo { BloqueoId = 3, ZonaId = 2, MesaId = 3, FechaInicio = DateTime.Today.AddDays(5), FechaFin = DateTime.Today.AddDays(6), EstadoId = 1, Motivo = "Mantenimiento" }

        );

        modelBuilder.Entity<Zona>().HasData(
            new Zona { ZonaId = 1, Nombre = "Zona Interior" },
            new Zona { ZonaId = 2, Nombre = "Zona Exterior" }
        ); 

        modelBuilder.Entity<Mesa>().HasData(
            new Mesa { MesaId = 1, ZonaId = 1, NumMesa = 1, Capacidad = 4 },
            new Mesa { MesaId = 2, ZonaId = 1, NumMesa = 2, Capacidad = 7 },
            new Mesa { MesaId = 3, ZonaId = 2, NumMesa = 3, Capacidad = 6 },
            new Mesa { MesaId = 4, ZonaId = 2, NumMesa = 4, Capacidad = 3 },
            new Mesa { MesaId = 5, ZonaId = 1, NumMesa = 5, Capacidad = 5 },
            new Mesa { MesaId = 6, ZonaId = 1, NumMesa = 6, Capacidad = 4 },
            new Mesa { MesaId = 7, ZonaId = 2, NumMesa = 7, Capacidad = 16 },
            new Mesa { MesaId = 8, ZonaId = 2, NumMesa = 8, Capacidad = 4 }
        );

        modelBuilder.Entity<ListaDeEspera>().HasData(
            new ListaDeEspera { ListaDeEsperaId = 1, ClienteId = 1, NumPersonas = 4, Fecha = DateOnly.FromDateTime(DateTime.Today.AddDays(1)), EstadoId = 1 },
            new ListaDeEspera { ListaDeEsperaId = 2, ClienteId = 2, NumPersonas = 2, Fecha = DateOnly.FromDateTime(DateTime.Today.AddDays(2)), EstadoId = 1 },
            new ListaDeEspera { ListaDeEsperaId = 3, ClienteId = 3, NumPersonas = 6, Fecha = DateOnly.FromDateTime(DateTime.Today.AddDays(3)), EstadoId = 1 },
            new ListaDeEspera { ListaDeEsperaId = 4, ClienteId = 4, NumPersonas = 3, Fecha = DateOnly.FromDateTime(DateTime.Today.AddDays(4)), EstadoId = 1 },
            new ListaDeEspera { ListaDeEsperaId = 5, ClienteId = 5, NumPersonas = 5, Fecha = DateOnly.FromDateTime(DateTime.Today.AddDays(5)), EstadoId = 1 }
        );

        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { ClienteId = 1, Nombre = "Juan", Telefono = "123456789", CorreoElectronico = "juan.perez@example.com" },   
            new Cliente { ClienteId = 2, Nombre = "María", Telefono = "987654321", CorreoElectronico = "maria.gomez@example.com" },
            new Cliente { ClienteId = 3, Nombre = "Carlos", Telefono = "456789123", CorreoElectronico = "carlos.lopez@example.com" },
            new Cliente { ClienteId = 4, Nombre = "Ana", Telefono = "321654987", CorreoElectronico = "ana.martinez@example.com" },
            new Cliente { ClienteId = 5, Nombre = "Luis", Telefono = "654987321", CorreoElectronico = "luis.rodriguez@example.com" }
        );

    }

}
   
