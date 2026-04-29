namespace ProyectoI.DTOs
{
    public class BloqueoMesaDto
    {
        public int MesaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Motivo { get; set; }
    }
}
