using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompra;

namespace EcommerceAPI.Dominio.Services.DetalleCompra
{
    public interface IDetalleCompraService
    {
        List<DetalleCompraContract> GetAll();

        DetalleCompraContract Get(int id);

        DetalleCompraContract Insert(DetalleCompraContract carrito);

        DetalleCompraContract Update(DetalleCompraContract carrito);

        void Delete(int id);
    }
}

