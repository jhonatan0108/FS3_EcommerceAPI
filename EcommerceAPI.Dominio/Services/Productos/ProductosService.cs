

using AutoMapper;

using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Productos
{
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _productosRepository;
        private readonly IMapper _mapper;

        public ProductosService(IProductosRepository productosRepository, IMapper mapper)
        {
            _productosRepository = productosRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            ProductoEntity producto = _productosRepository.Get(id);
            if (producto != null)
            {
                _productosRepository.Delete(producto);
            }
        }

        public ProductoContract Get(int id)
        {
            ProductoEntity producto = _productosRepository.Get(id);
            ProductoContract productoResult = _mapper.Map<ProductoContract>(producto);
            return productoResult;
        }

        public List<ProductoContract> GetAll()
        {
            List<ProductoEntity> listaproductos = _productosRepository.GetAll();
            return _mapper.Map<List<ProductoContract>>(listaproductos);
        }

        public ProductoContract Insert(ProductoContract producto)
        {
            ProductoEntity ProductoEntity = _mapper.Map<ProductoEntity>(producto);
            ProductoEntity = _productosRepository.Insert(ProductoEntity);

            return _mapper.Map<ProductoContract>(ProductoEntity);
        }

        public ProductoContract Update(ProductoContract producto)
        {
            ProductoEntity ProductoEntity = _productosRepository.Get(producto.id_producto);
            if (ProductoEntity != null)
            {
                ProductoEntity = _productosRepository.Update(_mapper.Map<ProductoEntity>(producto));
            }
            return _mapper.Map<ProductoContract>(ProductoEntity);
        }
    }
}
