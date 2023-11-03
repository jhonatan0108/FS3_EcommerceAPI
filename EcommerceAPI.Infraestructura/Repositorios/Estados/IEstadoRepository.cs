using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public interface IEstadoRepository
    {
        List<EstadoEntity> GetAll();

        EstadoEntity Get(int id);

        EstadoEntity Insert(EstadoEntity entity);

        EstadoEntity Update(EstadoEntity entity);

        void Delete(EstadoEntity entity);
    }
}
