using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloqueosController : ControllerBase
    {
        private readonly IBloqueo _bloqueoService;
                public BloqueosController(IBloqueo bloqueoService)
            {
                _bloqueoService = bloqueoService;
        }
        // GET: api/<BloqueosController>
        [HttpGet]
        public IEnumerable<Bloqueo> Get()
        {
            var result = _bloqueoService.getAllBloqueos();
            return result;
        }

        // GET api/<BloqueosController>/5
        [HttpGet("{id}")]
        public Bloqueo Get(int id)
        {
            var result = _bloqueoService.getBloqueoById(id);
            return result;
        }

        // POST api/<BloqueosController>
        [HttpPost]
        public Bloqueo Post([FromBody] Bloqueo newBloqueo)
        {
            var result = _bloqueoService.createBloqueo(newBloqueo);
            return result;
        }

        // PUT api/<BloqueosController>/5
        [HttpPut("{id}")]
        public Bloqueo Put(int id, [FromBody] Bloqueo updateBloqueo)
        {
            var result = _bloqueoService.updateBloqueo(id, updateBloqueo);
            return result;
        }

        // DELETE api/<BloqueosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {  
            _bloqueoService.deleteBloqueo(id);
        }
    }
}
