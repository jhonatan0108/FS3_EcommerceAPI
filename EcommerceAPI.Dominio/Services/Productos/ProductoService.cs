using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly IProductosRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductoService(IProductosRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            ProductoEntity producto = _productsRepository.GetById(id);
            if (producto != null)
            {
                _productsRepository.Delete(producto);
            }
        }

        public List<ProductoContract> GetAll()
        {
            List<ProductoEntity> productos = _productsRepository.GetAll();
            List<ProductoContract> listaProductos = _mapper.Map<List<ProductoContract>>(productos);

            //Se debe llamar al repositorio de Categorias y popular el campo recorriendo la lista
            // foreach (ProductoContract item in listaProductos)
            //{
            //    item.categoria= 
            // }

            return listaProductos;
        }

        public List<ProductoContract> GetByCategory(int category)
        {
            List<ProductoEntity> productos = _productsRepository.GetByCategory(category);
            return _mapper.Map<List<ProductoContract>>(productos);
        }

        public ProductoContract GetById(int id)
        {
            ProductoEntity producto = _productsRepository.GetById(id);
            return _mapper.Map<ProductoContract>(producto);
        }

        public List<ProductoContract> GetByPriceRange(float minPrice, float maxPrice)
        {
            List<ProductoEntity> productosEnRango = _productsRepository.GetByPriceRange(minPrice, maxPrice);
            return _mapper.Map<List<ProductoContract>>(productosEnRango);
        }

        public ProductoContract Insert(ProductoContract producto)
        {
            ProductoEntity productoEntity = _mapper.Map<ProductoEntity>(producto);
            _productsRepository.Insert(productoEntity);
            return _mapper.Map<ProductoContract>(producto);
        }

        public ProductoContract Update(ProductoContract producto)
        {
            ProductoEntity productoEntity = _productsRepository.GetById(producto.id_producto);
            if (productoEntity != null)
            {
                productoEntity = _productsRepository.Update(_mapper.Map<ProductoEntity>(producto));
            }
            return _mapper.Map<ProductoContract>(productoEntity);
        }
    }
}
