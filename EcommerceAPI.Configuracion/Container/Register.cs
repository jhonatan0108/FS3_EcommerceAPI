using AutoMapper;
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
            #region [Inyectar dependencia de AutoMapper]
            var configMapper = new MapperConfiguration(cfg => cfg.AddProfile(new PerfilAutoMapper()));
            var mapper = configMapper.CreateMapper();
            services.AddSingleton(mapper);
            #endregion
            #region [Inyectar dependencia de contexto de BD]
            services.AddDbContext<EcommerceContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SQLConnection"));
            });
            #endregion
            #region [Configuracion de CORS]
            services.AddCors(options =>
            {
                options.AddPolicy("PoliticaCors", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            #endregion
        }
    }
}
