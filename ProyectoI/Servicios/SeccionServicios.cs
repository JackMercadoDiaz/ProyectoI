using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class SeccionServicios : ISeccion
    {

        private readonly ResturanteDbContext _RestauranteDbcontext;
        public SeccionServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }


        public Seccion createSeccion(Seccion seccion)
        {
            _RestauranteDbcontext.Secciones.Add(seccion);
            _RestauranteDbcontext.SaveChanges();
            return seccion;
        }

        public void deleteSeccion(int seccionId)
        {
            var result = _RestauranteDbcontext.Secciones.Find(seccionId);
            _RestauranteDbcontext.Secciones.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Seccion> GetAllSecciones()
        {
            return _RestauranteDbcontext.Secciones.ToList();
        }

        public Seccion GetSeccionById(int seccionId)
        {
            var result = _RestauranteDbcontext.Secciones.Find(seccionId);
            return result;
        }

        public Seccion updateSeccion(int seccionId, Seccion seccion)
        {
            var result = _RestauranteDbcontext.Secciones.Find(seccionId);
            result.seccionId = seccion.seccionId;
            _RestauranteDbcontext.Secciones.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;

        }
    }
}
