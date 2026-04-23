using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface ISeccion
    {
        public List<Seccion> GetAllSecciones();
        public Seccion GetSeccionById(int SeccionId);
        public Seccion createSeccion(Seccion seccion);
        public Seccion updateSeccion(int SeccionId, Seccion seccion);
        public void deleteSeccion (int SeccionId);
    }
}
