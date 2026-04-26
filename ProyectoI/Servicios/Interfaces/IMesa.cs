using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IMesa
    {
        public List<Mesa> getAllMesas();
        public Mesa getMesaById(int id);

        public Mesa createMesa(Mesa mesa);
        public Mesa updateMesa(int id, Mesa mesa);
        void deleteMesa(int id);

    }
}
