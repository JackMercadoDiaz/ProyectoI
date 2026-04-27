using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IMesa
    {
        // reads
        public List<Mesa> GetAllMesas();
        public Mesa GetMesaById(int id);
        // writes
        public Mesa CreateMesa(Mesa mesa);
        public Mesa UpdateMesa(int id, Mesa mesa);
        void DeleteMesa(int id);
        public Mesa CambiarEstadoMesa(int mesaId, bool estado);

    }
}
