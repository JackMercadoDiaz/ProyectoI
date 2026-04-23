using Microsoft.AspNetCore.Mvc;
using ProyectoI.Servicios.Interfaces;

namespace ProyectoI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HorarioController : ControllerBase
    {
        private readonly IHorario _horarioService;
        public HorarioController(IHorario horarioService)
        {
            _horarioService = horarioService;
        }
        // Aquí puedes agregar métodos para manejar las solicitudes relacionadas con los horarios
        [HttpGet]
        public string Get()
        {
            return "Horario Funcionando";
        }
    }
}
