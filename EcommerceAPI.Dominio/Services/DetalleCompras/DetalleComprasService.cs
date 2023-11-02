using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompras;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.DetalleComprasRepository;

namespace EcommerceAPI.Dominio.Services.DetalleCompras
{
    public class DetalleComprasService : IDetalleComprasService
    {
        private readonly IDetalleComprasRepository _detalleComprasRepository;
        private readonly IMapper _mapper;

        public DetalleComprasService(IDetalleComprasRepository detalleComprasRepository, IMapper mapper)
        {
            _detalleComprasRepository = detalleComprasRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            DetalleCompraEntity detalleCompra = _detalleComprasRepository.Get(id);
            if (detalleCompra != null)
            {
                _detalleComprasRepository.Delete(detalleCompra);
            }
        }

        public DetalleCompraContract Get(int id)
        {
            DetalleCompraEntity detalleCompra = _detalleComprasRepository.Get(id);
            DetalleCompraContract detalleCompraResult = _mapper.Map<DetalleCompraContract>(detalleCompra);
            return detalleCompraResult;
        }

        public List<DetalleCompraContract> GetAll()
        {
            List<DetalleCompraEntity> listaDetalleCompra = _detalleComprasRepository.GetAll();
            return _mapper.Map<List<DetalleCompraContract>>(listaDetalleCompra);
        }

        public DetalleCompraContract Insert(DetalleCompraContract detalleCompra)
        {
            DetalleCompraEntity detalleCompraEntity = _mapper.Map<DetalleCompraEntity>(detalleCompra);
            detalleCompraEntity = _detalleComprasRepository.Insert(detalleCompraEntity);

            return _mapper.Map<DetalleCompraContract>(detalleCompraEntity);
        }

        public DetalleCompraContract Update(DetalleCompraContract detalleCompra)
        {
            DetalleCompraEntity detalleCompraEntity = _detalleComprasRepository.Get(detalleCompra.id_detallecompra);
            if (detalleCompraEntity != null)
            {
                detalleCompraEntity = _detalleComprasRepository.Update(_mapper.Map<DetalleCompraEntity>(detalleCompra));
            }
            return _mapper.Map<DetalleCompraContract>(detalleCompraEntity);
        }
    }
}
