using Ecommerce.Infraestructura.Database.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infraestructura.Repositorios
{
    public class BaseRepository
    {
        protected readonly EcommerceContext _context;

        public BaseRepository(EcommerceContext context)
        {
            _context = context;
        }
    }
}
