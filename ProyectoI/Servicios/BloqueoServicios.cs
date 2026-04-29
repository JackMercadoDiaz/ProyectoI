using ProyectoI.Entidades;
using ProyectoI.Servicios.Interfaces;
using ProyectoI.RestauranteDbContext;
using ProyectoI.DTOs;

namespace ProyectoI.Servicios
{
    public class BloqueoServicios : IBloqueo
    {
        private readonly ResturanteDbContext _RestauranteDbcontext;

        public BloqueoServicios(ResturanteDbContext restauranteDbContext)
        {
            _RestauranteDbcontext = restauranteDbContext;
        }

        

        public List<Bloqueo> GetAllBloqueos()
        {
            return _RestauranteDbcontext.Bloqueos.ToList();
        }

        public Bloqueo GetBloqueoById(int bloqueoId)
        {
            return _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
        }

        

        public Bloqueo CreateBloqueoMesa(BloqueoMesaDto dto)
        {
            var mesa = _RestauranteDbcontext.Mesas.Find(dto.MesaId);
            mesa.Estado = "En Mantenimiento";

            var bloqueo = new Bloqueo
            {
                MesaId = dto.MesaId,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Motivo = dto.Motivo,
                Estado = "Activo"
            };

            _RestauranteDbcontext.Bloqueos.Add(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;
        }

        public Bloqueo CreateBloqueoZona(BloqueoZonaDto dto)
        {
            var mesas = _RestauranteDbcontext.Mesas
                .Where(m => m.ZonaId == dto.ZonaId)
                .ToList();

            foreach (var mesa in mesas)
            {
                mesa.Estado = "En Mantenimiento";
            }

            var bloqueo = new Bloqueo
            {
                ZonaId = dto.ZonaId,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Motivo = dto.Motivo,
                Estado = "Activo"
            };

            _RestauranteDbcontext.Bloqueos.Add(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;
        }

        public Bloqueo DeleteBloqueoMesa(int bloqueoId)
        {
            var bloqueo = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            if (bloqueo == null) return null;

            var mesa = _RestauranteDbcontext.Mesas.Find(bloqueo.MesaId);
            if (mesa != null) mesa.Estado = "Disponible";

            _RestauranteDbcontext.Bloqueos.Remove(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;
        }

        public Bloqueo DeleteBloqueoZona(int bloqueoId)
        {
            var bloqueo = _RestauranteDbcontext.Bloqueos.Find(bloqueoId);
            if (bloqueo == null) return null;

            var mesas = _RestauranteDbcontext.Mesas
                .Where(m => m.ZonaId == bloqueo.ZonaId)
                .ToList();

            foreach (var mesa in mesas)
            {
                mesa.Estado = "Disponible";
            }

            _RestauranteDbcontext.Bloqueos.Remove(bloqueo);
            _RestauranteDbcontext.SaveChanges();
            return bloqueo;  
        }

        

        public bool VerificarBloqueo(int mesaId, DateTime fechaHora)
        {
            return _RestauranteDbcontext.Bloqueos.Any(b =>
                b.MesaId == mesaId &&
                fechaHora >= b.FechaInicio &&
                fechaHora <= b.FechaFin &&
                b.Estado == "Activo");
        }
    }
}