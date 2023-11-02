using Microsoft.Extensions.Configuration;

namespace EcommerceAPI.Dominio.Services.Comunes
{
    public class JwtService : IJwtService
    {

        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerarToken(string id)
        {
            throw new NotImplementedException();
        }
    }
}
