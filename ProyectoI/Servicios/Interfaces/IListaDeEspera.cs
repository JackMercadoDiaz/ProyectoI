using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces

{
    public interface IListaDeEspera
    {
     public List<ListaDeEspera> GetAllListasDeEsperas();
     public ListaDeEspera GetListaDeEsperaById(int listaDeEsperaId);
     
        
     public ListaDeEspera CreateListaDeEspera(ListaDeEspera listaDeEspera);
     public ListaDeEspera UpdateListaDeEspera(int listaDeEsperaId, ListaDeEspera listaDeEspera);
     void DeleteListaDeEspera(int listaDeEsperaId);
    }
}
