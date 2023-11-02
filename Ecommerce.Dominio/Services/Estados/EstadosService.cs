using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Estados;
using Ecommerce.Infraestructura.Database.Entidades;
using Ecommerce.Infraestructura.Repositorios.Estados;

namespace Ecommerce.Dominio.Services.Estados
{
    public class EstadosService : IEstadosService
    {
        private readonly IEstadosRepository _estadosRepository;
        private readonly IMapper _mapper;

        public EstadosService(IEstadosRepository estadosRepository, IMapper mapper)
        {
            _estadosRepository = estadosRepository;
            _mapper = mapper;
        }

        public List<EstadoContract> GetAll()
        {
            List<EstadoEntity> estados = _estadosRepository.GetAll();
            return _mapper.Map<List<EstadoContract>>(estados);
        }

        public EstadoContract Get(int id)
        {
            EstadoEntity estado = _estadosRepository.Get(id);
            EstadoContract contrato = _mapper.Map<EstadoContract>(estado);
            return contrato;
        }

        public EstadoContract Insert(EstadoContract estado)
        {
            EstadoEntity entidad = _mapper.Map<EstadoEntity>(estado);
            entidad = _estadosRepository.Insert(entidad);

            return _mapper.Map<EstadoContract>(entidad);
        }

        public EstadoContract Update(EstadoContract estado)
        {
            EstadoEntity entidad = _estadosRepository.Get(estado.id_estado);
            if (entidad != null)
            {
                entidad = _estadosRepository.Update(_mapper.Map<EstadoEntity>(estado));
            }
            return _mapper.Map<EstadoContract>(entidad);
        }

        public EstadoContract Delete(int id)
        {
            EstadoEntity estado = _estadosRepository.Get(id);
            if (estado != null)
            {
                _estadosRepository.Delete(estado);
            }

            return _mapper.Map<EstadoContract>(estado);
        }
    }
}
