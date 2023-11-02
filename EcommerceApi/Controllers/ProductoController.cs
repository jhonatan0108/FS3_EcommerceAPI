using Ecommerce.Comunes.Clases.Contratos.Productos;
using Ecommerce.Dominio.Services.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductosService _productosService;

        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<ProductoContract> contrato = _productosService.GetAll();
            return Ok(contrato);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            ProductoContract contrato = _productosService.Get(id);

            if (contrato != null) return Ok(contrato);

            return BadRequest();
        }

        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromBody] ProductoContract contract)
        {
            return Ok(_productosService.Insert(contract));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] ProductoContract contract)
        {
            return Ok(_productosService.Update(contract));
        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productosService.Delete(id));
        }
    }
}
