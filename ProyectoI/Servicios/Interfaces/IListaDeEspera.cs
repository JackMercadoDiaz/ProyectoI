using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces

{
    public interface IListaDeEspera
    {
        // reads
        public List<ListaDeEspera> GetAllListasDeEsperas();
     public ListaDeEspera GetListaDeEsperaById(int id);
        // writes
        public ListaDeEspera CreateListaDeEspera(ListaDeEspera listaDeEspera);
     public ListaDeEspera UpdateListaDeEspera(int id, ListaDeEspera listaDeEspera);
     void DeleteListaDeEspera(int id);
        public ListaDeEspera AtenderSiguienteEnLista(int horario, string fecha, int zonaId);
        public ListaDeEspera CancelarEspera(int listaDeEsperaId);
    }
}
