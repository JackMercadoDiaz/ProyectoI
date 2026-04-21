namespace ProyectoI.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public int  reservaId { get; set; }
        public float monto { get; set; }
        public string fechaPago { get; set; }
        public string estado { get; set; }
    }
}
