using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Dominio.Services.Clientes
{
    public interface IClientesService
    {
        List<ClienteContract> GetAll();

        ClienteContract Get(int id);

        ClienteContract Insert(ClienteContract cliente);

        ClienteContract Update(ClienteContract cliente);
        (ClienteContract?, string, byte[]) FindByEmail(string email);

        void Delete(int id);
    }
}
