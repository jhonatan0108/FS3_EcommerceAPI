using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        List<ProductoEntity> GetAll();
        ProductoEntity Get(int id);
        ProductoEntity Insert(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        ProductoEntity Delete(ProductoEntity entidad);
    }
}
