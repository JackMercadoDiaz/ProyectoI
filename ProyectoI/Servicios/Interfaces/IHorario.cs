using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IHorario
    {
        //reads
        public List<Horario> getAllHorario();
        public Horario getHorarioById(int id);
        //writes
        public Horario createHorario(Horario horario);
        public Horario updateHorario(int horarioId, Horario horario);
        public void deleteHorario(int horarioId);
    }
}
