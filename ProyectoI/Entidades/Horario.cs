namespace ProyectoI.Entidades
{
    public class Horario
    {
        public int HorarioId { get; set; }
        public string Nombre { get; set; }
        public string DiaSemana { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }

    }
}
