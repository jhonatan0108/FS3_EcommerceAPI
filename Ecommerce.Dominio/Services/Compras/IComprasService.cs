using Ecommerce.Comunes.Clases.Contratos.Compras;

namespace Ecommerce.Dominio.Services.Compras
{
    public interface IComprasService
    {
        List<CompraContract> GetAll();
        CompraContract Get(int id);
        CompraContract Insert(CompraContract cliente);
        CompraContract Update(CompraContract cliente);
        CompraContract Delete(int id);
    }
}
