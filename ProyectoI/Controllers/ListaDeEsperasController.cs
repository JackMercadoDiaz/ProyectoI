using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            var result = _listaDeEsperaServicio.getAllListasDeEsperas();
            return result;
        }

        // GET api/<ListaDeEsperasController>/5
        [HttpGet("{id}")]
        public ListaDeEspera Get(int id)
        {
            var result = _listaDeEsperaServicio.getListaDeEsperaById(id);
            return result;
        }

        // POST api/<ListaDeEsperasController>
        [HttpPost]
        public ListaDeEspera Post([FromBody] ListaDeEspera newListaDeEspera)
        {
            var result = _listaDeEsperaServicio.createListaDeEspera(newListaDeEspera);
            return result;
        }

        // PUT api/<ListaDeEsperasController>/5
        [HttpPut("{id}")]
        public ListaDeEspera Put(int id, [FromBody] ListaDeEspera updatedListaDeEspera)
        {
            var result = _listaDeEsperaServicio.updateListaDeEspera(id, updatedListaDeEspera);
            return result;
        }

        // DELETE api/<ListaDeEsperasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _listaDeEsperaServicio.deleteListaDeEspera(id);
        }
    }
}
