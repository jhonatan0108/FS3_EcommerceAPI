using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Compras;
using EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Configuracion.Container
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
            CreateMap<ProductoEntity,ProductoContract>().ReverseMap();
            CreateMap<EstadoEntity,EstadoContract>().ReverseMap();
            CreateMap<CompraEntity,CompraContract>().ReverseMap();
            CreateMap<CompraDetalleEntity,CompraDetalleContract>().ReverseMap();


        }
    }
}
