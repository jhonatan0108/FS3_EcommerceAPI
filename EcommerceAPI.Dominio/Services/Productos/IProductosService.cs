
using EcommerceAPI.Comunes.Clases.Contratos.Productos;



namespace EcommerceAPI.Dominio.Services.Productos
{
    public interface IProductosService
    {
        List<ProductoContract> GetAll();

        ProductoContract Get(int id);

        ProductoContract Insert(ProductoContract producto);

        ProductoContract Update(ProductoContract producto);

        void Delete(int id);
    }
}
