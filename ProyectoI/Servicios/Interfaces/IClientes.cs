using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IClientes
    {
        public List<Cliente> GetAllClientes();
        public Cliente GetClienteById(int clienteId);
        public Cliente CreateCliente(Cliente cliente);
        public Cliente UpdateCliente(int clienteId, Cliente cliente);
        public void DeleteCliente(int clienteId);
    }
}
