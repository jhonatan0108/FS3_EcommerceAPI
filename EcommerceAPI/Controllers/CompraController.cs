using EcommerceAPI.Comunes.Clases.Contratos.Compras;
using EcommerceAPI.Dominio.Services.Compras;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly IComprasService _comprasService;

        public CompraController(IComprasService comprasService)
        {
            _comprasService = comprasService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CompraContract> compras = _comprasService.GetAll();
            return Ok(compras);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetById(int id)
        {
            CompraContract compra = _comprasService.Get(id);
            if (compra == null)
            {
                return NotFound("La compra no existe");
            }
            return Ok(compra);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetClientPurchases(int id)
        {
            List<CompraContract> comprasCliente = _comprasService.GetClientPurchases(id);
            if (comprasCliente != null && comprasCliente.Count == 0)
            {
                return NotFound("El id de cliente ingresado no es valido o no existe");
            }
            return Ok(comprasCliente);
        }

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult DeleteById(int id)
        {
            _comprasService.Delete(id);
            return NoContent();
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Create(CompraContract compra)
        {
            _comprasService.Insert(compra);
            return CreatedAtAction("Insert", compra);
        }

        [HttpPatch]
        [Route("[Action]")]
        public IActionResult Update(CompraContract compra)
        {
            _comprasService.Update(compra);
            return Ok(compra);
        }
    }
}
