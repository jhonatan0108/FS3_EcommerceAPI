
using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public class ComprasRepository : IComprasRepository
    {

        private readonly EcommerceContext _context;

        public ComprasRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Delete(CompraEntity entity)
        {
           _context.Compras.Remove(entity);
            
            _context.SaveChanges();
        }

        public CompraEntity Get(int id)
        {
            _context.CompraDetalles.Where(x => x.id_compra == id).ToList();
            return   _context.Compras.Find(id);
        }

        public List<CompraEntity> GetAll()
        {
            return _context.Compras.ToList();
        }

        public CompraEntity Insert(CompraEntity entity)
        {
            _context.Compras.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public CompraEntity Update(CompraEntity entity)
        {
            _context.Compras.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
