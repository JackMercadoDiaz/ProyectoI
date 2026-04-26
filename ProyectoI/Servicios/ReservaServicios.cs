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

        public Reserva createReserva(Reserva reserva)
        {
            _RestauranteDbcontext.Reservas.Add(reserva);
            _RestauranteDbcontext.SaveChanges();
            return reserva;
        }

        public void deleteReserva(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            _RestauranteDbcontext.Reservas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Reserva> getAllReservas()
        {
            return _RestauranteDbcontext.Reservas.ToList();
        }

        public Reserva getReservaById(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            return result;
        }

        public Reserva updateReserva(int reservaId, Reserva reserva)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            result.reservaId = reserva.reservaId;
            _RestauranteDbcontext.Reservas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}
