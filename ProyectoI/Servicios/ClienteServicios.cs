using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class ClienteServicios : IClientes
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public ClienteServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public Cliente CreateCliente(Cliente cliente)
        {
            _RestauranteDbcontext.Clientes.Add(cliente);
            _RestauranteDbcontext.SaveChanges();
            return cliente;
        }

        public void DeleteCliente(int clienteId)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            _RestauranteDbcontext.Clientes.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Cliente> GetAllClientes()
        {
            return _RestauranteDbcontext.Clientes.ToList();
        }

        public Cliente GetClienteById(int clienteId)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            return result;
        }

        public Cliente UpdateCliente(int clienteId, Cliente cliente)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            result.ClienteId = cliente.ClienteId;
            _RestauranteDbcontext.Clientes.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}