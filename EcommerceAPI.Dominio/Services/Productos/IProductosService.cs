using EcommerceAPI.Comunes.Clases.Contratos.Productos;

namespace EcommerceAPI.Dominio.Services.Productos
{
    public interface IProductosService
    {
        List<ProductoContract> GetAll();

        ProductoContract Get(int id);

        ProductoContract Insert(ProductoContract cliente);

        ProductoContract Update(ProductoContract cliente);

        void Delete(int id);
    }
}
