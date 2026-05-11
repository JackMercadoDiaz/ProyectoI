using ProyectoI.DTOs;
using ProyectoI.Entidades;  
namespace ProyectoI.Servicios.Interfaces
{
    public interface IBloqueo
    {
        public List<Bloqueo> GetAllBloqueos();
        public Bloqueo GetBloqueoById(int id);
        public Bloqueo CreateBloqueoMesa (BloqueoMesaDto dto);
        public Bloqueo CreateBloqueoZona (BloqueoZonaDto dto);
        public bool VerificarBloqueo(int mesaId, DateTime fechaHora);
        public Bloqueo DeleteBloqueo(int id);
    }
}
