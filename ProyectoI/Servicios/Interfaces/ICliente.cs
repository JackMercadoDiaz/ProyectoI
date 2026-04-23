using ProyectoI.Entidades;

namespace ProyectoI.Servicios.Interfaces
{
    public interface ICliente
    {
        public List<Cliente> GetAllClientes();
        public Cliente GetClienteById(int id);
        public Cliente GetClienteByName(string name);
        public Cliente createCliente(Cliente cliente);
        public Cliente updateCliente (int id, Cliente cliente);
        public void deleteClienteById(int clienteId);
    }
}
