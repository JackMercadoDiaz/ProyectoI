namespace ProyectoI.Entidades
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int ClienteId { get; set; }
        public int MesaId { get; set; }
        public int HorarioId { get; set; }
        public int NumPersonas { get; set; }
        public int Fecha { get; set; }
        public bool Estado { get; set; }
    }
}
