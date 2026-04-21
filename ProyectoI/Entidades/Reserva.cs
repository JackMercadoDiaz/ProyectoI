namespace ProyectoI.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public int clienteId { get; set; }
        public int mesaId { get; set; }
        public int horarioId { get; set; }
        public int numPersonas { get; set; }
        public int fecha { get; set; }
        public bool estado { get; set; }
    }
}
