namespace ProyectoI.DTOS
{
    public class CreateReservaDTO
    {
        public int ClienteId { get; set; }
        public int MesaId { get; set; }
        public int HorarioId { get; set; }
        public int NumPersonas { get; set; }
        public DateTime Fecha { get; set; }
    }

    // DTO para crear una nueva reserva, (elimino el IdReserva porque se genera automáticamente en la base de datos)
    //Solamente se exponen los datos necesarios para crear una reserva
    //Elimino el IdReserva porque se genera automáticamente en la base de datos
    //Esta clase se utiliza para mapear los datos que se reciben del cliente al crear una nueva reserva,
    //y luego se puede convertir a una entidad Reserva para guardarla en la base de datos
    //El cliente no debe poder modificar datos como Id de la reserva y el estado de la reserva, por eso no se incluyen en este DTO.
}
