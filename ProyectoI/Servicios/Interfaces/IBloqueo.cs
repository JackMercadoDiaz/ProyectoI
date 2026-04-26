using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> GetAllBloqueos();
        Bloqueo GetBloqueoById(int id);
        Bloqueo CreateBloqueo (Bloqueo bloqueo);
        void DeleteBloqueo(int bloqueoId);
        bool VerificarBloqueo(int mesaId, DateTime fechaHora);
    }
}
