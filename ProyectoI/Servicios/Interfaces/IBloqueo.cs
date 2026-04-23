using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        List<Bloqueo> GetBloqueos();
        Bloqueo GetBloqueoById(int id);
        void AddBloqueo(Bloqueo bloqueo);
        void UpdateBloqueo(Bloqueo bloqueo);
        void DeleteBloqueo(int id);
    }
}
