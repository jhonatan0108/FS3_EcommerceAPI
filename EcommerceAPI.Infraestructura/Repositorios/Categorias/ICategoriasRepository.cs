using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Categorias
{
    public interface ICategoriasRepository
    {
        List<CategoriaEntity> GetAll();

        CategoriaEntity Get(int id);

        CategoriaEntity Insert(CategoriaEntity entity);

        CategoriaEntity Update(CategoriaEntity entity);

        void Delete(CategoriaEntity entity);
    }
}
