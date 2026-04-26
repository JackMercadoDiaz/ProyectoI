using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IReserva _reservaService;
        public ReservasController(IReserva reservaService)
        {
            _reservaService = reservaService;
        }
        // GET: api/<ReservasController>
        [HttpGet]
        public IEnumerable<Reserva> Get()
        {
            var result = _reservaService.getAllReservas();
            return result;
        }

        // GET api/<ReservasController>/5
        [HttpGet("{id}")]
        public Reserva Get(int id)
        {
            var result = _reservaService.getReservaById(id);
            return result;
        }

        // POST api/<ReservasController>
        [HttpPost]
        public Reserva Post([FromBody] Reserva newReserva)
        {
            var result = _reservaService.createReserva(newReserva);
            return result;
        }

        // PUT api/<ReservasController>/5
        [HttpPut("{id}")]
        public Reserva Put(int id, [FromBody] Reserva updateReserva)
        {
            var result = _reservaService.updateReserva(id, updateReserva);
            return result;
        }

        // DELETE api/<ReservasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reservaService.deleteReserva(id);
        }
    }
}
