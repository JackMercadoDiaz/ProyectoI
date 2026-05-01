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
            var result = _horarioService.GetAllHorario();
            return result;
        }

        // GET api/<HorariosController>/5
        [HttpGet("{id}")]
        public Horario Get(int id)
        {
            var result = _horarioService.GetHorarioById(id);
            return result;
        }

        // POST api/<HorariosController>
        [HttpPost]
        public Horario Post([FromBody] Horario newHorario)
        {
            var result = _horarioService.CreateHorario(newHorario.Nombre, newHorario.DiaSemana, newHorario.HoraInicio, newHorario.HoraFin);
            return result;
        }

        [HttpGet("validar")]
        public string ValidarHorario(DateTime fecha, int horarioId)
        {
            var result = _horarioService.ValidarHorario(fecha, horarioId);
            return result;
        }

        // PUT api/<HorariosController>/5
     /*   [HttpPut("api/horarios/{id}")]
        public Horario Put(int id, [FromBody] Horario updateHorario)
        {
            var result = _horarioService.UpdateHorario(id, updateHorario);
            return result;
        } */

        // DELETE api/<HorariosController>/5
    /*    [HttpDelete("api/horarios/{id}")]
        public void Delete(int id)
        {
            _horarioService.DeleteHorario(id);
        } */
    }
}
