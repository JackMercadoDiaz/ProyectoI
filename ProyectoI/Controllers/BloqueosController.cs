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
            var result = _bloqueoService.GetAllBloqueos();
            return result;
        }

        // GET api/<BloqueosController>/5
        [HttpGet("{id}")]
        public Bloqueo Get(int id)
        {
            var result = _bloqueoService.GetBloqueoById(id);
            return result;
        }

        //Get api/<BloqueosController>/verificar
        [HttpGet("verificar")]
        public bool VerificarBloqueo(int mesaId , DateTime fechaHora)
        {
           return _bloqueoService.VerificarBloqueo(mesaId, fechaHora);
        }


        // POST api/<BloqueosController>
        [HttpPost]
        public Bloqueo Post([FromBody] Bloqueo newBloqueo)
        {
            var result = _bloqueoService.CreateBloqueo(newBloqueo);
            return result;
        }

        // DELETE api/<BloqueosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {  
            _bloqueoService.DeleteBloqueo(id);
        }
    }
}
