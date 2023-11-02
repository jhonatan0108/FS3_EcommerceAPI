using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.DetalleComprasRepository;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompras
{
    public class DetalleComprasRepository : IDetalleComprasRepository
    {
        private readonly EcommerceContext _context;

        public DetalleComprasRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Remove(entidad);
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
    }
}
