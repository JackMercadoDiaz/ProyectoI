using ProyectoI.DTOS;
using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface IReserva
    {
        //Reads
        public List<Reserva> GetAllReservas ();
        public Reserva GetReservaById (int reservaId);
        //writes
        public Reserva CreateReserva (CreateReservaDTO dto);
        public Reserva AtenderReserva (int reservaId);
        public Reserva CancelarReserva (int reservaId);
        public bool ValidarDisponibilidadMesa (int mesaId, int horarioId, DateTime fecha);
    }
}

//Elimino el objeto Reserva de AntenderReserva porque no es necesario devolverlo, simplemente se cambia su estado a "Atendida" y se guarda en la base de datos. De esta manera, el método AtenderReserva solo necesita recibir el ID de la reserva que se desea atender, sin necesidad de devolver un objeto completo.
