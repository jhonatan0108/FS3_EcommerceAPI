
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public interface IEstadosRepository
    {
        
        List<EstadoEntity> GetAll();

        EstadoEntity Get(int id);
        EstadoEntity Insert(EstadoEntity estadoEntity);

        EstadoEntity Update(EstadoEntity estadoEntity);

        void Delete(EstadoEntity estadoEntity);

    }
}
