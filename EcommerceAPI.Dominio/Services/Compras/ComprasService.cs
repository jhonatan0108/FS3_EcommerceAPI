using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Compras;
using EcommerceAPI.Dominio.Services.Clientes;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using EcommerceAPI.Infraestructura.Repositorios.Compra;

namespace EcommerceAPI.Dominio.Services.Compras
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
            CompraEntity compra = _comprasRepository.Get(id);
            CompraContract compraResult = _mapper.Map<CompraContract>(compra);
            return compraResult;
        }

        public List<CompraContract> GetAll()
        {
            List<CompraEntity> listaCompras = _comprasRepository.GetAll();
            return _mapper.Map<List<CompraContract>>(listaCompras);
        }

        public CompraContract Insert(CompraContract compra)
        {
            CompraEntity compraEntity = _mapper.Map<CompraEntity>(compra);
            compraEntity = _comprasRepository.Insert(compraEntity);

            return _mapper.Map<CompraContract>(compraEntity);
        }

        public CompraContract Update(CompraContract compra)
        {
            CompraEntity compraEntity = _comprasRepository.Get(compra.id_compra);
            if (compraEntity != null)
            {
                compraEntity = _comprasRepository.Update(_mapper.Map<CompraEntity>(compra));
            }
            return _mapper.Map<CompraContract>(compraEntity);
        }
    }
}
