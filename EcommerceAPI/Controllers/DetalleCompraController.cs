using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompra;
using EcommerceAPI.Dominio.Services.DetalleCompra;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleCompraController : ControllerBase
    {
        private readonly IDetalleCompraService _detalleCompraService;

        public DetalleCompraController(IDetalleCompraService detalleCompraService)
        {
            _detalleCompraService = detalleCompraService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<DetalleCompraContract> detalleCompras = _detalleCompraService.GetAll();
            return Ok(detalleCompras);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetById(int id)
        {
            DetalleCompraContract detalleCompra = _detalleCompraService.Get(id);
            if (detalleCompra != null)
            {
                return new JsonResult(detalleCompra) { StatusCode = 200 };
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult Delete(int id)
        {
            _detalleCompraService.Delete(id);
            return NoContent();
        }

        [HttpPatch]
        [Route("[Action]")]
        public IActionResult Update(DetalleCompraContract detalleCompra)
        {
            _detalleCompraService.Update(detalleCompra);
            var datos = new
            {
                Cantidad_de_productos = detalleCompra.cantidad_producto,
                Valor = detalleCompra.totalDetalle
            };
            return Ok(datos);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Insert(DetalleCompraContract detalleCompra)
        {
            _detalleCompraService.Insert(detalleCompra);
            return CreatedAtAction("Insert", detalleCompra);
        }
    }
}
