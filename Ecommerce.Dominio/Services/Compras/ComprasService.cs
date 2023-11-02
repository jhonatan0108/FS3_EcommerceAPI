using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Compras;
using Ecommerce.Infraestructura.Database.Entidades;
using Ecommerce.Infraestructura.Repositorios.Compras;

namespace Ecommerce.Dominio.Services.Compras
{
    public class ComprasService : IComprasService
    {
        private readonly IComprasRepository _comprasRepository;
        private readonly IMapper _mapper;

        public ComprasService(IComprasRepository comprasRepository, IMapper mapper)
        {
            _comprasRepository = comprasRepository;
            _mapper = mapper;
        }

        public CompraContract Delete(int id)
        {
            CompraEntity compra = _comprasRepository.Get(id);
            if (compra != null)
            {
                _comprasRepository.Delete(compra);
            }

            return _mapper.Map<CompraContract>(compra);
        }

        public CompraContract Get(int id)
        {
            CompraEntity compra = _comprasRepository.Get(id);
            CompraContract contrato = _mapper.Map<CompraContract>(compra);
            return contrato;
        }

        public List<CompraContract> GetAll()
        {
            List<CompraEntity> compras = _comprasRepository.GetAll();
            return _mapper.Map<List<CompraContract>>(compras);
        }

        public CompraContract Insert(CompraContract contrato)
        {
            CompraEntity entidad = _mapper.Map<CompraEntity>(contrato);
            entidad = _comprasRepository.Insert(entidad);

            return _mapper.Map<CompraContract>(entidad);
        }

        public CompraContract Update(CompraContract contrato)
        {
            CompraEntity entidad = _comprasRepository.Get(contrato.id_cliente);
            if (entidad != null)
            {
                entidad = _comprasRepository.Update(_mapper.Map<CompraEntity>(contrato));
            }
            return _mapper.Map<CompraContract>(entidad);
        }
    }
}
