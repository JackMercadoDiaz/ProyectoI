namespace ProyectoI.Entidades
{
    public class Bloqueo
    {
        public int Id { get; set; }
        public int zonaId { get; set; }
        public int mesaId { get; set; }
        public int fechaInicio { get; set; }
        public int fechaFin { get; set; }
        public string estado { get; set; }
        public string motivo { get; set; }

    }
}
