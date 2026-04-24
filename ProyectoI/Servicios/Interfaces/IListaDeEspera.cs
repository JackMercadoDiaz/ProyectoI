using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces

{
    public interface IListaDeEspera
    {
     public List<ListaDeEspera> GetAllListasDeEspera();
     public ListaDeEspera GetListaDeEsperaById(int id);
     
        
     public ListaDeEspera CreateListaDeEspera(ListaDeEspera listaDeEspera);
     public ListaDeEspera UpdateListaDeEspera(ListaDeEspera listaDeEspera);
     void DeleteListaDeEspera(int id);
    }
}
