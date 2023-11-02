using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : BaseRepository, IProductosRepository
    {
        public ProductosRepository(EcommerceContext context) : base(context) { }

        public List<ProductoEntity> GetAll()
        {
            return _context.Productos.ToList();
        }

        public ProductoEntity Get(int id)
        {
            return _context.Productos.Find(id);
        }

        public ProductoEntity Insert(ProductoEntity entidad)
        {
            _context.Productos.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            _context.Productos.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public ProductoEntity Delete(ProductoEntity entidad)
        {
            _context.Productos.Remove(entidad);
            _context.SaveChanges();
            return new ProductoEntity();
        }
    }
}
