using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces

{
    public interface IListaDeEspera
    {
     public List<ListaDeEspera> getAllListasDeEsperas();
     public ListaDeEspera getListaDeEsperaById(int id);
     
        
     public ListaDeEspera createListaDeEspera(ListaDeEspera listaDeEspera);
     public ListaDeEspera updateListaDeEspera(int id, ListaDeEspera listaDeEspera);
     void deleteListaDeEspera(int id);
    }
}
