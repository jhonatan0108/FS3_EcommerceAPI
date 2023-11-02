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

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
