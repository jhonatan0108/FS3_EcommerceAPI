﻿using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Productos
{
    internal class ProductoService : IProductoService
    {
        private readonly IProductosRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductoService(IProductosRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            ProductoEntity producto = _productsRepository.GetById(id);
            if (producto != null)
            {
                _productsRepository.Delete(producto);
            }
        }

        public List<ProductoContract> GetAll()
        {
            List<ProductoEntity> productos = _productsRepository.GetAll();
            return _mapper.Map<List<ProductoContract>>(productos);
        }

        public List<ProductoContract> GetByCategory(int category)
        {
            List<ProductoEntity> productos = _productsRepository.GetByCategory(category);
            return _mapper.Map<List<ProductoContract>>(productos);
        }

        public ProductoContract GetById(int id)
        {
            ProductoEntity producto = _productsRepository.GetById(id);
            return _mapper.Map<ProductoContract>(producto);
        }

        public ProductoContract Insert(ProductoContract producto)
        {
            ProductoEntity productoEntity = _mapper.Map<ProductoEntity>(producto);
            _productsRepository.Insert(productoEntity);
            return _mapper.Map<ProductoContract>(producto);
        }

        public ProductoContract Update(ProductoContract producto)
        {
            ProductoEntity productoEntity = _productsRepository.GetById(producto.id_producto);
            if (productoEntity != null)
            {
                productoEntity = _productsRepository.Update(_mapper.Map<ProductoEntity>(producto));
            }
            return _mapper.Map<ProductoContract>(productoEntity);
        }
    }
}
