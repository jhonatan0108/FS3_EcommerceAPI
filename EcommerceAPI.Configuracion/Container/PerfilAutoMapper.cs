using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Configuracion.Container
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, Comunes.Clases.Contratos.Clientes.ClienteContract>().ReverseMap();
            CreateMap<ProductoEntity, Comunes.Clases.Contratos.Productos.ProductoContract>().ReverseMap();
            CreateMap<CompraEntity, Comunes.Clases.Contratos.Compras.CompraContract>().ReverseMap();
            CreateMap<DetalleCompraEntity, Comunes.Clases.Contratos.DetalleCompras.DetalleCompraContract>().ReverseMap();
            CreateMap<EstadoEntity, Comunes.Clases.Contratos.Estados.EstadoContract>().ReverseMap();
        }
    }
}
