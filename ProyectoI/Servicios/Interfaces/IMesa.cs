using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IMesa
    {
        public List<Mesa> GetAllMesas();
        public Mesa GetMesaById(int id);

        public Mesa CreateMesa(Mesa mesa);
        public Mesa UpdateMesa(Mesa mesa);
        void DeleteMesa(int id);

    }
}
