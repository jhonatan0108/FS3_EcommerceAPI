using EcommerceAPI.Comunes.Clases.Contratos.Productos;
namespace EcommerceAPI.Dominio.Services.Productos
{
    public interface IProductoService
    {
        void Delete(int id);

        List<ProductoContract> GetAll();

        List<ProductoContract> GetByCategory(int category);

        ProductoContract GetById(int id);

        ProductoContract Insert(ProductoContract producto);

        public ProductoContract Update(ProductoContract producto);
    }
}
