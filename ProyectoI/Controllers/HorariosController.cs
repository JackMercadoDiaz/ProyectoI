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

        [HttpGet("validar")]
        public string ValidarHorario(DateTime fecha, int horarioId)
        {
            var result = _horarioService.ValidarHorario(fecha, horarioId);
            return result;
        }

    }
}
