using EcommerceAPI.Comunes.Clases.Contratos.Productos;
namespace EcommerceAPI.Dominio.Services.Productos
{
    public interface IProductoService
    {
        void Delete(int id);

        List<ProductoContract> GetAll();

        List<ProductoContract> GetByCategory(int category);

        ProductoContract GetById(int id);
        List<ProductoContract> GetByPriceRange(float minPrice, float maxPrice)

        ProductoContract Insert(ProductoContract producto);

        ProductoContract Update(ProductoContract producto);
    }
}
