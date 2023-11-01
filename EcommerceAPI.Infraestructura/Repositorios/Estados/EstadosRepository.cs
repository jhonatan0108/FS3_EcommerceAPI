

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

        public void Delete(EstadoEntity estadoEntity)
        {
            _context.Estado.Remove(estadoEntity);
            _context.SaveChanges();
        }

        public EstadoEntity Get(int id)
        {

            return _context.Estado.Find(id);

        }

        public List<EstadoEntity> GetAll()
        {

            return _context.Estado.ToList();
        }

        public EstadoEntity Insert(EstadoEntity entity)
        {
            _context.Estado.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public EstadoEntity Update(EstadoEntity entity)
        {
          _context.Estado.Update(entity);
            _context.SaveChanges(); 
            return entity;  
        }
    }
}
