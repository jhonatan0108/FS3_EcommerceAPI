using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Comunes.Clases.Contratos.Compras;
using Ecommerce.Dominio.Services.Clientes;
using Ecommerce.Dominio.Services.Compras;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly IComprasService _comprasService;

        public ComprasController(IComprasService comprasService)
        {
            _comprasService = comprasService;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<CompraContract> lista = _comprasService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            CompraContract cliente = _comprasService.Get(id);

            if (cliente != null) return Ok(cliente);

            return BadRequest();
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromBody] CompraContract contract)
        {
            return Ok(_comprasService.Insert(contract));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] CompraContract contract)
        {
            return Ok(_comprasService.Update(contract));
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_comprasService.Delete(id));
        }
    }
}
