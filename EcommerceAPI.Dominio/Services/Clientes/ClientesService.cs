using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Helpers.Cifrado;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;

namespace EcommerceAPI.Dominio.Services.Clientes
{
    public class ClientesService : IClientesService
    {
        private readonly IEstadosRepository _clientesRepository;
        private readonly IMapper _mapper;

        public ClientesService(IEstadosRepository clientesRepository, IMapper mapper)
        {
            _clientesRepository = clientesRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            ClienteEntity cliente = _clientesRepository.Get(id);
            if (cliente != null)
            {
                _clientesRepository.Delete(cliente);
            }
        }

        public ClienteContract Get(int id)
        {
            ClienteEntity cliente = _clientesRepository.Get(id);
            ClienteContract clienteResult = _mapper.Map<ClienteContract>(cliente);
            return clienteResult;
        }

        public List<ClienteContract> GetAll()
        {
            List<ClienteEntity> listaClientes = _clientesRepository.GetAll();
            return _mapper.Map<List<ClienteContract>>(listaClientes);
        }

        public ClienteContract Insert(ClienteContract cliente)
        {
            string encriptPassword = CifradoHelper.Encriptar(cliente.password);
            cliente.password = encriptPassword;

            ClienteEntity clienteEntity = _mapper.Map<ClienteEntity>(cliente);
            clienteEntity = _clientesRepository.Insert(clienteEntity);

            return _mapper.Map<ClienteContract>(clienteEntity);
        }

        public ClienteContract Update(ClienteContract cliente)
        {
            ClienteEntity clienteEntity = _clientesRepository.Get(cliente.id_cliente);
            if (clienteEntity != null)
            {

                string passwordnew = CifradoHelper.Encriptar(cliente.password);
                if (clienteEntity.password != passwordnew)
                    cliente.password = passwordnew;

                clienteEntity = _clientesRepository.Update(_mapper.Map<ClienteEntity>(cliente));
            }
            return _mapper.Map<ClienteContract>(clienteEntity);
        }
    }
}
