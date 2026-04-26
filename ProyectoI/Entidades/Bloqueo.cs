namespace ProyectoI.Entidades
{
    public class Bloqueo
    {
        public int BloqueoId { get; set; }
        public int ZonaId { get; set; }
        public int MesaId { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFin { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }

    }
}
