using EcommerceAPI.Configuracion.Container;

namespace EcommerceApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            /* IMPORTANTE!
             * a continuacion: llamada al metodo personalizado Configuracíon de la clase propia Register.
             * Antes de construir la variable app de la plantilla, se debe llamar al metodo Configuracion de Register para que agregue la configuracion personalizada. */

            Register.Configuracion(builder.Services, builder.Configuration);

            var app = builder.Build(); 

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}