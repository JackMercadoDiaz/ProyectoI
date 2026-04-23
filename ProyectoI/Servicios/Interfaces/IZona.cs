using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IZona
    {
         public List<Zona> GetAllZonas ();
         public Zona GetZonaById (int id);
         public Zona createZona (Zona zona);
         public Zona updateZona (int zonaId,Zona zona);
         public void deleteZona(int zonaId);
    }
}
