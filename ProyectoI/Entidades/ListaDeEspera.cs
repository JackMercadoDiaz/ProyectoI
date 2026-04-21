namespace ProyectoI.Entidades
{
    public class ListaDeEspera
    {
                public int Id { get; set; }
        public int clienteId { get; set; }
        public int horarioId { get; set; }
        public int zonaId { get; set; }
        public string fecha { get; set; }
        public int numPersonas { get; set; }
        public bool estado { get; set; }

    }
}
