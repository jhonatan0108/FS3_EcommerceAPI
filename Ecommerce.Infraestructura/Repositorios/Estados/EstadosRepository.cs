using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Estados
{
    public class EstadosRepository : BaseRepository, IEstadosRepository
    {
        public EstadosRepository(EcommerceContext context) : base(context) { }

        public List<EstadoEntity> GetAll()
        {
            return _context.Estados.ToList();
        }

        public EstadoEntity Get(int id)
        {
            return _context.Estados.Find(id);
        }

        public EstadoEntity Insert(EstadoEntity entidad)
        {
            _context.Estados.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public EstadoEntity Update(EstadoEntity entidad)
        {
            _context.Estados.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public EstadoEntity Delete(EstadoEntity entidad)
        {
            _context.Estados.Remove(entidad);
            _context.SaveChanges();
            return new EstadoEntity();
        }
    }
}
