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


        public Seccion CreateSeccion(Seccion seccion)
        {
            _RestauranteDbcontext.Secciones.Add(seccion);
            _RestauranteDbcontext.SaveChanges();
            return seccion;
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

       
    }
}
