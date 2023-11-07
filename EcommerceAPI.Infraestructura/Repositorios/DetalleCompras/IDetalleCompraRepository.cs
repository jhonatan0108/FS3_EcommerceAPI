using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public interface IDetalleCompraRepository
    {
        List<DetalleCompraEntity> GetAll();
        List<DetalleCompraEntity> GetByCompra(int idCompra);

        DetalleCompraEntity Get(int id);

        DetalleCompraEntity Insert(DetalleCompraEntity entity);

        DetalleCompraEntity Update(DetalleCompraEntity entity);

        void Delete(DetalleCompraEntity entity);
    }
}
