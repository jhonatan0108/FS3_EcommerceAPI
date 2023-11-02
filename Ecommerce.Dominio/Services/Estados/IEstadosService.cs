using Ecommerce.Comunes.Clases.Contratos.Estados;

namespace Ecommerce.Dominio.Services.Estados
{
    public interface IEstadosService
    {
        List<EstadoContract> GetAll();
        EstadoContract Get(int id);
        EstadoContract Insert(EstadoContract estado);
        EstadoContract Update(EstadoContract estado);
        EstadoContract Delete(int id);
    }
}
