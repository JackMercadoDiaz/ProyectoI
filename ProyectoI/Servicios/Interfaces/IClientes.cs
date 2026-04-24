using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IClientes
    {
        public List<Clientes> GetAllClientes();
        public Clientes GetCliente(int ClienteId);
        public Clientes CreateCliente(Clientes cliente);
        public Clientes UpdateCliente(int ClienteId, Clientes cliente);
        public void DeleteCliente(int ClienteId);
    }
}
