using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public class EstadosRepository : IEstadosRepository
    {
        private readonly EcommerceContext _context;

        public EstadosRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(EstadoEntity entidad)
        {
            _context.Estados.Remove(entidad);
            _context.SaveChanges();
        }

        public EstadoEntity Get(int id)
        {
            return _context.Estados.Find(id);
        }

        public List<EstadoEntity> GetAll()
        {
            return _context.Estados.ToList();
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
    }
}
