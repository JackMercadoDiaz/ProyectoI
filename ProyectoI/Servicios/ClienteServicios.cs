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
        public Cliente CreateCliente(string nombre, string telefono, string correoElectronico)
        {
            var cliente = new Cliente
            {
                Nombre = nombre,
                Telefono = telefono,
                CorreoElectronico = correoElectronico
            };
            _RestauranteDbcontext.Clientes.Add(cliente);
            _RestauranteDbcontext.SaveChanges();
            return cliente;
        }

        public void DeleteCliente(int clienteId)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            if (result != null)
            {
                _RestauranteDbcontext.Clientes.Remove(result);
                _RestauranteDbcontext.SaveChanges();
            }
        }

        public List<Cliente> GetAllClientes()
        {
            return _RestauranteDbcontext.Clientes.ToList();
        }

        public Cliente GetClienteById(int clienteId)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            if (result == null)
                throw new Exception("Cliente no encontrado");
            return result;
        }

        public Cliente UpdateCliente(int clienteId, Cliente cliente)
        {
            var result = _RestauranteDbcontext.Clientes.Find(clienteId);
            if (result == null)
                throw new Exception("Cliente no encontrado");

            result.Nombre = cliente.Nombre;
            result.Telefono = cliente.Telefono;
            result.CorreoElectronico = cliente.CorreoElectronico;
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}