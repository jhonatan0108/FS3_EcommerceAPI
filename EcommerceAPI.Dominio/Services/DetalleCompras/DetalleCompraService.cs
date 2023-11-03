using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompra;
using EcommerceAPI.Dominio.Services.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompra;

namespace EcommerceAPI.Dominio.Services.DetalleCompra
{
    public class DetalleCompraService : IDetalleCompraService
    {
        private readonly IDetalleCompraRepository _detalleCompraRepository;
        private readonly IProductoService _productoService;
        private readonly IMapper _mapper;
        public DetalleCompraService(IDetalleCompraRepository detalleCompraRepository, IProductoService productoService, IMapper mapper)
        {
            _detalleCompraRepository = detalleCompraRepository;
            _productoService = productoService;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            DetalleCompraEntity detalleCompra = _detalleCompraRepository.Get(id);
            if (detalleCompra != null)
            {
                _detalleCompraRepository.Delete(detalleCompra);
            }
        }

        public DetalleCompraContract Get(int id)
        {
            return _mapper.Map<DetalleCompraContract>(_detalleCompraRepository.Get(id));
        }

        public List<DetalleCompraContract> GetAll()
        {
            return _mapper.Map<List<DetalleCompraContract>>(_detalleCompraRepository.GetAll());
        }

        public DetalleCompraContract Insert(DetalleCompraContract detalleCompra)
        {
            DetalleCompraEntity detalleCompraEntity = _mapper.Map<DetalleCompraEntity>(detalleCompra);
            detalleCompraEntity.totalDetalle = _productoService.GetById(detalleCompraEntity.id_producto).valor * detalleCompraEntity.cantidad_producto;
            _detalleCompraRepository.Insert(detalleCompraEntity);
            return _mapper.Map<DetalleCompraContract>(detalleCompraEntity);
        }

        public DetalleCompraContract Update(DetalleCompraContract detalleCompra)
        {
            DetalleCompraEntity detalleCompraEntity = _mapper.Map<DetalleCompraEntity>(detalleCompra);
            detalleCompraEntity.totalDetalle = _productoService.GetById(detalleCompraEntity.id_producto).valor;
            _detalleCompraRepository.Update(detalleCompraEntity);
            return _mapper.Map<DetalleCompraContract>(detalleCompraEntity);
        }
    }
}
