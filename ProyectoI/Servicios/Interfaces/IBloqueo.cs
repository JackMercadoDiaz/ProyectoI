using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> GetBloqueos();
        public Bloqueo GetBloqueoById(int id);
        public Bloqueo createBloqueo (Bloqueo bloqueo);
        public Bloqueo UpdateBloqueo(int bloqueIdo,Bloqueo bloqueo);
        public void DeleteBloqueo(int bloqueoIdo);
    }
}
