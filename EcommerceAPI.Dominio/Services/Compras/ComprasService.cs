

using AutoMapper;

using EcommerceAPI.Comunes.Clases.Contratos.Compras;
using EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using EcommerceAPI.Infraestructura.Repositorios.ComprasDetalle;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace EcommerceAPI.Dominio.Services.Compras
{
    public class ComprasDetalleService : IComprasService
    {
        private readonly IComprasRepository _comprasRepository;
        private readonly IComprasDetalleRepository _comprasDetalleRepository;

        private readonly IMapper _mapper;

        public ComprasDetalleService(IComprasRepository comprasRepository, IComprasDetalleRepository comprasDetalleRepository, IMapper mapper)
        {
            _comprasRepository = comprasRepository;
            _comprasDetalleRepository = comprasDetalleRepository;
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
            List<CompraEntity> listacompras = _comprasRepository.GetAll();
            
            return _mapper.Map<List<CompraContract>>(listacompras);
        }

        public CompraContract Insert(CompraContract compra)
        {
            CompraEntity CompraEntity = _mapper.Map<CompraEntity>(compra);
            CompraEntity = _comprasRepository.Insert(CompraEntity);
            foreach (var item in compra.comprasDetalles)
            {
                item.id_compra = CompraEntity.id_compra;
                CompraDetalleEntity CompraDetalleEntity = _mapper.Map<CompraDetalleEntity>(item);
                CompraDetalleEntity = _comprasDetalleRepository.Insert(CompraDetalleEntity);
            }

            return _mapper.Map<CompraContract>(CompraEntity);
        }

        public CompraContract Update(CompraContract compra)
        {
            CompraEntity CompraEntity = _comprasRepository.Get(compra.id_compra);
        
            if (CompraEntity != null)
            {
                CompraEntity = _comprasRepository.Update(_mapper.Map<CompraEntity>(compra));
                foreach (var item in compra.comprasDetalles)
                {
                    item.id_compra = CompraEntity.id_compra;
                    CompraDetalleEntity CompraDetalleEntity = _mapper.Map<CompraDetalleEntity>(item);
                    CompraDetalleEntity = _comprasDetalleRepository.Update(CompraDetalleEntity);
                     
                }

            }
          
            return _mapper.Map<CompraContract>(CompraEntity);
        }
    }
}
