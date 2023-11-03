using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Estados;

namespace EcommerceAPI.Dominio.Services.Estados
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;

        public EstadoService(IEstadoRepository estadoRepository, IMapper mapper)
        {
            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
           EstadoEntity estado = _estadoRepository.Get(id);
            if (estado != null)
            {
                _estadoRepository.Delete(estado);
            }
        }

        public EstadoContract Get(int id)
        {
            return _mapper.Map<EstadoContract>(_estadoRepository.Get(id));
        }

        public List<EstadoContract> GetAll()
        {
            return _mapper.Map<List<EstadoContract>>(_estadoRepository.GetAll());
        }

        public EstadoContract Insert(EstadoContract estado)
        {
            _estadoRepository.Insert(_mapper.Map<EstadoEntity>(estado));
            return estado;
        }

        public EstadoContract Update(EstadoContract estado)
        {
            _estadoRepository.Update(_mapper.Map<EstadoEntity>(estado));
            return estado;
        }
    }
}
