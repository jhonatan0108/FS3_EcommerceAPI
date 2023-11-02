using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Dominio.Services.Clientes;
using EcommerceAPI.Dominio.Services.Productos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruductoController : ControllerBase
    {
        private readonly IProductosService _productosService;

        public PruductoController(IProductosService productosService)
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
            ProductoContract producto = _productosService.Get(id);
            if (producto != null)
                return Ok(producto);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(ProductoContract producto)
        {
            ProductoContract _producto = _productosService.Insert(producto);
            return Ok(_producto);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ProductoContract producto)
        {
            ProductoContract _producto = _productosService.Update(producto);
            return Ok(_producto);
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
