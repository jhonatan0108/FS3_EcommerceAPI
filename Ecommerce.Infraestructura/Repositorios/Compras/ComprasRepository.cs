using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Compras
{
    public class ComprasRepository : BaseRepository, IComprasRepository
    {
        public ComprasRepository(EcommerceContext context): base(context) {}

        public List<CompraEntity> GetAll()
        {
            return _context.Compras.ToList();
        }

        public CompraEntity Get(int id)
        {
            return _context.Compras.Find(id);
        }

        public CompraEntity Insert(CompraEntity entidad)
        {
            _context.Compras.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public CompraEntity Update(CompraEntity entidad)
        {
            _context.Compras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public CompraEntity Delete(CompraEntity entidad)
        {
            _context.Compras.Remove(entidad);
            _context.SaveChanges();
            return new CompraEntity();
        }
    }
}
