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
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
            CreateMap<ProductoEntity,ProductoContract>().ReverseMap();
        }
    }
}
