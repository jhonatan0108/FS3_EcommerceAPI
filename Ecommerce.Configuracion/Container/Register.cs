using Ecommerce.Infraestructura.Database.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceAPI.Configuracion.Container
{
    public class Register
    {
        public static void Configuracion(IServiceCollection service, IConfiguration configuration)
        {
            #region [Inyectar dependencia del contexto de bd]
            service.AddDbContext<EcommerceContext>( options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EcommerceDb"));
            });
            #endregion [Inyectar dependencia del contexto de bd]
        }
    }
}
