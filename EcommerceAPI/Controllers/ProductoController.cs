using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Dominio.Services.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
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
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            List<ProductoContract> lista = _productosService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            ProductoContract cliente = _productosService.Get(id);
            if (cliente != null)
                return Ok(cliente);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(ProductoContract cliente)
        {
            ProductoContract _cliente = _productosService.Insert(cliente);
            return Ok(_cliente);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ProductoContract cliente)
        {
            ProductoContract _cliente = _productosService.Update(cliente);
            return Ok(_cliente);
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            _productosService.Delete(id);
            return Ok();
        }
    }
}
