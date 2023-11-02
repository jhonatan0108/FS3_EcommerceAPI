using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Dominio.Services.Clientes;
using EcommerceAPI.Dominio.Services.Estados;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadosService _estadosService;
        public EstadoController(IEstadosService estadosService)
        {
            _estadosService = estadosService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<EstadoContract> lista = _estadosService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            EstadoContract estado = _estadosService.Get(id);
            if (estado != null)
                return Ok(estado);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(EstadoContract estados)
        {
            EstadoContract _estado = _estadosService.Insert(estados);
            return Ok(_estado);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(EstadoContract estado)
        {
            EstadoContract _estado = _estadosService.Update(estado);
            return Ok(_estado);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _estadosService.Delete(id);
            return Ok();
        }

    }
}
