using EcommerceAPI.Configuracion.Container;

namespace EcommerceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new builder for the web application
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Add controllers and related services to the dependency injection container
            builder.Services.AddControllers();

            // Add services required for Swagger/OpenAPI documentation
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Add services for authentication with JWT
            builder.Services.AddAuthentication().AddJwtBearer();

            // Register custom services and configurations using a separate method
            Register.Configuracion(builder.Services, builder.Configuration);

            // Build the web application
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            // If the application is running in the development environment
            if (app.Environment.IsDevelopment()) //launchSettings.json
            {
                // Enable Swagger and Swagger UI for API documentation
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Enable HTTPS redirection for added security
            app.UseHttpsRedirection();

            // Enable authorization middleware
            app.UseAuthorization();

            // Map controllers to handle incoming HTTP requests
            app.MapControllers();

            // Start the application
            app.Run();
        }
    }
}
