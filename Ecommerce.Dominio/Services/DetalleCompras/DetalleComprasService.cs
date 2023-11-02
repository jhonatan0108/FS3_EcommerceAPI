using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.DetalleCompras;
using Ecommerce.Infraestructura.Database.Entidades;
using Ecommerce.Infraestructura.Repositorios.DetalleCompras;

namespace Ecommerce.Dominio.Services.DetalleCompras
{
    public class DetalleComprasService : IDetalleComprasService
    {
        private readonly IDetalleComprasRepository _detalleCompraRepository;
        private readonly IMapper _mapper;

        public DetalleComprasService(IDetalleComprasRepository detallesRepository, IMapper mapper)
        {
            _detalleCompraRepository = detallesRepository;
            _mapper = mapper;
        }

        public List<DetalleCompraContract> GetAll()
        {
            List<DetalleCompraEntity> detalles = _detalleCompraRepository.GetAll();
            return _mapper.Map<List<DetalleCompraContract>>(detalles);
        }

        public DetalleCompraContract Get(int id)
        {
            DetalleCompraEntity entidad = _detalleCompraRepository.Get(id);
            DetalleCompraContract contrato = _mapper.Map<DetalleCompraContract>(entidad);
            return contrato;
        }

        public DetalleCompraContract Insert(DetalleCompraContract contrato)
        {
            DetalleCompraEntity entidad = _mapper.Map<DetalleCompraEntity>(contrato);
            entidad = _detalleCompraRepository.Insert(entidad);

            return _mapper.Map<DetalleCompraContract>(entidad);
        }

        public DetalleCompraContract Update(DetalleCompraContract contrato)
        {
            DetalleCompraEntity entidad = _detalleCompraRepository.Get(contrato.id_detallecompra);
            if (entidad != null)
            {
                entidad = _detalleCompraRepository.Update(_mapper.Map<DetalleCompraEntity>(contrato));
            }
            return _mapper.Map<DetalleCompraContract>(entidad);
        }

        public DetalleCompraContract Delete(int id)
        {
            DetalleCompraEntity entidad = _detalleCompraRepository.Get(id);
            if (entidad != null)
            {
                _detalleCompraRepository.Delete(entidad);
            }

            return _mapper.Map<DetalleCompraContract>(entidad);
        }
    }
}
