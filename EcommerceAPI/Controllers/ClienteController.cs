using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Dominio.Services.Clientes;
using EcommerceAPI.Dominio.Services.Comunes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;
        private readonly IJwtService _jwtService;
        public ClienteController(IClientesService clientesService, IJwtService jwtService)
        {
            _clientesService = clientesService;
            _jwtService = jwtService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            string token = _jwtService.GenerarToken("123a1sd");
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
