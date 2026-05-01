using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;
using ProyectoI.DTOS;

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

        public Reserva CreateReserva(CreateReservaDTO dto)
        {
            var result = new Reserva
            {
                ClienteId = dto.ClienteId,
                MesaId = dto.MesaId,
                HorarioId = dto.HorarioId,
                NumPersonas = dto.NumPersonas,
                Fecha = dto.Fecha,
                Estado = "Reserva Pendiente"
            };
            _RestauranteDbcontext.Reservas.Add(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public Reserva AtenderReserva(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            result.Estado = "Reserva Atendida";
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
            .Any(reserva => reserva.MesaId == mesaId
            && reserva.Fecha.Date == fecha.Date
            && reserva.HorarioId == horarioId
            && reserva.Estado != "Reserva Cancelada");
            return reservaExistente;
        }
    }
}
