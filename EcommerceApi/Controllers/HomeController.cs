using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public string ObtenerHorarios()
        {
            return "Esto es una prueba";
        }

        [HttpPost]
        [Route("imprimir")]
        public string ImprimirNombre(string nombre)
        {
            return $"Este es el nombre: {nombre}";
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public string EliminarEmpleado(int id)
        {
            return $"Se elimino correctamente el empleado con id: {id}";
        }
    }
}
