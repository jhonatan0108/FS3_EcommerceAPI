using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Infraestructura.Database.Entidades;
using Ecommerce.Infraestructura.Repositorios.Clientes;

namespace Ecommerce.Dominio.Services.Clientes
{
    public class ClientesService: IClientesService
    {
        private readonly IClientesRepository _clientesRepository;
        private readonly IMapper _mapper;

        public ClientesService(IClientesRepository clientesRepository, IMapper mapper)
        {
            _clientesRepository = clientesRepository;
            _mapper = mapper;
        }

        public List<ClienteContract> GetAll()
        {
            List<ClienteEntity> listaClientes = _clientesRepository.GetAll();
            return _mapper.Map<List<ClienteContract>>(listaClientes);
        }

        public ClienteContract Get(int id)
        {
            ClienteEntity cliente = _clientesRepository.Get(id);
            ClienteContract clienteResult = _mapper.Map<ClienteContract>(cliente);
            return clienteResult;
        }

        public ClienteContract Insert(ClienteContract cliente)
        {
            ClienteEntity clienteEntity = _mapper.Map<ClienteEntity>(cliente);
            clienteEntity = _clientesRepository.Insert(clienteEntity);

            return _mapper.Map<ClienteContract>(clienteEntity);
        }

        public ClienteContract Update(ClienteContract cliente)
        {
            ClienteEntity clienteEntity = _clientesRepository.Get(cliente.id_cliente);
            if (clienteEntity != null)
            {
                clienteEntity = _clientesRepository.Update(_mapper.Map<ClienteEntity>(cliente));
            }
            return _mapper.Map<ClienteContract>(clienteEntity);
        }

        public void Delete(int id)
        {
            ClienteEntity cliente = _clientesRepository.Get(id);
            if (cliente != null)
            {
                _clientesRepository.Delete(cliente);
            }
        }
    }
}
