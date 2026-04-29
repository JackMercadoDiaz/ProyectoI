namespace ProyectoI.Entidades
{
    public class ListaDeEspera
    {
        public int ListaDeEsperaId { get; set; }
        public int ClienteId { get; set; }
        public int HorarioId { get; set; }
        public int ZonaId { get; set; }
        public DateOnly Fecha { get; set; }
        public int NumPersonas { get; set; }
        public string Estado { get; set; }

    }
}
