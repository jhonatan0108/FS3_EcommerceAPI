using Ecommerce.Comunes.Clases.Contratos.DetalleCompras;

namespace Ecommerce.Dominio.Services.DetalleCompras
{
    public interface IDetalleComprasService
    {
        List<DetalleCompraContract> GetAll();
        DetalleCompraContract Get(int id);
        DetalleCompraContract Insert(DetalleCompraContract detalleCompra);
        DetalleCompraContract Update(DetalleCompraContract detalleCompra);
        DetalleCompraContract Delete(int id);
    }
}
