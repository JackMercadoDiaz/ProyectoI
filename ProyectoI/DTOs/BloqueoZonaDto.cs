namespace ProyectoI.DTOs
{
    public class BloqueoZonaDto
    {
        public int ZonaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Motivo { get; set; }
    }
}
