using Ecommerce.Comunes.Clases.Contratos.Productos;

namespace Ecommerce.Dominio.Services.Productos
{
    public interface IProductosService
    {
        List<ProductoContract> GetAll();
        ProductoContract Get(int id);
        ProductoContract Insert(ProductoContract cliente);
        ProductoContract Update(ProductoContract cliente);
        ProductoContract Delete(int id);
    }
}
