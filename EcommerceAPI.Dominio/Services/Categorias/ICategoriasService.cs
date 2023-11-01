using EcommerceAPI.Comunes.Clases.Contratos.Categorias;

namespace EcommerceAPI.Dominio.Services.Categorias
{
    public interface ICategoriasService
    {
        List<CategoriaContract> GetAll();

        CategoriaContract Get(int id);

        CategoriaContract Insert(CategoriaContract entity);

        CategoriaContract Update(CategoriaContract entity);

        void Delete(int id);
    }
}
