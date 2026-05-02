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
        public IActionResult Get()
        {
            var result = _mesaServicio.GetAllMesas();
            return Ok(result);
        }

        // GET api/<MesaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var mesa = _mesaServicio.GetMesaById(id);

            if (mesa == null)
                return NotFound("Mesa eliminada.");

            return Ok(mesa);
        }

        // POST api/<MesaController>
        [HttpPost]
        public IActionResult Post([FromBody] Mesa newMesa)
        {
            var result = _mesaServicio.CreateMesa(newMesa);
            return Ok(result);
        }

        // PUT api/<MesaController>/5

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Mesa updatedMesa)
        {
            var result = _mesaServicio.UpdateMesa(id, updatedMesa);
            return Ok(result);
        }

        // DELETE api/<MesaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _mesaServicio.DeleteMesa(id);
            return Ok("Mesa eliminada.");
        }

        [HttpPut("{mesaId}/estado")]
        public IActionResult CambiarEstado(int mesaId, string estado)
        {
            var result = _mesaServicio.CambiarEstadoMesa(mesaId, estado);
            return Ok(result);
        }
    }
}
