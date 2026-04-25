using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces

{
    public interface IListaDeEspera
    {
     public List<ListaDeEspera> GetAllListasDeEsperas();
     public ListaDeEspera GetListaDeEsperaById(int id);
     
        
     public ListaDeEspera CreateListaDeEspera(ListaDeEspera listaDeEspera);
     public ListaDeEspera UpdateListaDeEspera(int id, ListaDeEspera listaDeEspera);
     void DeleteListaDeEspera(int id);
    }
}
