using Ecommerce.Infraestructura.Database.Entidades;

namespace Ecommerce.Infraestructura.Repositorios.Estados
{
    public interface IEstadosRepository
    {
        List<EstadoEntity> GetAll();
        EstadoEntity Get(int id);
        EstadoEntity Insert(EstadoEntity entidad);
        EstadoEntity Update(EstadoEntity entidad);
        EstadoEntity Delete(EstadoEntity entidad);
    }
}
