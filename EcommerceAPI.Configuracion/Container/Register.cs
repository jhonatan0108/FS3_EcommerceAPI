using EcommerceAPI.Infraestructura.Database.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceAPI.Configuracion.Container
{
    public class Register
    {
        public static void Configuracion(IServiceCollection services, IConfiguration configuration)
        {
            #region [Inyectar dependencia de contexto de BD]
            services.AddDbContext<EcommerceContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            #endregion


        }
    }
}
