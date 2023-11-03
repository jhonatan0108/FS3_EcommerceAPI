using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly EcommerceContext _context;

        public EstadoRepository(EcommerceContext context)
        {
            _context = context;
        }

        void IEstadoRepository.Delete(EstadoEntity entity)
        {
            _context.Estados.Remove(entity);
            _context.SaveChanges();
        }

        EstadoEntity IEstadoRepository.Get(int id)
        {
            return _context.Estados.Find(id);
        }

        List<EstadoEntity> IEstadoRepository.GetAll()
        {
            return _context.Estados.ToList();
        }

        EstadoEntity IEstadoRepository.Insert(EstadoEntity entity)
        {
            _context.Estados.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        EstadoEntity IEstadoRepository.Update(EstadoEntity entity)
        {
            _context.Estados.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
