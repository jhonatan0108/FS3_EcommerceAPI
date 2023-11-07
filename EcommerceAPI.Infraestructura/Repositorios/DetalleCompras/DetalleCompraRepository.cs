using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public class DetalleCompraRepository : IDetalleCompraRepository
    {
        private readonly EcommerceContext _context;

        public DetalleCompraRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(DetalleCompraEntity entity)
        {
            _context.DetalleCompras.Remove(entity);
            _context.SaveChanges();
        }

        public DetalleCompraEntity Get(int id)
        {
            return _context.DetalleCompras.Find(id);
        }

        public List<DetalleCompraEntity> GetAll()
        {
            return _context.DetalleCompras.ToList();
        }

        public DetalleCompraEntity Insert(DetalleCompraEntity entity)
        {
            _context.DetalleCompras.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public DetalleCompraEntity Update(DetalleCompraEntity entity)
        {
            _context.DetalleCompras.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        List<DetalleCompraEntity> IDetalleCompraRepository.GetByCompra(int idCompra)
        {
            return _context.DetalleCompras.Where(d => d.id_compra == idCompra).ToList();
        }
    }
}
