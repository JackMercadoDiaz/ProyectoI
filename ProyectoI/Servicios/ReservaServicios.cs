using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class ReservaServicios : IReserva
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public ReservaServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public List<Reserva> GetAllReservas()
        {
            return _RestauranteDbcontext.Reservas.ToList();
        }

        public Reserva GetReservaById(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            return result;
        }

        public Reserva CreateReserva(int clienteId, int mesaId, int horarioId, int numPersonas, DateTime fecha)
        {
            var result = new Reserva
            {
                ClienteId = clienteId,
                MesaId = mesaId,
                HorarioId = horarioId,
                NumPersonas = numPersonas,
                Fecha = fecha,
                Estado = "Reserva Pendiente"
            };
            _RestauranteDbcontext.Reservas.Add(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public Reserva AtenderReserva(int reservaId, Reserva reserva)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            result.Estado = "Mesa Atendida";
            _RestauranteDbcontext.Reservas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public Reserva CancelarReserva(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            result.Estado = "Reserva Cancelada";
            _RestauranteDbcontext.Reservas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public bool ValidarDisponibilidadMesa(int mesaId, int horarioId, DateTime fecha)
        {
            var reservaExistente = _RestauranteDbcontext.Reservas
            .Any(r => r.MesaId == mesaId
            && r.Fecha.Date == fecha.Date
            && r.HorarioId == horarioId
            && r.Estado != "Reserva Cancelada");
            return reservaExistente;
        }
    }
}
