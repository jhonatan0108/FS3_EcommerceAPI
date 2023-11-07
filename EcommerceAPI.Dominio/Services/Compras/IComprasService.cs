using EcommerceAPI.Comunes.Clases.Contratos.Compras;

namespace EcommerceAPI.Dominio.Services.Compras
{
    public interface IComprasService
    {
        List<CompraContract> GetClientPurchases(int cliente);

        List<CompraContract> GetAll();

        CompraContract Get(int id);

        CompraContract Insert(CompraContract compra);

        CompraContract Update(CompraContract compra);

        void Delete(int id);
    }
}
