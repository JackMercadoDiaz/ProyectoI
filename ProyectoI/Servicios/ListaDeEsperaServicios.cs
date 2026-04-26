using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class ListaDeEsperaServicios : IListaDeEspera
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public ListaDeEsperaService(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public ListaDeEspera CreateListaDeEspera(ListaDeEspera listaDeEspera)
        {
            _RestauranteDbcontext.ListaDeEsperas.Add(listaDeEspera);
            _RestauranteDbcontext.SaveChanges();
            return listaDeEspera;
        }

        public void DeleteListaDeEspera(int listaDeEsperaId)
        {
            var result = _RestauranteDbcontext.ListaDeEsperas.Find(listaDeEsperaId);
            _RestauranteDbcontext.ListaDeEsperas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
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

        public ListaDeEspera UpdateListaDeEspera(int listaDeEsperaId, ListaDeEspera listaDeEspera)
        {
            var result = _RestauranteDbcontext.ListaDeEsperas.Find(listaDeEsperaId);
            result.listaDeEsperaId = listaDeEspera.listaDeEsperaId;
            _RestauranteDbcontext.ListaDeEsperas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}
