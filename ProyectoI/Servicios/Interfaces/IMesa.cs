using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IMesa
    {
        public List<Mesa> GetAllMesas();
        public Mesa GetMesaById(int mesaId);

        public Mesa CreateMesa(Mesa mesa);
        public Mesa UpdateMesa(int mesaId, Mesa mesa);
        void DeleteMesa(int mesaId);
    }
}
