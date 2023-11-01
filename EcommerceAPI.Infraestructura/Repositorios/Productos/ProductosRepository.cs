﻿using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : IProductosRepository
    {

        private readonly EcommerceContext _context;

        public ProductosRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(ProductoEntity entidad)
        {
            _context.Productos.Remove(entidad);
            _context.SaveChanges();
        }

        public List<ProductoEntity> GetAll()
        {
            return _context.Productos.ToList();
        }

        public ProductoEntity GetById(int id)
        {
            return _context.Productos.Find(id);
        }

        public List<ProductoEntity> GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Productos.Where(p => p.valor >= minPrice && p.valor <= maxPrice && p.id_estado != 5).ToList();
        }

        public ProductoEntity Insert(ProductoEntity entidad)
        {
            _context.Productos.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            _context.Productos.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
