using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonasController : ControllerBase
    {
        private readonly IZona _zonasService;
            public ZonasController(IZona zonasService)
        {
            _zonasService = zonasService;
        }
        // GET: api/<ZonasController>
        [HttpGet]
        public IEnumerable<Zona> Get()
        {
            var result = _zonasService.getAllZonas();
            return result;
        }

        // GET api/<ZonasController>/5
        [HttpGet("{id}")]
        public Zona Get(int id)
        {
            var result = _zonasService.getZonaById(id);
            return result;
        }

        // POST api/<ZonasController>
        [HttpPost]
        public Zona Post([FromBody] Zona newZona)
        {
            var result = _zonasService.createZona(newZona);
            return result;
        }

        // PUT api/<ZonasController>/5
        [HttpPut("{id}")]
        public Zona Put(int id, [FromBody] Zona updateZona)
        {
            var result = _zonasService.updateZona(id, updateZona);
            return result;
        }

        // DELETE api/<ZonasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _zonasService.deleteZona(id);
        }
    }
}
