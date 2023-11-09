

using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface IComprasRepository
    {
       List<CompraEntity> GetAll();

        CompraEntity Get(int id);

        CompraEntity  Insert(CompraEntity entity);

        CompraEntity Update(CompraEntity entity);   
        void Delete(CompraEntity entity);


    }
}
