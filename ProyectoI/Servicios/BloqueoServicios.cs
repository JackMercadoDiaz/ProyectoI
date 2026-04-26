using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class BloqueoServicios : IBloqueo
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public BloqueoServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public Bloqueo createBloqueo(Bloqueo bloqueo)
        {
            _RestauranteDbcontext.Bloqueos.Add(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;
        }

        public void deleteBloqueo(int bloqueoId)
        {
            var result = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            _RestauranteDbcontext.Bloqueos.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Bloqueo> getAllBloqueos()
        {
            return _RestauranteDbcontext.Bloqueos.ToList();
        }

        public Bloqueo getBloqueoById(int bloqueoId)
        {
            var result = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            return result;
        }

        public Bloqueo updateBloqueo(int bloqueId, Bloqueo bloqueo)
        {
            var result = _RestauranteDbcontext.Bloqueos.Find(bloqueId);
            result.bloqueoId = bloqueo.bloqueoId;
            _RestauranteDbcontext.Bloqueos.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
    }
}