using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> GetAllBloqueos();
        public Bloqueo GetBloqueoById(int id);
        public Bloqueo createBloqueo (Bloqueo bloqueo);
        public Bloqueo updateBloqueo(int bloqueIdo,Bloqueo bloqueo);
        public void deleteBloqueo(int bloqueoIdo);
    }
}
