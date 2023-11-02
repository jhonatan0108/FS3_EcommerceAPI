using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Productos
{
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _productosRepository;
        private readonly IMapper _mapper;

        public ProductosService(IProductosRepository productosRepository, IMapper mapper)
        {
            _productosRepository = productosRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoContract Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductoContract Insert(ProductoContract cliente)
        {
            throw new NotImplementedException();
        }

        public ProductoContract Update(ProductoContract cliente)
        {
            throw new NotImplementedException();
        }
    }
}
