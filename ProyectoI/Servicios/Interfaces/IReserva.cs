using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface IReserva
    {
        //Reads
        public List<Reserva> GetAllReservas ();
        public Reserva GetReservaById (int reservaId);
        //writes
        public Reserva CreateReserva (Reserva reserva);
        public Reserva UpdateReserva (int reservaId, Reserva reserva);
        public void DeleteReserva (int reservaId);
    }
}
