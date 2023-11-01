using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Categorias;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Categorias;


namespace EcommerceAPI.Dominio.Services.Categorias
{
    internal class CategoriasService : ICategoriasService
    {
        private readonly ICategoriasRepository _categoriasRepository;
        private readonly IMapper _mapper;
        public CategoriasService(ICategoriasRepository categoriasRepository, IMapper mapper)
        {
            _categoriasRepository = categoriasRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            CategoriaEntity categoria = _categoriasRepository.Get(id);
            if (categoria != null)
            {
                _categoriasRepository.Delete(categoria);
            }
        }

        public CategoriaContract Get(int id)
        {
            CategoriaEntity categoria = _categoriasRepository.Get(id);
            return _mapper.Map<CategoriaContract>(categoria);
        }

        public List<CategoriaContract> GetAll()
        {
            List<CategoriaEntity> categorias = _categoriasRepository.GetAll();
            return _mapper.Map<List<CategoriaContract>>(categorias);
        }

        public CategoriaContract Insert(CategoriaContract categoria)
        {
            CategoriaEntity categoriaInsertada = _mapper.Map<CategoriaEntity>(categoria);
            _categoriasRepository.Insert(categoriaInsertada);
            return _mapper.Map<CategoriaContract>(categoriaInsertada);
        }

        public CategoriaContract Update(CategoriaContract categoria)
        {
            CategoriaEntity categoriaActualizada = _mapper.Map<CategoriaEntity>(categoria);
            _categoriasRepository.Update(categoriaActualizada);
            return _mapper.Map<CategoriaContract>(categoriaActualizada);
        }
    }
}
