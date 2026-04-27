using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface IReserva
    {
        //Reads
        public List<Reserva> GetAllReservas ();
        public Reserva GetReservaById (int reservaId);
        //writes
        public Reserva CreateReserva (int clienteId, int mesaId, int horarioId, int numPersonas, DateTime fecha);
        public Reserva AtenderReserva (int reservaId, Reserva reserva);
        public Reserva CancelarReserva (int reservaId);
        public bool ValidarDisponibilidadMesa (int mesaId, int horarioId, DateTime fecha);
    }
}
