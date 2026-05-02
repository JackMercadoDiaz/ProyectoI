using Microsoft.EntityFrameworkCore;
using ProyectoI.Entidades;
using ProyectoI.RestauranteDbContext;
using ProyectoI.Servicios.Interfaces;

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
            var mesa = _RestauranteDbcontext.Mesas.Find(mesaId);
            if (mesa != null)
            {
                _RestauranteDbcontext.Mesas.Remove(mesa);
                _RestauranteDbcontext.SaveChanges();
            }
        }

        public List<Mesa> GetAllMesas()
        {
            return _RestauranteDbcontext.Mesas.ToList();
        }

        public Mesa GetMesaById(int mesaId)
        {
            var mesa = _RestauranteDbcontext.Mesas.Find(mesaId);
            if (mesa == null || mesa.Estado)
                return null;
            return mesa;
        }

        public Mesa UpdateMesa(int mesaId, Mesa mesa)
        {
            var result = _RestauranteDbcontext.Mesas.Find(mesaId);
            result.Id = mesa.Id;
            _RestauranteDbcontext.Mesas.Update(result);
            _RestauranteDbcontext.SaveChanges();
            return result;
        }
        public Mesa CambiarEstadoMesa(int mesaId, string estado)
        {
            var mesa = _RestauranteDbcontext.Mesas.Find(mesaId);
            mesa.Estado = estado == "activo";
            _RestauranteDbcontext.SaveChanges();
            return mesa;
        }
    }
}
