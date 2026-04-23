using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface IReserva
    {
        //Reads
        public List<Reserva> GetAllReservas ();
        public Reserva GetReservaById (int reservaId);
        //writes
        public Reserva createReserva (Reserva reserva);
        public Reserva updateReserva (int reservaId, Reserva reserva);
        public void deleteReserva (int reservaId);
    }
}
