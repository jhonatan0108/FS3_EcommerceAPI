using Ecommerce.Comunes.Clases.Contratos.DetalleCompras;
using Ecommerce.Dominio.Services.DetalleCompras;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleCompraController : ControllerBase
    {
        private readonly IDetalleComprasService _detalleService;

        public DetalleCompraController(IDetalleComprasService detalleService)
        {
            _detalleService = detalleService;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<DetalleCompraContract> lista = _detalleService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            DetalleCompraContract contrato = _detalleService.Get(id);

            if (contrato != null) return Ok(contrato);

            return BadRequest();
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromBody] DetalleCompraContract contract)
        {
            return Ok(_detalleService.Insert(contract));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] DetalleCompraContract contract)
        {
            return Ok(_detalleService.Update(contract));
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_detalleService.Delete(id));
        }
    }
}
