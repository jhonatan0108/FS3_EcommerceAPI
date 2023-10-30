using EcommerceAPI.Infraestructura.Database.Contextos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly EcommerceContext _context;

        public ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Delete(ClienteEntity entidad)
        {
            _context.Clientes.Remove(entidad);
            _context.SaveChanges();
        }

        public ClienteEntity Get(int id)
        {
            return _context.Clientes.Find(id);
        }

        public List<ClienteEntity> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity FindByEmail(string email)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Clientes
                    .Where(c => c.correo.Equals(email)) // Basic comparison
                    .AsEnumerable() // Switch to LINQ to Objects
                    .FirstOrDefault(c => string.Equals(c.correo, email, StringComparison.OrdinalIgnoreCase)); // Case-insensitive comparison
#pragma warning restore CS8603 // Possible null reference return.
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
    }
}
