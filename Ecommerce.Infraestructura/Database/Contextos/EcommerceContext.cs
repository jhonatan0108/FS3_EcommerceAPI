using Ecommerce.Infraestructura.Database.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infraestructura.Database.Contextos
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options)
        {
            
        }

        #region [DbSets]
        public virtual DbSet<ClienteEntity> Clientes { get; set; }
        #endregion [DbSets]
    }
}
