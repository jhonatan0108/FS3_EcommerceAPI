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

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult Delete(int id)
        {
            _productoService.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ProductoContract> list = _productoService.GetAll();
            return Ok(list);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetCategory(string category)
        {
            List<ProductoContract> productosCategoria = _productoService.GetByCategory(category);
            return Ok(productosCategoria);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Get(int id)
        {
            ProductoContract producto = _productoService.GetById(id);
            if (producto != null)
            {
                return new JsonResult(producto) { StatusCode = 200 };
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            List<ProductoContract> listaEnRangoDePrecios = _productoService.GetByPriceRange(minPrice, maxPrice);
            return Ok(listaEnRangoDePrecios);
        }

        [HttpPost]
        [Route("CrearProducto")]
        public IActionResult Insert(ProductoContract producto)
        {
            _productoService.Insert(producto);
            var datos = new
            {
                Descripcion_del_producto = $"{producto.descripcion}",
                Valor_del_producto = $"{producto.valor}",
            };

            //Regresa un statusCode 201 (created)
            return CreatedAtAction("Insert", datos);
        }

        [HttpPost]
        [Route("ActualizarProducto")]
        public IActionResult Update(ProductoContract producto)
        {
            _productoService.Update(producto);
            var datos = new
            {
                Nombre_producto = producto.descripcion,
                Precio = producto.valor,

            };

            return Ok(datos);
        }
    }
}
