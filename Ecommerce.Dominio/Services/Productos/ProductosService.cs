using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Productos;
using Ecommerce.Infraestructura.Database.Entidades;
using Ecommerce.Infraestructura.Repositorios.Productos;

namespace Ecommerce.Dominio.Services.Productos
{
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductosService(IProductosRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public List<ProductoContract> GetAll()
        {
            List<ProductoEntity> productos = _productoRepository.GetAll();
            return _mapper.Map<List<ProductoContract>>(productos);
        }

        public ProductoContract Get(int id)
        {
            ProductoEntity cliente = _productoRepository.Get(id);
            ProductoContract clienteResult = _mapper.Map<ProductoContract>(cliente);
            return clienteResult;
        }

        public ProductoContract Insert(ProductoContract cliente)
        {
            ProductoEntity clienteEntity = _mapper.Map<ProductoEntity>(cliente);
            clienteEntity = _productoRepository.Insert(clienteEntity);

            return _mapper.Map<ProductoContract>(clienteEntity);
        }

        public ProductoContract Update(ProductoContract producto)
        {
            ProductoEntity clienteEntity = _productoRepository.Get(producto.id_producto);
            if (clienteEntity != null)
            {
                clienteEntity = _productoRepository.Update(_mapper.Map<ProductoEntity>(producto));
            }
            return _mapper.Map<ProductoContract>(clienteEntity);
        }

        public ProductoContract Delete(int id)
        {
            ProductoEntity cliente = _productoRepository.Get(id);
            if (cliente != null)
            {
                _productoRepository.Delete(cliente);
            }

            return _mapper.Map<ProductoContract>(cliente);
        }
    }
}
