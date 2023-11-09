
using EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Dominio.Services.ComprasDetalle
{
    public interface IComprasDetalleService
    {
        List<CompraDetalleContract> GetAll();

        CompraDetalleContract Get(int id);
        

        CompraDetalleContract Insert(CompraDetalleContract compra);

        CompraDetalleContract Update(CompraDetalleContract compra);

        void Delete(int id);
       
    }
}
