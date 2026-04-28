namespace ProyectoI.Entidades
{
    public class Bloqueo
    {
        public int BloqueoId { get; set; }
        public int ZonaId { get; set; }
        public int MesaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int EstadoId { get; set; }
        public string Motivo { get; set; }

    }
}
