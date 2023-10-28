using AutoMapper;
using Ecommerce.Infraestructura.Database.Contextos;
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
            var configMapper = new MapperConfiguration(config => config.AddProfile(new PerfilAutoMapper()));
            var mapper = configMapper.CreateMapper();
            services.AddSingleton(mapper);
            #endregion [Inyectar dependencia de AutoMapper]
            #region [Inyectar dependencia del contexto de bd]
            services.AddDbContext<EcommerceContext>( options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EcommerceDb"));
            });
            #endregion [Inyectar dependencia del contexto de bd]
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
            #endregion [Configuracion de CORS]
        }
    }
}
