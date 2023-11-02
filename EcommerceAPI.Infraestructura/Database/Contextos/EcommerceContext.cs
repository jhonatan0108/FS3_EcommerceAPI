using EcommerceAPI.Infraestructura.Database.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EcommerceAPI.Infraestructura.Database.Contextos
{
    public class EcommerceContext : DbContext
    {
        private readonly IConfiguration _configuracion;
        public EcommerceContext(DbContextOptions<EcommerceContext> options, IConfiguration configuration) : base(options)
        {
            _configuracion = configuration;
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
