using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProyectoI.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaDeEsperasController : ControllerBase
    {
        private readonly IListaDeEspera _listaDeEsperaServicio;

        public ListaDeEsperasController(IListaDeEspera listaDeEsperaServicio)
        {
            _listaDeEsperaServicio = listaDeEsperaServicio;
        }

        // GET: api/<ListaDeEsperasController>
        [HttpGet]
        public IEnumerable<ListaDeEspera> Get()
        {
            var result = _listaDeEsperaServicio.GetAllListasDeEsperas();
            return result;
        }

        // GET api/<ListaDeEsperasController>/5
        [HttpGet("{id}")]
        public ListaDeEspera Get(int id)
        {
            var result = _listaDeEsperaServicio.GetListaDeEsperaById(id);
            return result;
        }

        // POST api/<ListaDeEsperasController>
        [HttpPost]
        public ListaDeEspera Post([FromBody] ListaDeEsperaDto dto)
        {
            var result = _listaDeEsperaServicio.CreateListaDeEspera(dto);
            return result;
        }


        [HttpPut("{id}/cancelar")]
        public ListaDeEspera Cancelar(int id)
        {
            return _listaDeEsperaServicio.CancelarEspera(id);
        }

        [HttpPut("atender")]
        public ListaDeEspera AtenderSiguiente(int horarioId, DateTime fecha, int zonaId)
        {
            return _listaDeEsperaServicio.AtenderSiguienteEnLista(horarioId, fecha, zonaId);
        }


    }
}
