using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;
namespace ProyectoI.Servicios
{
    public class HorarioServicios : IHorario
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public HorarioServicios(ResturanteDbContext resturanteDbContext)
        {
            _RestauranteDbcontext = resturanteDbContext;
        }
        public Horario createHorario(Horario horario)
        {
            _RestauranteDbcontext.Horarios.Add(horario);
            _RestauranteDbcontext.SaveChanges();
            return horario;
        }

        public void deleteHorario(int horarioId)
        {
            var result = _RestauranteDbcontext.Horarios.Find(horarioId);
            _RestauranteDbcontext.Horarios.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Horario> GetAllHorario()
        {
            return _RestauranteDbcontext.Horarios.ToList();
        }

        public Horario GetHorarioById(int id)
        {
            var result = _RestauranteDbcontext.Horarios.Find(id);
            return result;
        }

        public Horario updateHorario(int horarioId, Horario horario)
        {
            var result = _RestauranteDbcontext.Horarios.Find(horarioId);
            result.horarioId = horario.horarioId;
            _RestauranteDbcontext.Horarios.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;

        }
    }
}
