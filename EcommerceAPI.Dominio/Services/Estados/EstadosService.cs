using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Estados;

namespace EcommerceAPI.Dominio.Services.Estados
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

        public void Delete(int id)
        {
            EstadoEntity estado = _estadosRepository.Get(id);
            if (estado != null)
            {
                _estadosRepository.Delete(estado);
            }
        }

        public EstadoContract Get(int id)
        {
            EstadoEntity estado = _estadosRepository.Get(id);
            EstadoContract estadoResult = _mapper.Map<EstadoContract>(estado);
            return estadoResult;
        }

        public List<EstadoContract> GetAll()
        {
            List<EstadoEntity> listaEstados = _estadosRepository.GetAll();
            return _mapper.Map<List<EstadoContract>>(listaEstados);
        }

        public EstadoContract Insert(EstadoContract estado)
        {
            EstadoEntity estadoEntity = _mapper.Map<EstadoEntity>(estado);
            estadoEntity = _estadosRepository.Insert(estadoEntity);

            return _mapper.Map<EstadoContract>(estadoEntity);
        }

        public EstadoContract Update(EstadoContract estado)
        {
            EstadoEntity estadoEntity = _estadosRepository.Get(estado.id_estado);
            if (estadoEntity != null)
            {
                estadoEntity = _estadosRepository.Update(_mapper.Map<EstadoEntity>(estado));
            }
            return _mapper.Map<EstadoContract>(estadoEntity);
        }
    }
}
