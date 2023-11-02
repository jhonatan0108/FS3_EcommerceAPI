namespace EcommerceAPI.Dominio.Services.Comunes
{
    public interface IJwtService
    {
        string GenerarToken(string id);
    }
}
