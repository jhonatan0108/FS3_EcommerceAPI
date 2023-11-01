using EcommerceAPI.Comunes.Clases.Contratos.Productos;
namespace EcommerceAPI.Dominio.Services.Productos
{
    public interface IProductoService
    {
        void Delete(int id);

        List<ProductoContract> GetAll();

        List<ProductoContract> GetByCategory(string category);

        ProductoContract GetById(int id);

        List<ProductoContract> GetByPriceRange(decimal minPrice, decimal maxPrice);

        ProductoContract Insert(ProductoContract producto);

        ProductoContract Update(ProductoContract producto);
    }
}
