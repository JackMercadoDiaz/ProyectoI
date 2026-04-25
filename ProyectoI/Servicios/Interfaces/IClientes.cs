using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IClientes
    {
        public List<Cliente> GetAllClientes();
        public Cliente GetCliente(int ClienteId);
        public Cliente CreateCliente(Cliente cliente);
        public Cliente UpdateCliente(int ClienteId, Cliente cliente);
        public void DeleteCliente(int ClienteId);
    }
}
