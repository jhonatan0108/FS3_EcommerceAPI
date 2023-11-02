using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.DetalleCompras
{
    public class DetalleComprasRepository : BaseRepository, IDetalleComprasRepository
    {
        public DetalleComprasRepository(EcommerceContext context): base(context) {}

        public List<DetalleCompraEntity> GetAll()
        {
            return _context.DetalleCompras.ToList();
        }

        public DetalleCompraEntity Get(int id)
        {
            return _context.DetalleCompras.Find(id);
        }

        public DetalleCompraEntity Insert(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public DetalleCompraEntity Update(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public DetalleCompraEntity Delete(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Remove(entidad);
            _context.SaveChanges();
            return new DetalleCompraEntity();
        }
    }
}
