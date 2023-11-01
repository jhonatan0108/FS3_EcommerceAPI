using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Categorias
{
    public class CategoriasRepository : ICategoriasRepository
    {

        private readonly EcommerceContext _context;

        public CategoriasRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(CategoriaEntity entity)
        {
            _context.Categorias.Remove(entity);
            _context.SaveChanges();
        }

        public CategoriaEntity Get(int id)
        {
            return _context.Categorias.Find(id);  
        }

        public List<CategoriaEntity> GetAll()
        {
            return _context.Categorias.ToList();
        }

        public CategoriaEntity Insert(CategoriaEntity entity)
        {
            _context.Categorias.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public CategoriaEntity Update(CategoriaEntity entity)
        {
            _context.Categorias.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
