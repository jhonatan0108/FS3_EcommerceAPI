using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompras;
using EcommerceAPI.Dominio.Services.DetalleCompras;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleCompraController : ControllerBase
    {
        private readonly IDetalleComprasService _detalleComprasService;
        public DetalleCompraController(IDetalleComprasService detalleComprasService)
        {
            _detalleComprasService = detalleComprasService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<DetalleCompraContract> lista = _detalleComprasService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            DetalleCompraContract detallecompra = _detalleComprasService.Get(id);
            if (detallecompra != null)
                return Ok(detallecompra);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(DetalleCompraContract detallecompra)
        {
            DetalleCompraContract _detallecompra = _detalleComprasService.Insert(detallecompra);
            return Ok(_detallecompra);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(DetalleCompraContract detallecompra)
        {
            DetalleCompraContract _detallecompra = _detalleComprasService.Update(detallecompra);
            return Ok(_detallecompra);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _detalleComprasService.Delete(id);
            return Ok();
        }

    }
}
