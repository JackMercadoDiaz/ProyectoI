using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class ZonaServicios : IZona
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public ZonaServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public Zona createZona(Zona zona)
        {
            _RestauranteDbcontext.Zonas.Add(zona);
            _RestauranteDbcontext.SaveChanges();
            return zona;
        }

        public void deleteZona(int ZonaId)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            _RestauranteDbcontext.Zonas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Zona> getAllZonas()
        {
            return _RestauranteDbcontext.Zonas.ToList();
        }

        public Zona getZonaById(int ZonaId)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            return result;
        }

        public Zona updateZona(int ZonaId, Zona zona)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            result.zonaId = zona.zonaId;
            _RestauranteDbcontext.Zonas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}
