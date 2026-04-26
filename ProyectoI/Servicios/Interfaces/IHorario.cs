using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IHorario
    {
        //reads
        public List<Horario> GetAllHorario();
        public Horario GetHorarioById(int id);
        //writes
        public Horario CreateHorario(Horario horario);
        public Horario UpdateHorario(int horarioId, Horario horario);
        public void DeleteHorario(int horarioId);
    }
}
