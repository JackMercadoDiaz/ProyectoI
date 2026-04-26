using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface ISeccion
    {
        public List<Seccion> GetAllSecciones();
        public Seccion GetSeccionById(int SeccionId);
        public Seccion CreateSeccion(Seccion seccion);
    }
}
