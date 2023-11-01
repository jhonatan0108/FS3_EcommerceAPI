using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        List<ProductoEntity> GetAll();
        ProductoEntity GetById(int id);
        List<ProductoEntity> GetByPriceRange(decimal minPrice, decimal maxPrice);
        ProductoEntity Insert(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        void Delete(ProductoEntity entidad);

    }
}
