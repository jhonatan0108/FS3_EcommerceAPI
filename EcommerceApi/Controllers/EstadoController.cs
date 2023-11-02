using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Comunes.Clases.Contratos.Estados;
using Ecommerce.Dominio.Services.Clientes;
using Ecommerce.Dominio.Services.Estados;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadosService _estadosService;

        public EstadoController(IEstadosService clientesService)
        {
            _estadosService = clientesService;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<EstadoContract> lista = _estadosService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            EstadoContract contrato = _estadosService.Get(id);

            if (contrato != null) return Ok(contrato);

            return BadRequest();
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromBody] EstadoContract contract)
        {
            return Ok(_estadosService.Insert(contract));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] EstadoContract contract)
        {
            return Ok(_estadosService.Update(contract));
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_estadosService.Delete(id));
        }
    }
}
