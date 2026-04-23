using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IHorario
    {
        //reads
        public List<Horario> GetAllHorario();
        public Horario GetHorarioById(int id);
        public Horario GetHorarioByName(string name);
        //writes
        public Horario createHorario(Horario horario);
        public Horario updateHorario(int horarioId, Horario horario);
        public void deleteHorario(int horarioId);
    }
}
