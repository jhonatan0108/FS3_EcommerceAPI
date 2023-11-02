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
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<CompraContract> lista = _comprasService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            CompraContract compra = _comprasService.Get(id);
            if (compra != null)
                return Ok(compra);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(CompraContract compra)
        {
            CompraContract _compra = _comprasService.Insert(compra);
            return Ok(_compra);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(CompraContract compra)
        {
            CompraContract _compra = _comprasService.Update(compra);
            return Ok(_compra);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _comprasService.Delete(id);
            return Ok();
        }

    }
}
