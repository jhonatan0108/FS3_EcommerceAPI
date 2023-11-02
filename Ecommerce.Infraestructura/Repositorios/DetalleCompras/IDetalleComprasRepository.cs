using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.DetalleCompras
{
    public interface IDetalleComprasRepository
    {
        List<DetalleCompraEntity> GetAll();
        DetalleCompraEntity Get(int id);
        DetalleCompraEntity Insert(DetalleCompraEntity entidad);
        DetalleCompraEntity Update(DetalleCompraEntity entidad);
        DetalleCompraEntity Delete(DetalleCompraEntity entidad);
    }
}
