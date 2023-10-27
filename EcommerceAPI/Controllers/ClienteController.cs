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
        public ClienteController(IClientesService clientesService)
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
    }
}
