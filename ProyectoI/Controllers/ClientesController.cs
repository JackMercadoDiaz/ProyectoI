using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientes _clienteService;
        public ClientesController(IClientes clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var result = _clienteService.GetAllClientes();
            return result;
        }

        // GET api/<ClientesController>/5
        [HttpGet()]
        public Cliente Get(int id)
        {
            var result = _clienteService.GetClienteById(id);
            return result;
        }
        [HttpGet()]

        // POST api/<ClientesController>
        [HttpPost]
        public Cliente Post([FromBody] Cliente newCliente)
        {
            var result = _clienteService.createCliente(newCliente);
            return result;
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public Cliente Put(int id, [FromBody] Cliente updateCliente)
        {
            var result = _clienteService.updateCliente(id, updateCliente);
            return result;
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clienteService.deleteCliente(id);
        }
    }
}
