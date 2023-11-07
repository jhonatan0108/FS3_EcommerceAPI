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

        public void Delete(CompraEntity compra)
        {
            _context.Compras.Remove(compra);
            _context.SaveChanges();
        }

        public CompraEntity Get(int id)
        {
            return _context.Compras.Find(id);
        }

        public List<CompraEntity> GetClientPurchases(int cliente)
        {
            return _context.Compras.Where(c => c.id_cliente == cliente).ToList();
        }

        public List<CompraEntity> GetAll()
        {
            return _context.Compras.ToList();
        }

        public CompraEntity Insert(CompraEntity compra)
        {
            _context.Compras.Add(compra);
            _context.SaveChanges();
            return compra;
        }

        public CompraEntity Update(CompraEntity compra)
        {
            _context.Compras.Update(compra);
            _context.SaveChanges();
            return compra;
        }
    }
}
