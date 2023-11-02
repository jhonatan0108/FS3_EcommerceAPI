using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Compras
{
    public interface IComprasRepository
    {
        List<CompraEntity> GetAll();
        CompraEntity Get(int id);
        CompraEntity Insert(CompraEntity entidad);
        CompraEntity Update(CompraEntity entidad);
        CompraEntity Delete(CompraEntity entidad);
    }
}
