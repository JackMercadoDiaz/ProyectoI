using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface ISeccion
    {
        public List<Seccion> GetAllSecciones();
        public Seccion GetSeccion(int SeccionId);
        public Seccion CreateSeccion(Seccion seccion);
        public Seccion UpdateSeccion(int SeccionId, Seccion seccion);
        public void DeleteSeccion(int SeccionId);
    }
}
