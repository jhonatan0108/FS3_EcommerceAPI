

using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.ComprasDetalle
{
    public interface IComprasDetalleRepository
    {
       List<CompraDetalleEntity> GetAll();

        CompraDetalleEntity Get(int id);

        CompraDetalleEntity Insert(CompraDetalleEntity entity);

        CompraDetalleEntity Update(CompraDetalleEntity entity);   
        void Delete(CompraDetalleEntity entity);

       
    }
}
