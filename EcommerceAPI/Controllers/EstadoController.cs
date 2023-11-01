using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Dominio.Services.Estados;
using EcommerceAPI.Infraestructura.Repositorios.Estados;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
         private readonly IEstadosService _estadosService;

        public EstadoController( IEstadosService estadosService)
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
        public IActionResult GetById(int id)
        {
            EstadoContract estadoContract = _estadosService.Get(id);
            if (estadoContract != null)
     
                return Ok(estadoContract);
      
           
            return BadRequest();    

        }
        [HttpPost]
        [Route("[Action]")]
        public IActionResult Insert(EstadoContract estadoContract)
        {
            EstadoContract estado = _estadosService.Insert(estadoContract);
            return Ok(estado);

        }
        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(EstadoContract estadoContract)
        {
            EstadoContract estado = _estadosService.Update(estadoContract);
            return Ok(estado);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult DeleteById(int id)
        {
            _estadosService.Delete(id);
            return Ok();  
        }
    }
}
