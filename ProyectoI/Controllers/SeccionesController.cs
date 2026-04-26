using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeccionesController : ControllerBase
    {
        private readonly ISeccion _seccionService;
            public SeccionesController(ISeccion seccionService)
        {
            _seccionService = seccionService;
        }
        // GET: api/<SeccionesController>
        [HttpGet]
        public IEnumerable<Seccion> Get()
        {
            var result = _seccionService.GetAllSecciones();
            return result;
        }

        // GET api/<SeccionesController>/5
        [HttpGet("{id}")]
        public Seccion Get(int id)
        {
            var result = _seccionService.GetSeccionById(id);
            return result;
        }

        // POST api/<SeccionesController>
        [HttpPost]
        public Seccion Post([FromBody] Seccion newSeccion)
        {
            var result = _seccionService.CreateSeccion(newSeccion);
            return result;
        }

        // PUT api/<SeccionesController>/5
        [HttpPut("{id}")]
        public Seccion Put(int id, [FromBody] Seccion updateSeccion)
        {
            var result = _seccionService.UpdateSeccion(id, updateSeccion);
            return result;
        }

        // DELETE api/<SeccionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _seccionService.DeleteSeccion(id);
        }
    }
}
