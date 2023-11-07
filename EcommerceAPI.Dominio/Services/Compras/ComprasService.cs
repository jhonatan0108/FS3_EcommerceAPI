using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Compras;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompra;

namespace EcommerceAPI.Dominio.Services.Compras
{
    public class ComprasService : IComprasService
    {
        private readonly IComprasRepository _comprasRepository;
        private readonly IDetalleCompraRepository _detalleCompraRepository;
        private readonly IMapper _mapper;

        public ComprasService(IComprasRepository clientesRepository, IMapper mapper, IDetalleCompraRepository detalleCompraRepository)
        {
            _comprasRepository = clientesRepository;
            _detalleCompraRepository = detalleCompraRepository;
            _mapper = mapper;
        }
        public void Delete(int id)
        {
            CompraEntity compra = _comprasRepository.Get(id);
            if (compra != null)
            {
                _comprasRepository.Delete(compra);
            }
        }

        public CompraContract Get(int id)
        {
            CompraEntity compraEntity = _comprasRepository.Get(id);
            CompraContract compraContract = _mapper.Map<CompraContract>(compraEntity);
            compraContract.detalles = _detalleCompraRepository.GetByCompra(compraContract.id_compra);
            return compraContract;

        }

        public List<CompraContract> GetAll()
        {
            List<CompraEntity> comprasEntity = _comprasRepository.GetAll();
            List<CompraContract> comprasContract = _mapper.Map<List<CompraContract>>(comprasEntity);

            foreach (CompraContract c in comprasContract)
            {
                c.detalles = _detalleCompraRepository.GetByCompra(c.id_compra);
            }

            return comprasContract;
        }

        public List<CompraContract> GetClientPurchases(int cliente)
        {
            List<CompraEntity> comprasEntity = _comprasRepository.GetClientPurchases(cliente);
            List<CompraContract> comprasContract = _mapper.Map<List<CompraContract>>(comprasEntity);

            foreach (CompraContract c in comprasContract)
            {
                c.detalles = _detalleCompraRepository.GetByCompra(c.id_compra);
            }

            return comprasContract;

        }

        public CompraContract Insert(CompraContract compra)
        {
            _comprasRepository.Insert(_mapper.Map<CompraEntity>(compra));
            return compra;
        }

        public CompraContract Update(CompraContract compra)
        {
            _comprasRepository.Update(_mapper.Map<CompraEntity>(compra));
            return compra;
        }
    }
}
