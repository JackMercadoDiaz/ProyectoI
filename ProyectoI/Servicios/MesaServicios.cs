using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;

namespace ProyectoI.Servicios
{
    public class MesaServicios : IMesa
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;
        public MesaServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }
        public Mesa CreateMesa(Mesa mesa)
        {
           _RestauranteDbcontext.Mesas.Add(mesa);
              _RestauranteDbcontext.SaveChanges();
            return mesa;
        }

        public void DeleteMesa(int mesaId)
        {
            var result = _RestauranteDbcontext.Mesas.Find(mesaId);
            _RestauranteDbcontext.Mesas.Remove(result);
            _RestauranteDbcontext.SaveChanges();
        }

        public List<Mesa> GetAllMesas()
        {
            return _RestauranteDbcontext.Mesas.ToList();
        }

        public Mesa GetMesaById(int mesaId)
        {
            var result = _RestauranteDbcontext.Mesas.Find(mesaId);
            return result;
        }

        public Mesa UpdateMesa(int mesaId, Mesa mesa)
        {
            var result = _RestauranteDbcontext.Mesas.Find(mesaId);
            result.MesaId = mesa.MesaId;
            _RestauranteDbcontext.Mesas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
        public Mesa CambiarEstadoMesa(int mesaId, string estado)
        {
            var mesa = _RestauranteDbcontext.Mesas.Find(mesaId);
            mesa.Estado = estado;
            _RestauranteDbcontext.SaveChanges();
            return mesa;
        }
    }
}
