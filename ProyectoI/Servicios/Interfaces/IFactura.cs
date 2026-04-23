using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IFactura
    {
        public List<Factura> GetAllFacturas();
        public Factura GetFactura(int FacturaId);
        public Factura CreateFactura(Factura factura);
        public Factura UpdateFactura(int FacturaId, Factura factura);
        public void DeleteFactura(int FacturaId);
    }
}
