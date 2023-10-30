using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Dominio.Services.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            List<ProductoContract> list = _productoService.GetAll();
            return Ok(list);
        }
    }
}
