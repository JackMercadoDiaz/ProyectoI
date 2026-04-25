using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IClientes
    {
        public List<Cliente> GetAllClientes();
        public Cliente GetClienteById(int clienteId);
        public Cliente createCliente(Cliente cliente);
        public Cliente updateCliente(int clienteId, Cliente cliente);
        public void deleteCliente(int clienteId);
    }
}
