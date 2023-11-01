

using EcommerceAPI.Comunes.Clases.Contratos.Estados;

namespace EcommerceAPI.Dominio.Services.Estados
{
    public interface IEstadosService
    {
        List<EstadoContract> GetAll();

        EstadoContract Get(int id);
        EstadoContract Insert(EstadoContract estado);

        EstadoContract Update(EstadoContract estado);

        void Delete(int id);

    }
}
