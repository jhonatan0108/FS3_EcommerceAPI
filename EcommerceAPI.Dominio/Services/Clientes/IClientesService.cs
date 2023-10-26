using EcommerceAPI.Comunes.Clases.Contratos.Clientes;

namespace EcommerceAPI.Dominio.Services.Clientes
{
    public interface IClientesService
    {
        List<ClienteContract> GetAll();

        ClienteContract Get(int id);

        ClienteContract Insert(ClienteContract cliente);

        ClienteContract Update(ClienteContract cliente);

        void Delete(int id);
    }
}
