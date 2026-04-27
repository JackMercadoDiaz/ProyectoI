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
        public Zona CreateZona(string nombre, int seccionId)
        {
            var zona = new Zona
            {
                Nombre = nombre,
                SeccionId = seccionId
            };
            _RestauranteDbcontext.Zonas.Add(zona);
            _RestauranteDbcontext.SaveChanges();
            return zona;
        }

        public void DeleteZona(int ZonaId)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            _RestauranteDbcontext.Zonas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Zona> GetAllZonas()
        {
            return _RestauranteDbcontext.Zonas.ToList();
        }

        public Zona GetZonaById(int ZonaId)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            return result;
        }

        public Zona UpdateZona(int ZonaId, Zona zona)
        {
            var result = _RestauranteDbcontext.Zonas.Find(ZonaId);
            result.ZonaId = zona.ZonaId;
            _RestauranteDbcontext.Zonas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}
