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
        public Bloqueo CreateBloqueo(Bloqueo bloqueo)
        {
            _RestauranteDbcontext.Bloqueos.Add(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;
        }

        public void DeleteBloqueo(int bloqueoId)
        {
            var result = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            _RestauranteDbcontext.Bloqueos.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Bloqueo> GetAllBloqueos()
        {
            return _RestauranteDbcontext.Bloqueos.ToList();
        }

        public Bloqueo GetBloqueoById(int bloqueoId)
        {
            var result = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            return result;
        }
        public bool VerificarBloqueo(int mesaId, DateTime fechaHora)
        {
            return _RestauranteDbcontext.Bloqueos
                .Any(b => b.MesaId == mesaId
                && fechaHora >= b.FechaInicio
                && fechaHora <= b.FechaFin
                && b.Estado == "Activo");
        }
    }
} 