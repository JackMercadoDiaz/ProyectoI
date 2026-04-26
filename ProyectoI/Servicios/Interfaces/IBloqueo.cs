using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> getAllBloqueos();
        public Bloqueo getBloqueoById(int id);
        public Bloqueo createBloqueo (Bloqueo bloqueo);
        public Bloqueo updateBloqueo(int bloqueIdo,Bloqueo bloqueo);
        public void deleteBloqueo(int bloqueoIdo);
    }
}
