using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Helpers.Cifrado;
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

        public IActionResult GetAll()
        {
            List<ClienteContract> lista = _clientesService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Get(int id)
        {
            ClienteContract cliente = _clientesService.Get(id);
            if (cliente != null)
            {
                return new JsonResult(cliente) { StatusCode = 200 };
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult Delete(int id)
        {
            _clientesService.Delete(id);
            //Regresa un statusCode 204 (No content)
            return NoContent();
        }

        [HttpPost]
        [Route("CrearCuenta")]
        public IActionResult SignUp(ClienteContract cliente)
        {
            _clientesService.Insert(cliente);
            var datos = new
            {
                Nombre_de_usuario = $"{cliente.nombre}",
                Correo_de_usuario = $"{cliente.correo}"
            };

            //Regresa un statusCode 201 (created)
            return CreatedAtAction("SignUp", datos);
        }

        [HttpPost]
        [Route("InciarSesion")]
        public IActionResult Login(string password, string email)
        {
            (ClienteContract cliente, string contraseña_ecriptada, byte[] salt) = _clientesService.FindByEmail(email);
            if (cliente != null)
            {
                bool resultado = Encriptador.ComparePasswords(password, contraseña_ecriptada, salt);
                if (resultado)
                {
                    return Ok();
                }
                else
                {
                    //Regresa un statusCode 404 (not found)
                    return NotFound();
                }
            }
            return NotFound();
        }
    }
}
