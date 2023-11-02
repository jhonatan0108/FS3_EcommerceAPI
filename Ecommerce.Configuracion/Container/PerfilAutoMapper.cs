using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Comunes.Clases.Contratos.Compras;
using Ecommerce.Comunes.Clases.Contratos.DetalleCompras;
using Ecommerce.Comunes.Clases.Contratos.Estados;
using Ecommerce.Comunes.Clases.Contratos.Productos;
using Ecommerce.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Configuracion.Container
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
            CreateMap<CompraEntity, CompraContract>().ReverseMap();
            CreateMap<DetalleCompraEntity, DetalleCompraContract>().ReverseMap();
            CreateMap<EstadoEntity, EstadoContract>().ReverseMap();
            CreateMap<ProductoEntity, ProductoContract>().ReverseMap();
        }
    }
}
