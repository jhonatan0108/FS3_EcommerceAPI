using EcommerceAPI.Comunes.Clases.Contratos.Categorias;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Dominio.Services.Estados;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoService _estadoService;
        public EstadoController(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<EstadoContract> lista = _estadoService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Get(int id)
        {
            EstadoContract estado = _estadoService.Get(id);
            if (estado != null)
            {
                return new JsonResult(estado) { StatusCode = 200 };
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult Delete(int id)
        {
            _estadoService.Delete(id);
            return NoContent();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(EstadoContract estadoContract)
        {
            _estadoService.Insert(estadoContract);
            var datos = new
            {
                Descripcion = estadoContract.descripcion,
                Relacion = estadoContract.relacion,
            };

            return CreatedAtAction("Create", datos);
        }

        [HttpPatch]
        [Route("[Action]")]
        public IActionResult Update(EstadoContract estadoContract)
        {
            EstadoContract estadoActualizado = _estadoService.Update(estadoContract);
            return Ok(estadoActualizado);
        }
    }
}
