using ProyectoI.Entidades;
namespace ProyectoI.Servicios.Interfaces
{
    public interface IHorario
    {
        //reads
        public List<Horario> GetAllHorario();
        public Horario GetHorarioById(int id);
        //writes
        public Horario CreateHorario(string nombre, string diaSemana, TimeOnly horaInicio, TimeOnly horaFin);
        public string ValidarHorario(DateTime fecha, int horarioId);
    }
}
