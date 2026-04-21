using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface IReserva
    {
        //Reads
        public List<Reserva> GetAllReservas ();
        public Reserva GetReservaById (int reservaId);
        public Reserva GetReservaMesaId (int reservaMesaId);
        //writes
        public Reserva CreateReserva (Reserva reserva);
        public Reserva UpgradeReserva (int reservaI, Reserva reserva);
        public void DeleteReserva (int reservaId);
    }
}
