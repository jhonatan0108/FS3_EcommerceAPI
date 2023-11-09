

using AutoMapper;

using EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.ComprasDetalle;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Dominio.Services.ComprasDetalle
{
    public class ComprasDetalleService : IComprasDetalleService
    {
        private readonly IComprasDetalleRepository _comprasRepository;
        private readonly IMapper _mapper;

        public ComprasDetalleService(IComprasDetalleRepository comprasRepository, IMapper mapper)
        {
            _comprasRepository = comprasRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            CompraDetalleEntity compra = _comprasRepository.Get(id);
            if (compra != null)
            {
                _comprasRepository.Delete(compra);
            }
        }

        public CompraDetalleContract Get(int id)
        {
            CompraDetalleEntity compra = _comprasRepository.Get(id);
            CompraDetalleContract compraResult = _mapper.Map<CompraDetalleContract>(compra);
            return compraResult;
        }

        public List<CompraDetalleContract> GetAll()
        {
            List<CompraDetalleEntity> listacompras = _comprasRepository.GetAll();
            return _mapper.Map<List<CompraDetalleContract>>(listacompras);
        }

        public CompraDetalleContract Insert(CompraDetalleContract compra)
        {
            CompraDetalleEntity CompraDetalleEntity = _mapper.Map<CompraDetalleEntity>(compra);
            CompraDetalleEntity = _comprasRepository.Insert(CompraDetalleEntity);

            return _mapper.Map<CompraDetalleContract>(CompraDetalleEntity);
        }

        public CompraDetalleContract Update(CompraDetalleContract compra)
        {
            CompraDetalleEntity CompraDetalleEntity = _comprasRepository.Get(compra.id_compra);
            if (CompraDetalleEntity != null)
            {
                CompraDetalleEntity = _comprasRepository.Update(_mapper.Map<CompraDetalleEntity>(compra));
            }
            return _mapper.Map<CompraDetalleContract>(CompraDetalleEntity);
        }
 
    }
}
