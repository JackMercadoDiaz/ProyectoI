using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> GetAllBloqueos();
        public Bloqueo GetBloqueoById(int id);
        public Bloqueo CreateBloqueo (Bloqueo bloqueo);
        public Bloqueo UpdateBloqueo(int bloqueIdo,Bloqueo bloqueo);
        public void DeleteBloqueo(int bloqueoIdo);
    }
}
