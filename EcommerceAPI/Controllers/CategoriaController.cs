using EcommerceAPI.Comunes.Clases.Contratos.Categorias;
using EcommerceAPI.Dominio.Services.Categorias;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriasService _categoriasService;

        public CategoriaController(ICategoriasService categoriaService)
        {
            _categoriasService = categoriaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CategoriaContract> categorias = _categoriasService.GetAll();
            return Ok(categorias);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetById(int id)
        {
            CategoriaContract categoriaContract = _categoriasService.Get(id);
            return Ok(categoriaContract);
        }

        [HttpDelete]
        [Route("[Action]")]
        public IActionResult Delete(int id)
        {
            _categoriasService.Delete(id);
            return NoContent();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(CategoriaContract categoriaContract)
        {
            _categoriasService.Insert(categoriaContract);
            var datos = new
            {
                Nombre_categoria = categoriaContract.nombre,
                Descripcion = categoriaContract.descripcion,
            };

            return CreatedAtAction("Create", datos);
        }

        [HttpPatch]
        [Route("[Action]")]
        public IActionResult Update(CategoriaContract categoriaContract)
        {
            CategoriaContract categoriaActualizada = _categoriasService.Update(categoriaContract);
            return Ok(categoriaActualizada);
        }
    }
}
