using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompra;
using EcommerceAPI.Comunes.Clases.Contratos.Categorias;
using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Productos;
using EcommerceAPI.Infraestructura.Database.Entidades;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using EcommerceAPI.Comunes.Clases.Contratos.Compras;

namespace EcommerceAPI.Configuracion.Container
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
            CreateMap<ProductoEntity, ProductoContract>().ReverseMap();
            CreateMap<CategoriaEntity, CategoriaContract>().ReverseMap();
            CreateMap<DetalleCompraEntity, DetalleCompraContract>().ReverseMap();
            CreateMap<EstadoEntity, EstadoContract>().ReverseMap();
            CreateMap<CompraEntity, CompraContract>().ReverseMap();
        }
    }
}
