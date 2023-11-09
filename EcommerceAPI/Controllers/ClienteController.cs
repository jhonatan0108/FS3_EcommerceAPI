using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Dominio.Services.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;
        public ClienteController(IClientesService  clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<ClienteContract> lista = _clientesService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            ClienteContract cliente = _clientesService.Get(id);
            if (cliente != null)
                return Ok(cliente);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(ClienteContract cliente)
        {
            ClienteContract _cliente = _clientesService.Insert(cliente);
            return Ok(_cliente);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ClienteContract cliente)
        {
            ClienteContract _cliente = _clientesService.Update(cliente);
            return Ok(_cliente);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _clientesService.Delete(id);
            return Ok();
        }
    }
}
