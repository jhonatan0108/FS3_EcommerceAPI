using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly EcommerceContext _context;

        public ProductosRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(ProductoEntity entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductoEntity> GetProductosPorFechas()
        {
            throw new NotImplementedException();
        }

        public ProductoEntity Insert(ProductoEntity entidad)
        {
            throw new NotImplementedException();
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            throw new NotImplementedException();
        }
    }
}
