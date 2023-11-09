using EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle;
using EcommerceAPI.Dominio.Services.Compras;
using EcommerceAPI.Dominio.Services.ComprasDetalle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraDetalleController : ControllerBase
    {
        private readonly IComprasDetalleService _comprasService;
        public CompraDetalleController(IComprasDetalleService comprasService)
        {
            _comprasService = comprasService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<CompraDetalleContract> lista = _comprasService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            CompraDetalleContract compraDetalle = _comprasService.Get(id);
            if (compraDetalle != null)
                return Ok(compraDetalle);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(CompraDetalleContract compraDetalle)
        {
            CompraDetalleContract _compraDetalle = _comprasService.Insert(compraDetalle);
            return Ok(_compraDetalle);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(CompraDetalleContract compraDetalle)
        {
            CompraDetalleContract _compraDetalle = _comprasService.Update(compraDetalle);
            return Ok(_compraDetalle);
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
