using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        List<ProductoEntity> GetAll();
        ProductoEntity GetById(int id);
        List<ProductoEntity> GetByPriceRange(float minPrice, float maxPrice);
        List<ProductoEntity> GetByCategory(int category);
        ProductoEntity Insert(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        void Delete(ProductoEntity entidad);

    }
}
