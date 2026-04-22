using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IZona
    {
        List<Zona> GetZonas();
         Zona GetZonaById(int id);
         void AddZona(Zona zona);
         void UpdateZona(Zona zona);
         void DeleteZona(int id);
    }
}
