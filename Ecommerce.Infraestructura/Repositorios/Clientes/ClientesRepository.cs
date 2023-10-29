using Ecommerce.Infraestructura.Database.Contextos;
using Ecommerce.Infraestructura.Database.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infraestructura.Repositorios.Clientes
{
    public class ClientesRepository: IClientesRepository
    {
        private readonly EcommerceContext _context;

        public ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public List<ClienteEntity> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity Get(int id)
        {
            return _context.Clientes.Find(id);
        }

        public ClienteEntity Insert(ClienteEntity entidad)
        {
            _context.Clientes.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            _context.Clientes.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ClienteEntity entidad)
        {
            _context.Clientes.Remove(entidad);
            _context.SaveChanges();
        }
    }
}
