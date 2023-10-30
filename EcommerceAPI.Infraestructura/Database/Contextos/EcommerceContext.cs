using EcommerceAPI.Infraestructura.Database.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Infraestructura.Database.Contextos
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {
            
        }

        #region [DbSets]
        public virtual DbSet<ClienteEntity> Clientes { get; set; }
        public virtual DbSet<ProductoEntity> Productos { get; set; }

        #endregion
    }
}
