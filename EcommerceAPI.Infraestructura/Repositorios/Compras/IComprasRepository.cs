using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface IComprasRepository
    {
        List<CompraEntity> GetClientPurchases(int cliente);

        List<CompraEntity> GetAll();

        CompraEntity Get(int id);

        CompraEntity Insert(CompraEntity compra);

        CompraEntity Update(CompraEntity compra);

        void Delete(CompraEntity compra);
    }
}
