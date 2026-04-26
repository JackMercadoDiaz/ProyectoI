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

        public Reserva CreateReserva(Reserva reserva)
        {
            _RestauranteDbcontext.Reservas.Add(reserva);
            _RestauranteDbcontext.SaveChanges();
            return reserva;
        }

        public void DeleteReserva(int reservaId)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            _RestauranteDbcontext.Reservas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
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

        public Reserva UpdateReserva(int reservaId, Reserva reserva)
        {
            var result = _RestauranteDbcontext.Reservas.Find(reservaId);
            result.ReservaId = reserva.ReservaId;
            _RestauranteDbcontext.Reservas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}
