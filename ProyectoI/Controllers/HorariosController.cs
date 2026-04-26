using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : ControllerBase
    {
        private readonly IHorario _horarioService;
            public HorariosController(IHorario horarioService)
        {
            _horarioService = horarioService;
        }
        // GET: api/<HorariosController>
        [HttpGet]
        public IEnumerable<Horario> Get()
        {
            var result = _horarioService.getAllHorario();
            return result;
        }

        // GET api/<HorariosController>/5
        [HttpGet()]
        public Horario Get(int id)
        {
            var result = _horarioService.getHorarioById(id);
            return result;
        }
        [HttpGet()]

        // POST api/<HorariosController>
        [HttpPost]
        public Horario Post([FromBody] Horario newHorario)
        {
            var result = _horarioService.createHorario(newHorario);
            return result;
        }

        // PUT api/<HorariosController>/5
        [HttpPut("{id}")]
        public Horario Put(int id, [FromBody] Horario updateHorario)
        {
            var result = _horarioService.updateHorario(id, updateHorario);
            return result;
        }

        // DELETE api/<HorariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _horarioService.deleteHorario(id);
        }
    }
}
