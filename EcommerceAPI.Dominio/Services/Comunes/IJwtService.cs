using EcommerceAPI.Comunes.Clases.Contratos.Clientes;

namespace EcommerceAPI.Dominio.Services.Comunes
{
    public interface IJwtService
    {
        string GenerarToken(ClienteContract cliente);
    }
}
