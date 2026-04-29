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
            return result;
        }


        public ListaDeEspera CancelarEspera(int listaDeEsperaId)
        {
            var result = _RestauranteDbcontext.ListaDeEsperas.Find(listaDeEsperaId);
            result.Estado = "Cancelada";
            _RestauranteDbcontext.SaveChanges();
            return result;
        }

        public ListaDeEspera AtenderSiguienteEnLista(int horarioId, DateTime fecha, int zonaId)
        {
            var siguiente = _RestauranteDbcontext.ListaDeEsperas
                .Where(l => l.HorarioId == horarioId
                    && l.ZonaId == zonaId
                    && l.Fecha == fecha
                    && l.Estado == "Pendiente")
                .OrderBy(l => l.ListaDeEsperaId)
                .FirstOrDefault();

            if (siguiente == null)
                throw new Exception("No hay entradas pendientes en la lista de espera");

            siguiente.Estado = "Asignada";
            _RestauranteDbcontext.SaveChanges();
            return siguiente;
        }
    }
}
