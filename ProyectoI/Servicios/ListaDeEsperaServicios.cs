using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;
using ProyectoI.DTOs;

namespace ProyectoI.Servicios
{
    public class ListaDeEsperaServicios : IListaDeEspera
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public ListaDeEsperaServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }


        public ListaDeEspera CreateListaDeEspera(ListaDeEsperaDto dto)
        {
            var listaDeEspera = new ListaDeEspera
            {
                ClienteId = dto.ClienteId,
                HorarioId = dto.HorarioId,
                ZonaId = dto.ZonaId,
                Fecha = dto.Fecha,
                NumPersonas = dto.NumPersonas,
                Estado = "Pendiente"
            };

            _RestauranteDbcontext.ListaDeEsperas.Add(listaDeEspera);
            _RestauranteDbcontext.SaveChanges();
            return listaDeEspera;
        }

        public List<ListaDeEspera> GetAllListasDeEsperas()
        {
            return _RestauranteDbcontext.ListaDeEsperas.ToList();
        }

        public ListaDeEspera GetListaDeEsperaById(int listaDeEsperaId)
        {
            var result = _RestauranteDbcontext.ListaDeEsperas.Find(listaDeEsperaId);
            if (result == null)
                throw new Exception("Id no encontrado");
            return result;
        }


        public ListaDeEspera CancelarEspera(int listaDeEsperaId)
        {
            var result = _RestauranteDbcontext.ListaDeEsperas.Find(listaDeEsperaId);
            if (result == null)
                throw new Exception("Id no encontrado");

            result.Estado = "Cancelada";
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public ListaDeEspera AtenderSiguienteEnLista(int horarioId, DateTime fecha, int zonaId)
        {
            var siguiente = _RestauranteDbcontext.ListaDeEsperas
        .Where(lista => lista.HorarioId == horarioId
            && lista.ZonaId == zonaId
            && lista.Fecha.Date == fecha.Date
            && lista.Estado == "Pendiente")
        .OrderBy(lista => lista.Id)
        .FirstOrDefault();

            if (siguiente == null)
                throw new Exception("No hay entradas pendientes en la lista de espera con esos parámetros");

            siguiente.Estado = "Asignada";
            _RestauranteDbcontext.SaveChanges();
            return siguiente;
        }
    }
}