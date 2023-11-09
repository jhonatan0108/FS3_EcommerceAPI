
using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.ComprasDetalle;

namespace EcommerceAPI.Infraestructura.Repositorios.CompraDetallesDetalle
{
    public class ComprasDetalleRepository : IComprasDetalleRepository
    {

        private readonly EcommerceContext _context;

        public ComprasDetalleRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Delete(CompraDetalleEntity entity)
        {
           
           _context.CompraDetalles.Remove(entity);
            _context.SaveChanges();
        }

        public CompraDetalleEntity Get(int id)
        {
         return   _context.CompraDetalles.Find(id);
        }

        public List<CompraDetalleEntity> GetAll()
        {
             
            return _context.CompraDetalles.ToList();
        }

        public CompraDetalleEntity Insert(CompraDetalleEntity entity)
        {
            _context.CompraDetalles.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public CompraDetalleEntity Update(CompraDetalleEntity entity)
        {
            _context.CompraDetalles.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        //public CompraDetalleEntity GetId_Compra(int id);
        //{
        //    return _context.CompraDetalles.Where(x=> x.id_compra==id).ToList();
        //}

    }
}
