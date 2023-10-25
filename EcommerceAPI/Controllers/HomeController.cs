using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        
        [HttpGet]
        [Route("[Action]")]
        public string ObtenerHorarios()
        {
            return "Esto es una prueba";
        }

        [HttpPost]
        [Route("Imprimir")]
        public string ImprimirNombre(string nombre)
        {
            return $"Este es el nombre: {nombre}";
        }

        [HttpDelete]
        [Route("Eliminar/{id}")]
        public string EliminarEmpleado(int id)
        {
            return $"Se elimino correctamente el empleado con id: {id}";
        }
    }
}
