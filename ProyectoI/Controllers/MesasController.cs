using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesasController : ControllerBase
    {
        private readonly IMesa _mesaServicio;

        public MesasController(IMesa mesaServicio)
        {
            _mesaServicio = mesaServicio;
        }

        // GET: api/<MesaController>
        [HttpGet]
        public IEnumerable<Mesa> Get()
        {
            var result = _mesaServicio.GetAllMesas();
            return result;
        }

        // GET api/<MesaController>/5
        [HttpGet("{id}")]
        public Mesa Get(int id)
        {
            var result = _mesaServicio.GetMesaById(id);
            return result;
        }

        // POST api/<MesaController>
        [HttpPost]
        public Mesa Post([FromBody] Mesa newMesa)
        {
            var result = _mesaServicio.CreateMesa(newMesa);
            return result;
        }

        // PUT api/<MesaController>/5

        [HttpPut("{id}")]
        public Mesa Put(int id, [FromBody] Mesa updatedMesa)
        {
            var result = _mesaServicio.UpdateMesa(id, updatedMesa);
            return result;
        }

        // DELETE api/<MesaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mesaServicio.DeleteMesa(id);
        }
    }
}
