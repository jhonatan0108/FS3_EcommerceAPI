using AutoMapper;
using Ecommerce.Dominio.Services.Clientes;
using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Repositorios.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System.Reflection;

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
            #region [Inyeccion de Dependencias]
            services.AddScoped<IClientesRepository, ClientesRepository>();
            services.AddScoped<IClientesService, ClientesService>();
            /*
            var assembliesToScan = new[]
             {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("ECommerceAPI.Dominio"),
                Assembly.Load("ECommerceAPI.Infraestructura"),
                Assembly.Load("ECommerceAPI.Comunes"),
            };
            services.RegisterAssemblyPublicNonGenericClasses(assembliesToScan)
                .Where(c => c.Name.EndsWith("Repository") ||
                       c.Name.EndsWith("Service"))
                .AsPublicImplementedInterfaces();*/
            #endregion
        }
    }
}
