using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Compra
{
    public class ComprasRepository : IComprasRepository
    {
        private readonly EcommerceContext _context;

        public ComprasRepository(EcommerceContext context)
        {
            _context = context;
        }
                    
        public void Delete(CompraEntity entidad)
        {
            _context.Compras.Remove(entidad);
            _context.SaveChanges();
        }

        public CompraEntity Get(int id)
        {
            return _context.Compras.Find(id);
        }

        public List<CompraEntity> GetAll()
        {
            return _context.Compras.ToList();
        }
        public CompraEntity Insert(CompraEntity entidad)
        {
            _context.Compras.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public CompraEntity Update(CompraEntity entidad)
        {
            _context.Compras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
